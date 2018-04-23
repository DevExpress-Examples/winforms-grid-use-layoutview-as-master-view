Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form


		Public Sub New()
			InitializeComponent()
		End Sub

		Private helper As MasterDetailHelper

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)
			' TODO: This line of code loads data into the 'nwindDataSet.Order_Details' table. You can move, or remove it, as needed.
			Me.order_DetailsTableAdapter.Fill(Me.nwindDataSet.Order_Details)

			gridControl1.ForceInitialize()
			helper = New MasterDetailHelper(layoutView1, ViewType.Grid)
			helper.CreateDetail()

			radioGroup1.Properties.Items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(ViewType.Grid, "Grid"))
			radioGroup1.Properties.Items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(ViewType.Layout, "Layout"))
			radioGroup1.Properties.Items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(ViewType.Card, "Card"))
			radioGroup1.SelectedIndex = 0
		End Sub

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			helper.ViewType = CType(radioGroup1.EditValue, ViewType)
		End Sub


	End Class
End Namespace
