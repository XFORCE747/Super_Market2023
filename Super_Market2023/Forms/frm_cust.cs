using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Super_Market2023.Forms
{
    public partial class frm_cust: DevExpress.XtraEditors.XtraForm
    {
        public frm_cust()
        {
            InitializeComponent();
        }

        CLASSES.cls_cust ncls_cust = new CLASSES.cls_cust();

        public void power()
        {

            
            
                 btn_cust_delete.Visible = CLASSES.clc_users.Permissions;
                 btn_cust_show.Visible = CLASSES.clc_users.Permissions;

           
 

        }

        private void frm_cust_Load(object sender, EventArgs e)
        {

            gridView_cust.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView_cust.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView_cust.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView_cust.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


            if (CLASSES.clc_users.Permissions== true)
            {
                btn_cust_delete.Enabled = true;
                btn_cust_show.Enabled = true;
            }
            else
            {
                btn_cust_delete.Enabled = false;
                btn_cust_show.Enabled = false;
            }

           

            clear_data();
            
        }
        public void clear_data() 
        {

            gridControl_cust.DataSource = CLASSES.cls_cust.cust_data.select_cust();



            gridView_cust.Columns["cust_name"].Caption = "اسم الزبون";
            gridView_cust.Columns["cust_phone"].Caption = "رقم الهاتف";
            gridView_cust.Columns["cust_address"].Caption = "العنوان";


            gridView_cust.Columns.Remove(gridView_cust.Columns["cust_id"]);

        }

        public static int cust_id;

        private void gridView_cust_DoubleClick(object sender, EventArgs e)
        {
            ncls_cust.cust_list_by_name_ph_app(gridView_cust.GetRowCellValue(gridView_cust.FocusedRowHandle, gridView_cust.Columns["cust_name"]).ToString(),gridView_cust.GetRowCellValue(gridView_cust.FocusedRowHandle, gridView_cust.Columns["cust_phone"]).ToString(),gridView_cust.GetRowCellValue(gridView_cust.FocusedRowHandle, gridView_cust.Columns["cust_address"]).ToString());

            cust_id = CLASSES.cls_cust.cust_id;


           



            





        }

        private void btn_cust_delete_Click(object sender, EventArgs e)
        {
            frm_data_cust frm_custData = new frm_data_cust();
            frm_custData.Show();
            btn_cust_delete.Visible = false;
            btn_cust_show.Visible = false;
        }

        private void txt_search_inv_TextChanged(object sender, EventArgs e)
        {
            gridControl_cust.DataSource = CLASSES.cls_cust.cust_data.search_cust(txt_search_inv.Text);
        }

       
    }
}