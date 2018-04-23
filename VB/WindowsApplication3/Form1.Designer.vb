Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.colOrderID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEmployeeID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRequiredDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipVia1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFreight1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsApplication3.nwindDataSet()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colOrderID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colOrderID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colCustomerID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colEmployeeID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colEmployeeID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colRequiredDate = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colRequiredDate = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colShipVia = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colShipVia = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colFreight = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colFreight = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.orderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.order_DetailsTableAdapter = New WindowsApplication3.nwindDataSetTableAdapters.Order_DetailsTableAdapter()
			Me.ordersTableAdapter = New WindowsApplication3.nwindDataSetTableAdapters.OrdersTableAdapter()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colEmployeeID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colRequiredDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colShipVia, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colFreight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cardView1
			' 
			Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID1, Me.colCustomerID1, Me.colEmployeeID1, Me.colRequiredDate1, Me.colShipVia1, Me.colFreight1})
			Me.cardView1.FocusedCardTopFieldIndex = 0
			Me.cardView1.GridControl = Me.gridControl1
			Me.cardView1.Name = "cardView1"
			' 
			' colOrderID1
			' 
			Me.colOrderID1.FieldName = "OrderID"
			Me.colOrderID1.Name = "colOrderID1"
			Me.colOrderID1.Visible = True
			Me.colOrderID1.VisibleIndex = 0
			' 
			' colCustomerID1
			' 
			Me.colCustomerID1.FieldName = "CustomerID"
			Me.colCustomerID1.Name = "colCustomerID1"
			Me.colCustomerID1.Visible = True
			Me.colCustomerID1.VisibleIndex = 1
			' 
			' colEmployeeID1
			' 
			Me.colEmployeeID1.FieldName = "EmployeeID"
			Me.colEmployeeID1.Name = "colEmployeeID1"
			Me.colEmployeeID1.Visible = True
			Me.colEmployeeID1.VisibleIndex = 2
			' 
			' colRequiredDate1
			' 
			Me.colRequiredDate1.FieldName = "RequiredDate"
			Me.colRequiredDate1.Name = "colRequiredDate1"
			Me.colRequiredDate1.Visible = True
			Me.colRequiredDate1.VisibleIndex = 3
			' 
			' colShipVia1
			' 
			Me.colShipVia1.FieldName = "ShipVia"
			Me.colShipVia1.Name = "colShipVia1"
			Me.colShipVia1.Visible = True
			Me.colShipVia1.VisibleIndex = 4
			' 
			' colFreight1
			' 
			Me.colFreight1.FieldName = "Freight"
			Me.colFreight1.Name = "colFreight1"
			Me.colFreight1.Visible = True
			Me.colFreight1.VisibleIndex = 5
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.ordersBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.layoutView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(930, 542)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1, Me.cardView1})
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' layoutView1
			' 
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colOrderID, Me.colCustomerID, Me.colEmployeeID, Me.colRequiredDate, Me.colShipVia, Me.colFreight})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
			' 
			' colOrderID
			' 
			Me.colOrderID.FieldName = "OrderID"
			Me.colOrderID.LayoutViewField = Me.layoutViewField_colOrderID
			Me.colOrderID.Name = "colOrderID"
			' 
			' layoutViewField_colOrderID
			' 
			Me.layoutViewField_colOrderID.EditorPreferredWidth = 109
			Me.layoutViewField_colOrderID.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colOrderID.Name = "layoutViewField_colOrderID"
			Me.layoutViewField_colOrderID.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colOrderID.TextSize = New System.Drawing.Size(86, 16)
			' 
			' colCustomerID
			' 
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.LayoutViewField = Me.layoutViewField_colCustomerID
			Me.colCustomerID.Name = "colCustomerID"
			' 
			' layoutViewField_colCustomerID
			' 
			Me.layoutViewField_colCustomerID.EditorPreferredWidth = 109
			Me.layoutViewField_colCustomerID.Location = New System.Drawing.Point(0, 20)
			Me.layoutViewField_colCustomerID.Name = "layoutViewField_colCustomerID"
			Me.layoutViewField_colCustomerID.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colCustomerID.TextSize = New System.Drawing.Size(86, 16)
			' 
			' colEmployeeID
			' 
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.LayoutViewField = Me.layoutViewField_colEmployeeID
			Me.colEmployeeID.Name = "colEmployeeID"
			' 
			' layoutViewField_colEmployeeID
			' 
			Me.layoutViewField_colEmployeeID.EditorPreferredWidth = 109
			Me.layoutViewField_colEmployeeID.Location = New System.Drawing.Point(0, 40)
			Me.layoutViewField_colEmployeeID.Name = "layoutViewField_colEmployeeID"
			Me.layoutViewField_colEmployeeID.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colEmployeeID.TextSize = New System.Drawing.Size(86, 16)
			' 
			' colRequiredDate
			' 
			Me.colRequiredDate.FieldName = "RequiredDate"
			Me.colRequiredDate.LayoutViewField = Me.layoutViewField_colRequiredDate
			Me.colRequiredDate.Name = "colRequiredDate"
			' 
			' layoutViewField_colRequiredDate
			' 
			Me.layoutViewField_colRequiredDate.EditorPreferredWidth = 109
			Me.layoutViewField_colRequiredDate.Location = New System.Drawing.Point(0, 60)
			Me.layoutViewField_colRequiredDate.Name = "layoutViewField_colRequiredDate"
			Me.layoutViewField_colRequiredDate.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colRequiredDate.TextSize = New System.Drawing.Size(86, 16)
			' 
			' colShipVia
			' 
			Me.colShipVia.FieldName = "ShipVia"
			Me.colShipVia.LayoutViewField = Me.layoutViewField_colShipVia
			Me.colShipVia.Name = "colShipVia"
			' 
			' layoutViewField_colShipVia
			' 
			Me.layoutViewField_colShipVia.EditorPreferredWidth = 109
			Me.layoutViewField_colShipVia.Location = New System.Drawing.Point(0, 80)
			Me.layoutViewField_colShipVia.Name = "layoutViewField_colShipVia"
			Me.layoutViewField_colShipVia.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colShipVia.TextSize = New System.Drawing.Size(86, 16)
			' 
			' colFreight
			' 
			Me.colFreight.FieldName = "Freight"
			Me.colFreight.LayoutViewField = Me.layoutViewField_colFreight
			Me.colFreight.Name = "colFreight"
			' 
			' layoutViewField_colFreight
			' 
			Me.layoutViewField_colFreight.EditorPreferredWidth = 109
			Me.layoutViewField_colFreight.Location = New System.Drawing.Point(0, 100)
			Me.layoutViewField_colFreight.Name = "layoutViewField_colFreight"
			Me.layoutViewField_colFreight.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colFreight.TextSize = New System.Drawing.Size(86, 16)
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colOrderID, Me.layoutViewField_colCustomerID, Me.layoutViewField_colEmployeeID, Me.layoutViewField_colRequiredDate, Me.layoutViewField_colShipVia, Me.layoutViewField_colFreight})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			' 
			' orderDetailsBindingSource
			' 
			Me.orderDetailsBindingSource.DataMember = "Order Details"
			Me.orderDetailsBindingSource.DataSource = Me.nwindDataSet
			' 
			' order_DetailsTableAdapter
			' 
			Me.order_DetailsTableAdapter.ClearBeforeFill = True
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.radioGroup1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 542)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(930, 52)
			Me.panelControl1.TabIndex = 2
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Location = New System.Drawing.Point(49, 6)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Size = New System.Drawing.Size(318, 34)
			Me.radioGroup1.TabIndex = 0
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(930, 594)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colOrderID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colEmployeeID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colRequiredDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colShipVia, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colFreight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private nwindDataSet As nwindDataSet
		Private orderDetailsBindingSource As System.Windows.Forms.BindingSource
		Private order_DetailsTableAdapter As WindowsApplication3.nwindDataSetTableAdapters.Order_DetailsTableAdapter
		Private ordersBindingSource As System.Windows.Forms.BindingSource
		Private ordersTableAdapter As WindowsApplication3.nwindDataSetTableAdapters.OrdersTableAdapter
		Private colOrderID As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colOrderID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colCustomerID As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colCustomerID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colEmployeeID As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colEmployeeID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colRequiredDate As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colRequiredDate As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colShipVia As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colShipVia As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colFreight As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colFreight As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private colOrderID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomerID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colEmployeeID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colRequiredDate1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipVia1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colFreight1 As DevExpress.XtraGrid.Columns.GridColumn
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
	End Class
End Namespace

