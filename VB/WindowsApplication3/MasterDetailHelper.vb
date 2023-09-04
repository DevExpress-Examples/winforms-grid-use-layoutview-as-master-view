Imports System
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsApplication3

    Public Enum ViewType
        Grid
        Layout
        Card
    End Enum

    Public Class MasterDetailHelper

        Private view, detailViewField As ColumnView

        Private viewTypeField As ViewType

        Private detailGridField As GridControl

        Public Sub New(ByVal view As ColumnView, ByVal viewType As ViewType)
            Me.view = view
            viewTypeField = viewType
        End Sub

        Public ReadOnly Property DetailGrid As GridControl
            Get
                If detailGridField Is Nothing Then
                    detailGridField = CreateGrid()
                    detailGridField.MainView = DetailView
                End If

                Return detailGridField
            End Get
        End Property

        Public ReadOnly Property DetailView As ColumnView
            Get
                If detailViewField Is Nothing Then detailViewField = CreateView()
                Return detailViewField
            End Get
        End Property

        Public Property ViewType As ViewType
            Get
                Return viewTypeField
            End Get

            Set(ByVal value As ViewType)
                If viewTypeField <> value Then
                    viewTypeField = value
                    detailViewField = Nothing
                    DetailGrid.MainView = DetailView
                End If
            End Set
        End Property

        Public Sub CreateDetail()
            SetColumnEdit(CreateColumn())
        End Sub

        Private Function CreateGrid() As GridControl
            Dim grid As GridControl = New GridControl()
            grid.Dock = DockStyle.Fill
            Return grid
        End Function

        Private Function CreateView() As ColumnView
            If viewTypeField = ViewType.Card Then
                detailViewField = New CardView(DetailGrid)
            ElseIf viewTypeField = ViewType.Grid Then
                detailViewField = New GridView(DetailGrid)
                CType(detailViewField, GridView).OptionsView.ShowGroupPanel = False
            Else
                detailViewField = New LayoutView(DetailGrid)
            End If

            Return detailViewField
        End Function

        Private Function CreateColumn() As GridColumn
            Dim column As GridColumn = view.Columns.AddField("Detail")
            column.Visible = True
            column.VisibleIndex = view.Columns.Count
            Return column
        End Function

        Private Sub SetColumnEdit(ByVal column As GridColumn)
            column.ColumnEdit = CreateItem()
        End Sub

        Private Function CreateItem() As RepositoryItemPopupContainerEdit
            Dim item As RepositoryItemPopupContainerEdit = New RepositoryItemPopupContainerEdit()
            item.PopupControl = CreatePopupControl()
            item.ShowPopupShadow = False
            item.ShowPopupCloseButton = item.ShowPopupShadow
            item.PopupSizeable = False
            item.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            AddHandler item.QueryPopUp, AddressOf OnPopup
            AddHandler item.CloseUp, AddressOf OnCloseUp
            view.GridControl.RepositoryItems.Add(item)
            Return item
        End Function

        Private Function CreatePopupControl() As PopupContainerControl
            Dim popupControl As PopupContainerControl = New PopupContainerControl()
            popupControl.Controls.Add(DetailGrid)
            Return popupControl
        End Function

        Private Sub OnPopup(ByVal sender As Object, ByVal e As EventArgs)
            DetailGrid.BeginUpdate()
            Try
                DetailGrid.DataSource = Nothing
                DetailGrid.DataSource = GetDetailData()
            Finally
                DetailGrid.EndUpdate()
            End Try

            Dim edit As PopupContainerEdit = TryCast(sender, PopupContainerEdit)
            If edit.Properties.PopupControl.Parent Is Nothing Then edit.Properties.PopupControl.Parent = edit.FindForm()
            DetailGrid.ForceInitialize()
            edit.Properties.PopupFormSize = CalcDetailViewSize()
        End Sub

        Private Function GetDetailData() As IList
            Return view.DataController.GetDetailList(view.FocusedRowHandle, 0)
        End Function

        Private Function CalcDetailViewSize() As System.Drawing.Size
            Dim viewInfo As ColumnViewInfo = TryCast(DetailView.GetViewInfo(), ColumnViewInfo)
            Dim rect As Rectangle = New Rectangle(0, 0, view.GridControl.ClientSize.Width, DetailView.DetailHeight)
            rect.Height = viewInfo.CalcRealViewHeight(rect) + 5
            Return rect.Size
        End Function

        Private Sub OnCloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
            DetailView.PostEditor()
            detailViewField.UpdateCurrentRow()
        End Sub
    End Class
End Namespace
