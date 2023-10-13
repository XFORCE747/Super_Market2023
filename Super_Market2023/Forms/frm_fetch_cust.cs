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
    public partial class frm_fetch_cust : Form
    {
        
        public frm_fetch_cust()
        {
            InitializeComponent();
        }

        CLASSES.cls_cust ncls_cust = new CLASSES.cls_cust();
       

       


        private void frm_fetch_cust_Load(object sender, EventArgs e)
        {
            gridView_cust_loan_list.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView_cust_loan_list.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView_cust_loan_list.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView_cust_loan_list.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            clear_data();
        }
        public void clear_data()
        {

            gridControl_cust_loan_list.DataSource = CLASSES.cls_cust.cust_data.select_cust();



            gridView_cust_loan_list.Columns["cust_name"].Caption = "اسم الزبون";
            gridView_cust_loan_list.Columns["cust_phone"].Caption = "رقم الهاتف";
            gridView_cust_loan_list.Columns["cust_address"].Caption = "العنوان";


            gridView_cust_loan_list.Columns.Remove(gridView_cust_loan_list.Columns["cust_id"]);

        }

        private void txt_search_cust_fetch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gridView_cust_loan_list_DoubleClick(object sender, EventArgs e)
        {


            ncls_cust.cust_list_by_name_ph_app(gridView_cust_loan_list.GetRowCellValue(gridView_cust_loan_list.FocusedRowHandle, gridView_cust_loan_list.Columns["cust_name"]).ToString(), gridView_cust_loan_list.GetRowCellValue(gridView_cust_loan_list.FocusedRowHandle, gridView_cust_loan_list.Columns["cust_phone"]).ToString(), gridView_cust_loan_list.GetRowCellValue(gridView_cust_loan_list.FocusedRowHandle, gridView_cust_loan_list.Columns["cust_address"]).ToString());
                       
            // انقل البيانات إلى الفورم الأول
            frm_sale_add form1 = Application.OpenForms.OfType<frm_sale_add>().FirstOrDefault();
           


            int focusedRowHandle = gridView_cust_loan_list.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                string data1 = gridView_cust_loan_list.GetRowCellValue(focusedRowHandle, "cust_name").ToString();
                string data2 = gridView_cust_loan_list.GetRowCellValue(focusedRowHandle, "cust_phone").ToString();
                string data3 = gridView_cust_loan_list.GetRowCellValue(focusedRowHandle, "cust_address").ToString();

                 //قم بنقل البيانات إلى TextBoxes في الفورم الأول
                form1.txt_cust_name.Text = data1;
                form1.txt_cust_phone.Text = data2;
                form1.txt_cust_adress.Text = data3;
            }

            // قم بإغلاق الفورم الثانية
            this.Close();




        }
        


    }
}
