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
using Super_Market2023.Forms;

namespace Super_Market2023.Forms
{
    public partial class frm_cat_add : DevExpress.XtraEditors.XtraForm
    {
        CLASSES.cls_cat mcls_cat = new CLASSES.cls_cat();

        public frm_cat_add()
        {
            InitializeComponent();
        }
        public void clear_data()
        {
            gridControl_cat.DataSource = mcls_cat.data_list(txt_search_cat.Text);
            gridView1.Columns.Remove(gridView1.Columns["cat_id"]);
            gridView1.Columns["cat_name"].Caption = "اسم الصنف";
            gridView1.Columns["cat_discriptoin"].Caption = "مواصفات الصنف ";

            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            txt_cat_note.Text = "";
            txt_name_cat.Text = "";
            




        }


        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void frm_cat_add_Load(object sender, EventArgs e)
        {
            clear_data();
            
        }

        private void txt_search_cat_EditValueChanged(object sender, EventArgs e)
        {
            clear_data();
        }

        private void btn_cat_add_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txt_name_cat.Text))
                {
                    MessageBox.Show("يرجى إدخال اسم الصنف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CLASSES.cls_cat.CAT_DATA.Insert_cat(txt_name_cat.Text, txt_cat_note.Text);
                clear_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            try
            {

                mcls_cat.data_list(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["cat_name"]).ToString());

                txt_name_cat.Text = CLASSES.cls_cat.cat_name;
                txt_cat_note.Text = CLASSES.cls_cat.cat_description;

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cat_edit_Click(object sender, EventArgs e)
        {


           
            try
            {

                if (string.IsNullOrEmpty(txt_name_cat.Text))
                {

                    MessageBox.Show("يرجى تعبئة الحقول ");
                }
                else
                {
                    CLASSES.cls_cat.CAT_DATA.Update_cat(txt_name_cat.Text, txt_cat_note.Text, CLASSES.cls_cat.cat_id, CLASSES.cls_cat.cat_id);
                    clear_data(); 

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
            
        }




        private void btn_cat_del_Click(object sender, EventArgs e)
        {

            try
            {
                CLASSES.cls_cat.CAT_DATA.Delete_cat(CLASSES.cls_cat.cat_id);
                clear_data();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            

        }

        private void btn_cat_clear_Click(object sender, EventArgs e)
        {
            txt_cat_note.Text = "";
            txt_name_cat.Text = "";
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}