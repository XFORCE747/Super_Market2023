using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Super_Market2023.Forms
{
    public partial class frm_req : Form
    {
        public frm_req()
        {
            InitializeComponent();
        }
        
        CLASSES.cls_inv ncls_inv = new CLASSES.cls_inv();
        private void frm_req_Load(object sender, EventArgs e)
        {
            try
            {
                 gridView_req.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView_req.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView_req.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView_req.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


            gridView_req.Columns.Remove(gridView_req.Columns["cust_id"]);
            gridView_req.Columns.Remove(gridView_req.Columns["inv_id"]);






            gridControl_req.DataSource = CLASSES.cls_inv.inv_data.data_request();


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
                gridControl_req.DataSource = CLASSES.cls_inv.inv_data.data_request();



                gridView_req.Columns["cust_name"].Caption = "اسم الزبون";
                gridView_req.Columns["inv_pro_name"].Caption = "رقم الهاتف";
                gridView_req.Columns["inv_stat"].Caption = "حالة الدفع";
                gridView_req.Columns["inv_total"].Caption = "السعر";
                gridView_req.Columns["inv_time"].Caption = "الوقت";
                gridView_req.Columns["inv_date"].Caption = "التاريخ";


                gridView_req.Columns.Remove(gridView_req.Columns["cust_id"]);
                gridView_req.Columns.Remove(gridView_req.Columns["inv_id"]);

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        
        private void gridView_req_DoubleClick(object sender, EventArgs e)
        {
            

            

            
        }

        private void btn_req_Click(object sender, EventArgs e)
        {

            try
            {
                int rowIndex = gridView_req.FocusedRowHandle;

                gridView_req.SetRowCellValue(rowIndex, "inv_stat", "بيع");

                gridView_req.UpdateCurrentRow();

                string newValue = "بيع";

                int recordID = Convert.ToInt32(gridView_req.GetRowCellValue(rowIndex, "inv_id"));

                string connectionString = Forms.FormMainMenu.Databasecon;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE invoice_tbl SET inv_stat = @NewValue WHERE inv_id = @RecordID";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewValue", newValue);
                        command.Parameters.AddWithValue("@RecordID", recordID);
                        command.ExecuteNonQuery();
                    }
                }

                clear_data();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_req_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = gridView_req.FocusedRowHandle;

                int recordID = Convert.ToInt32(gridView_req.GetRowCellValue(rowIndex, "inv_id"));

                string connectionString = Forms.FormMainMenu.Databasecon;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM invoice_tbl WHERE inv_id = @RecordID";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@RecordID", recordID);
                        command.ExecuteNonQuery();
                    }
                }

                // احذف السجل من العرض الجدولي بعد الحذف من قاعدة البيانات
                gridView_req.DeleteRow(rowIndex);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("يجب الحذف من قائمة الديون اولا: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clear_data();
        }
    }
}
