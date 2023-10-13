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
    public partial class frm_pro_add : Form
    {
        public frm_pro_add()
        {
            InitializeComponent();
        }
        CLASSES.cls_cat mcls_cat = new CLASSES.cls_cat();
        CLASSES.cls_pro mcls_pro = new CLASSES.cls_pro();
        int cat_id;


        public void clear_data()
        {
            try
            {
                com_cat_name.DataSource = CLASSES.cls_cat.CAT_DATA.GetData();
                com_cat_name.ValueMember = "cat_name";
                gridControl_pro.DataSource = mcls_pro.datalist(txt_search_pro.Text);

                

                gridView1.Columns.Remove(gridView1.Columns["pro_id"]);
                gridView1.Columns.Remove(gridView1.Columns["cat_id"]);
                gridView1.Columns["pro_name"].Caption = "اسم المنتج";
                gridView1.Columns["cat_name"].Caption = "الصنف";
                gridView1.Columns["pro_price"].Caption = "سعر المنتج";
                gridView1.Columns["pro_company"].Caption = "اسم الشركة";
                gridView1.Columns["pro_quantity"].Caption = "الكمية الموجودة";
                

                txt_cat_price.Text = "";
                txt_company.Text = "";
                txt_name_pro.Text = "";
                txt_num.Text = "";
                com_cat_name.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء مسح البيانات: " + ex.Message);
            }


        }

        private void frm_pro_add_Load(object sender, EventArgs e)
        {

            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            clear_data();

        }

        private void txt_search_pro_EditValueChanged(object sender, EventArgs e)
        {
            clear_data();
        }

        private void com_cat_name_SelectedIndexChanged(object sender, EventArgs e)

        {
            try
            {
                mcls_cat.data_list(com_cat_name.Text);
                cat_id = CLASSES.cls_cat.cat_id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الصنف: " + ex.Message);
            }
        }

        private void btn_pro_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_name_pro.Text))
                {
                    MessageBox.Show(" ادخل اسم المنتج: ");
                }
                else
                {
                    CLASSES.cls_pro.data.Insert_pro(txt_name_pro.Text, Convert.ToDecimal(txt_cat_price.Text), Convert.ToInt32(txt_num.Text), txt_company.Text, cat_id);
                    clear_data();
                   
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(" ادخل اسم المنتج: " + ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                mcls_pro.datalist(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["pro_name"]).ToString());
                txt_name_pro.Text = CLASSES.cls_pro.pro_name;
                txt_cat_price.Text = CLASSES.cls_pro.pro_price.ToString();
                txt_num.Text = CLASSES.cls_pro.pro_quantity.ToString();
                txt_company.Text = CLASSES.cls_pro.pro_company;
                mcls_cat.data_list(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["cat_name"]).ToString());
                com_cat_name.Text = CLASSES.cls_cat.cat_name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل المنتج: " + ex.Message);
            }

        }

        private void btn_pro_clear_Click(object sender, EventArgs e)
        {
            txt_cat_price.Text = "";
            txt_company.Text = "";
            txt_name_pro.Text = "";
            txt_num.Text = "";
            com_cat_name.Text = "";
        }

        private void btn_pro_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_name_pro.Text))
                {
                    MessageBox.Show("يرجى اختيار منتج لتعديله");
                }
                else
                {
                    CLASSES.cls_pro.data.Update_pro(txt_name_pro.Text, Convert.ToDecimal(txt_cat_price.Text), Convert.ToInt32(txt_num.Text), txt_company.Text, cat_id, CLASSES.cls_pro.pro_id, CLASSES.cls_pro.pro_id);
                    clear_data();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تعديل المنتج: " + ex.Message);
            }
        }

        private void btn_pro_del_Click(object sender, EventArgs e)
        {
            
                try
                {
                    DialogResult result = MessageBox.Show("هل أنت متأكد من رغبتك في حذف المنتج؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        CLASSES.cls_pro.data.Delete_pro(CLASSES.cls_pro.pro_id);
                        clear_data();
                        
                        MessageBox.Show("تم حذف المنتج بنجاح.", "حذف ناجح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء حذف المنتج: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
        }

        private void gridControl_pro_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
