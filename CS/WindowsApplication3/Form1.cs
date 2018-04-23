using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace WindowsApplication3 {
    public partial class Form1: Form {

        
        public Form1() {
            InitializeComponent();
        }

        MasterDetailHelper helper;

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
            // TODO: This line of code loads data into the 'nwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.nwindDataSet.Order_Details);

            gridControl1.ForceInitialize();
            helper = new MasterDetailHelper(layoutView1, ViewType.Grid);
            helper.CreateDetail();

            radioGroup1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(ViewType.Grid, "Grid"));
            radioGroup1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(ViewType.Layout, "Layout"));
            radioGroup1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(ViewType.Card, "Card"));
            radioGroup1.SelectedIndex = 0;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            helper.ViewType = (ViewType)radioGroup1.EditValue;
        }

       
    }
}
