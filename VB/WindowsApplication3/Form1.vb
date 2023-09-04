Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsApplication3

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private helper As MasterDetailHelper

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            ordersTableAdapter.Fill(nwindDataSet.Orders)
            ' TODO: This line of code loads data into the 'nwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            order_DetailsTableAdapter.Fill(nwindDataSet.Order_Details)
            gridControl1.ForceInitialize()
            helper = New MasterDetailHelper(layoutView1, ViewType.Grid)
            helper.CreateDetail()
            radioGroup1.Properties.Items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(ViewType.Grid, "Grid"))
            radioGroup1.Properties.Items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(ViewType.Layout, "Layout"))
            radioGroup1.Properties.Items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(ViewType.Card, "Card"))
            radioGroup1.SelectedIndex = 0
        End Sub

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            helper.ViewType = CType(radioGroup1.EditValue, ViewType)
        End Sub
    End Class
End Namespace
