Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
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
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors.Popup

Namespace WindowsApplication3
	Public Enum ViewType
		Grid
		Layout
		Card
	End Enum
	Public Class MasterDetailHelper
		Private view, detailView_Renamed As ColumnView
		Private viewType_Renamed As ViewType
		Private detailGrid_Renamed As GridControl

		Public Sub New(ByVal view As ColumnView, ByVal viewType As ViewType)
			Me.view = view
			Me.viewType_Renamed = viewType
		End Sub


		Public ReadOnly Property DetailGrid() As GridControl
			Get
				If detailGrid_Renamed Is Nothing Then
					detailGrid_Renamed = CreateGrid()
					detailGrid_Renamed.MainView = DetailView
				End If
				Return detailGrid_Renamed
			End Get
		End Property

		Public ReadOnly Property DetailView() As ColumnView
			Get
				If detailView_Renamed Is Nothing Then
					detailView_Renamed = CreateView()
				End If
				Return detailView_Renamed
			End Get
		End Property

		Public Property ViewType() As ViewType
			Get
				Return viewType_Renamed
			End Get
			Set(ByVal value As ViewType)
				If viewType_Renamed <> value Then
					viewType_Renamed = value
					detailView_Renamed = Nothing
					DetailGrid.MainView = DetailView
				End If
			End Set
		End Property

		Public Sub CreateDetail()
			SetColumnEdit(CreateColumn())
		End Sub

		Private Function CreateGrid() As GridControl
			Dim grid As New GridControl()
			grid.Dock = System.Windows.Forms.DockStyle.Fill
			Return grid
		End Function

		Private Function CreateView() As ColumnView
			If viewType_Renamed = ViewType.Card Then
				detailView_Renamed = New CardView(DetailGrid)
			ElseIf viewType_Renamed = ViewType.Grid Then
				detailView_Renamed = New GridView(DetailGrid)
				CType(detailView_Renamed, GridView).OptionsView.ShowGroupPanel = False
			Else
				detailView_Renamed = New LayoutView(DetailGrid)
			End If
			Return detailView_Renamed
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
			Dim item As New RepositoryItemPopupContainerEdit()
			item.PopupControl = CreatePopupControl()
			item.ShowPopupShadow = False
			item.ShowPopupCloseButton = item.ShowPopupShadow
			item.PopupSizeable = False
			item.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            AddHandler item.QueryPopUp, AddressOf OnPopUp
			AddHandler item.CloseUp, AddressOf OnCloseUp
			view.GridControl.RepositoryItems.Add(item)
			Return item
		End Function

		Private Function CreatePopupControl() As PopupContainerControl
			Dim popupControl As New PopupContainerControl()
			popupControl.Controls.Add(DetailGrid)
			Return popupControl
		End Function


        Private Sub OnPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            DetailGrid.BeginUpdate()
            Try
                DetailGrid.DataSource = Nothing
                DetailGrid.DataSource = GetDetailData()
            Finally
                DetailGrid.EndUpdate()
            End Try
            Dim edit As PopupContainerEdit = TryCast(sender, PopupContainerEdit)
            If edit.Properties.PopupControl.Parent Is Nothing Then
                edit.Properties.PopupControl.Parent = edit.FindForm()
            End If
            DetailGrid.ForceInitialize()
            edit.Properties.PopupFormSize = CalcDetailViewSize()
        End Sub

        Private Function GetDetailData() As IList
            Return view.DataController.GetDetailList(view.FocusedRowHandle, 0)
        End Function

        Private Function CalcDetailViewSize() As System.Drawing.Size
            Dim viewInfo As ColumnViewInfo = TryCast(DetailView.GetViewInfo(), ColumnViewInfo)
            Dim rect As New Rectangle(0, 0, view.GridControl.ClientSize.Width, DetailView.DetailHeight)
            rect.Height = viewInfo.CalcRealViewHeight(rect) + 5
            Return rect.Size
        End Function

        Private Sub OnCloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
            DetailView.PostEditor()
            detailView_Renamed.UpdateCurrentRow()
        End Sub
    End Class
End Namespace
