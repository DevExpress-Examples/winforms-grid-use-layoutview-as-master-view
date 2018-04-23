namespace WindowsApplication3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colOrderID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipVia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreight1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WindowsApplication3.nwindDataSet();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colOrderID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colOrderID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCustomerID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colEmployeeID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colRequiredDate = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colRequiredDate = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colShipVia = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colShipVia = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFreight = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colFreight = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_DetailsTableAdapter = new WindowsApplication3.nwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.ordersTableAdapter = new WindowsApplication3.nwindDataSetTableAdapters.OrdersTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colOrderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colEmployeeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRequiredDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShipVia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFreight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderID1,
            this.colCustomerID1,
            this.colEmployeeID1,
            this.colRequiredDate1,
            this.colShipVia1,
            this.colFreight1});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // colOrderID1
            // 
            this.colOrderID1.FieldName = "OrderID";
            this.colOrderID1.Name = "colOrderID1";
            this.colOrderID1.Visible = true;
            this.colOrderID1.VisibleIndex = 0;
            // 
            // colCustomerID1
            // 
            this.colCustomerID1.FieldName = "CustomerID";
            this.colCustomerID1.Name = "colCustomerID1";
            this.colCustomerID1.Visible = true;
            this.colCustomerID1.VisibleIndex = 1;
            // 
            // colEmployeeID1
            // 
            this.colEmployeeID1.FieldName = "EmployeeID";
            this.colEmployeeID1.Name = "colEmployeeID1";
            this.colEmployeeID1.Visible = true;
            this.colEmployeeID1.VisibleIndex = 2;
            // 
            // colRequiredDate1
            // 
            this.colRequiredDate1.FieldName = "RequiredDate";
            this.colRequiredDate1.Name = "colRequiredDate1";
            this.colRequiredDate1.Visible = true;
            this.colRequiredDate1.VisibleIndex = 3;
            // 
            // colShipVia1
            // 
            this.colShipVia1.FieldName = "ShipVia";
            this.colShipVia1.Name = "colShipVia1";
            this.colShipVia1.Visible = true;
            this.colShipVia1.VisibleIndex = 4;
            // 
            // colFreight1
            // 
            this.colFreight1.FieldName = "Freight";
            this.colFreight1.Name = "colFreight1";
            this.colFreight1.Visible = true;
            this.colFreight1.VisibleIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ordersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(930, 542);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.cardView1});
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colOrderID,
            this.colCustomerID,
            this.colEmployeeID,
            this.colRequiredDate,
            this.colShipVia,
            this.colFreight});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colOrderID
            // 
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.LayoutViewField = this.layoutViewField_colOrderID;
            this.colOrderID.Name = "colOrderID";
            // 
            // layoutViewField_colOrderID
            // 
            this.layoutViewField_colOrderID.EditorPreferredWidth = 109;
            this.layoutViewField_colOrderID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colOrderID.Name = "layoutViewField_colOrderID";
            this.layoutViewField_colOrderID.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colOrderID.TextSize = new System.Drawing.Size(86, 16);
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.LayoutViewField = this.layoutViewField_colCustomerID;
            this.colCustomerID.Name = "colCustomerID";
            // 
            // layoutViewField_colCustomerID
            // 
            this.layoutViewField_colCustomerID.EditorPreferredWidth = 109;
            this.layoutViewField_colCustomerID.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_colCustomerID.Name = "layoutViewField_colCustomerID";
            this.layoutViewField_colCustomerID.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colCustomerID.TextSize = new System.Drawing.Size(86, 16);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.LayoutViewField = this.layoutViewField_colEmployeeID;
            this.colEmployeeID.Name = "colEmployeeID";
            // 
            // layoutViewField_colEmployeeID
            // 
            this.layoutViewField_colEmployeeID.EditorPreferredWidth = 109;
            this.layoutViewField_colEmployeeID.Location = new System.Drawing.Point(0, 40);
            this.layoutViewField_colEmployeeID.Name = "layoutViewField_colEmployeeID";
            this.layoutViewField_colEmployeeID.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colEmployeeID.TextSize = new System.Drawing.Size(86, 16);
            // 
            // colRequiredDate
            // 
            this.colRequiredDate.FieldName = "RequiredDate";
            this.colRequiredDate.LayoutViewField = this.layoutViewField_colRequiredDate;
            this.colRequiredDate.Name = "colRequiredDate";
            // 
            // layoutViewField_colRequiredDate
            // 
            this.layoutViewField_colRequiredDate.EditorPreferredWidth = 109;
            this.layoutViewField_colRequiredDate.Location = new System.Drawing.Point(0, 60);
            this.layoutViewField_colRequiredDate.Name = "layoutViewField_colRequiredDate";
            this.layoutViewField_colRequiredDate.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colRequiredDate.TextSize = new System.Drawing.Size(86, 16);
            // 
            // colShipVia
            // 
            this.colShipVia.FieldName = "ShipVia";
            this.colShipVia.LayoutViewField = this.layoutViewField_colShipVia;
            this.colShipVia.Name = "colShipVia";
            // 
            // layoutViewField_colShipVia
            // 
            this.layoutViewField_colShipVia.EditorPreferredWidth = 109;
            this.layoutViewField_colShipVia.Location = new System.Drawing.Point(0, 80);
            this.layoutViewField_colShipVia.Name = "layoutViewField_colShipVia";
            this.layoutViewField_colShipVia.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colShipVia.TextSize = new System.Drawing.Size(86, 16);
            // 
            // colFreight
            // 
            this.colFreight.FieldName = "Freight";
            this.colFreight.LayoutViewField = this.layoutViewField_colFreight;
            this.colFreight.Name = "colFreight";
            // 
            // layoutViewField_colFreight
            // 
            this.layoutViewField_colFreight.EditorPreferredWidth = 109;
            this.layoutViewField_colFreight.Location = new System.Drawing.Point(0, 100);
            this.layoutViewField_colFreight.Name = "layoutViewField_colFreight";
            this.layoutViewField_colFreight.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colFreight.TextSize = new System.Drawing.Size(86, 16);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colOrderID,
            this.layoutViewField_colCustomerID,
            this.layoutViewField_colEmployeeID,
            this.layoutViewField_colRequiredDate,
            this.layoutViewField_colShipVia,
            this.layoutViewField_colFreight});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Order Details";
            this.orderDetailsBindingSource.DataSource = this.nwindDataSet;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.radioGroup1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 542);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(930, 52);
            this.panelControl1.TabIndex = 2;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(49, 6);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(318, 34);
            this.radioGroup1.TabIndex = 0;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 594);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colOrderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colEmployeeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRequiredDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShipVia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFreight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private WindowsApplication3.nwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private WindowsApplication3.nwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colOrderID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colOrderID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCustomerID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCustomerID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colEmployeeID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colEmployeeID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colRequiredDate;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colRequiredDate;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colShipVia;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colShipVia;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFreight;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colFreight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID1;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colShipVia1;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

