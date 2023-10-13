using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market2023.Forms
{

    public partial class frm_loan : Form
    {

        public frm_loan()
        {
            InitializeComponent();
        }
        CLASSES.cls_loan ncls_loan = new CLASSES.cls_loan();

        private void frm_loan_Load(object sender, EventArgs e)
        {
            try
            {
                gridView_loan.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView_loan.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                gridView_loan.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView_loan.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;



                
                if (CLASSES.clc_users.Permissions == true)
                {
                    btn_loan_del.Enabled = true;
                }
                else
                {
                    btn_loan_del.Enabled = false;
                }

                clear_data();
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void btn_loan_del_Click(object sender, EventArgs e)
        {
            try
            {
                CLASSES.cls_loan.loan_data.Delete_loan(ID);

                clear_data();
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public void clear_data()
        {
            try
            {
          
                gridControl_loan.DataSource = CLASSES.cls_loan.loan_data.select_loan();




                gridView_loan.Columns["cust_name"].Caption = "اسم الزبون";
                gridView_loan.Columns["loan_pro_name"].Caption = "المنتجات";
                gridView_loan.Columns["inv_total"].Caption = "مجموع الفاتورة";
                gridView_loan.Columns["loan_time"].Caption = "الوقت";
                gridView_loan.Columns["loan_date"].Caption = "التاريخ";

                gridView_loan.Columns.Remove(gridView_loan.Columns["loan_id"]);
                gridView_loan.Columns.Remove(gridView_loan.Columns["inv_id"]);

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public static int ID;

        private void gridView_loan_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                gridControl_loan.DataSource = ncls_loan.select_loan(gridView_loan.GetRowCellValue(gridView_loan.FocusedRowHandle, gridView_loan.Columns["cust_name"]).ToString(), gridView_loan.GetRowCellValue(gridView_loan.FocusedRowHandle, gridView_loan.Columns["loan_pro_name"]).ToString());

                ID = CLASSES.cls_loan.loan_id;

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_search_loan_TextChanged(object sender, EventArgs e)
        {
            gridControl_loan.DataSource = ncls_loan.serach_loan(txt_search_loan.Text);
        }
    }
}
