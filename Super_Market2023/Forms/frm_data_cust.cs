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
    public partial class frm_data_cust : DevExpress.XtraEditors.XtraForm
    {
        public frm_data_cust()
        {
            InitializeComponent();
        }

        private void frm_data_cust_Load(object sender, EventArgs e)
        {
            gridView_data_cust.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView_data_cust.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


            try
            {
                if (gridView_data_cust != null)
            {
                gridView_data_cust.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView_data_cust.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                



                
                if (frm_cust.cust_id != null)
                {
                    gridControl_data_cust.DataSource = CLASSES.cls_sa_list.sal_list_data.select_all_data2(frm_cust.cust_id);


                    gridView_data_cust.Columns.Remove(gridView_data_cust.Columns["sal_list_id"]);
                    gridView_data_cust.Columns.Remove(gridView_data_cust.Columns["pro_id"]);
                    gridView_data_cust.Columns.Remove(gridView_data_cust.Columns["cust_id"]);
                    gridView_data_cust.Columns.Remove(gridView_data_cust.Columns["Expr1"]);
                    gridView_data_cust.Columns.Remove(gridView_data_cust.Columns["cust_name"]);


                    gridView_data_cust.Columns["sal_list_date"].Caption = "تاريخ البيع";
                    gridView_data_cust.Columns["sal_list_time"].Caption = "وقت البيع";
                    gridView_data_cust.Columns["sal_list_price"].Caption = "سعر المنتج";
                    gridView_data_cust.Columns["sal_list_quantity"].Caption = "كمية المنتج";
                    //gridView_data_cust.Columns["cust_name"].Caption = "اسم الزبون";
                    gridView_data_cust.Columns["pro_name"].Caption = "اسم المنتج";


                    //gridView_data_cust.Columns["cust_name"].Caption = "اسم الزبون";
                    //gridView_data_cust.Columns["inv_date"].Caption = "تاريخ الفاتورة";
                    //gridView_data_cust.Columns["inv_time"].Caption = "وقت الفاتورة";
                    //gridView_data_cust.Columns["inv_total"].Caption = "مجموع الفاتورة";
                    //gridView_data_cust.Columns["inv_stat"].Caption = "حالة الدفع";
                    //gridView_data_cust.Columns["pro_name"].Caption = "اسم المنتج ";








                    string desiredColumnName = "sal_list_price";

                    if (gridView_data_cust.Columns[desiredColumnName] != null)
                    {
                        decimal sum = 0;

                        for (int i = 0; i < gridView_data_cust.RowCount; i++)
                        {
                            object cellValue = gridView_data_cust.GetRowCellValue(i, desiredColumnName);
                            if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                            {
                                decimal cellDecimalValue;
                                if (decimal.TryParse(cellValue.ToString(), out cellDecimalValue))
                                {
                                    sum += cellDecimalValue;
                                }
                            }
                        }

                        text_totalSum.Text = sum.ToString();
                    }
                    else
                    {
                        text_totalSum.Text = "";
                    }
                }
                else
                {
                   

                }
            }
            else
            {
               

            }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("حدث خطأ : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_closeChildForm_cust_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void belCon_Click(object sender, EventArgs e)
        {

        }
    }
}
