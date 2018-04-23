using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors.Popup;

namespace WindowsApplication3 {
    public enum ViewType { Grid, Layout, Card }
    public class MasterDetailHelper {
        ColumnView view, detailView;
        ViewType viewType;
        GridControl detailGrid;

        public MasterDetailHelper(ColumnView view, ViewType viewType) {
            this.view = view;
            this.viewType = viewType;
        }


        public GridControl DetailGrid {
            get {
                if(detailGrid == null) {
                    detailGrid = CreateGrid();
                    detailGrid.MainView = DetailView;
                }
                return detailGrid;
            }
        }

        public ColumnView DetailView {
            get {
                if(detailView == null)
                    detailView = CreateView();
                return detailView;
            }
        }

        public ViewType ViewType {
            get { return viewType; }
            set {
                if(viewType != value) {
                    viewType = value;
                    detailView = null;
                    DetailGrid.MainView = DetailView;
                }
            }
        }

        public void CreateDetail() {
            SetColumnEdit(CreateColumn());
        }

        private GridControl CreateGrid() {
            GridControl grid = new GridControl();
            grid.Dock = System.Windows.Forms.DockStyle.Fill;
            return grid;
        }

        private ColumnView CreateView() {
            if(viewType == ViewType.Card)
                detailView = new CardView(DetailGrid);
            else if(viewType == ViewType.Grid) {
                detailView = new GridView(DetailGrid);
                ((GridView)detailView).OptionsView.ShowGroupPanel = false;
            }
            else
                detailView = new LayoutView(DetailGrid);
            return detailView;
        }

        private GridColumn CreateColumn() {
            GridColumn column = view.Columns.AddField("Detail");
            column.Visible = true;
            column.VisibleIndex = view.Columns.Count;
            return column;
        }

        private void SetColumnEdit(GridColumn column) {
            column.ColumnEdit = CreateItem();
        }

        private RepositoryItemPopupContainerEdit CreateItem() {
            RepositoryItemPopupContainerEdit item = new RepositoryItemPopupContainerEdit();
            item.PopupControl = CreatePopupControl();
            item.ShowPopupCloseButton = item.ShowPopupShadow = false;
            item.PopupSizeable = false;
            item.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            item.QueryPopUp += OnPopup;
            item.CloseUp += OnCloseUp;
            view.GridControl.RepositoryItems.Add(item);
            return item;
        }
       
        private PopupContainerControl CreatePopupControl() {
            PopupContainerControl popupControl = new PopupContainerControl();
            popupControl.Controls.Add(DetailGrid);
            return popupControl;
        }
       

        void OnPopup(object sender, EventArgs e) {
            DetailGrid.BeginUpdate();
            try {
                DetailGrid.DataSource = null;
                DetailGrid.DataSource = GetDetailData();
            }
            finally {
                DetailGrid.EndUpdate();
            }
            PopupContainerEdit edit = sender as PopupContainerEdit;
            if(edit.Properties.PopupControl.Parent == null)
                edit.Properties.PopupControl.Parent = edit.FindForm();
            DetailGrid.ForceInitialize();
            edit.Properties.PopupFormSize = CalcDetailViewSize();
        }

        private IList GetDetailData() {
            return view.DataController.GetDetailList(view.FocusedRowHandle, 0);
        }

        private System.Drawing.Size CalcDetailViewSize() {
            ColumnViewInfo viewInfo = DetailView.GetViewInfo() as ColumnViewInfo;
            Rectangle rect = new Rectangle(0, 0, view.GridControl.ClientSize.Width, DetailView.DetailHeight);
            rect.Height = viewInfo.CalcRealViewHeight(rect, true) + 5;
            return rect.Size;
        }

        void OnCloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e) {
            DetailView.PostEditor();
            detailView.UpdateCurrentRow();
        }
    }
}
