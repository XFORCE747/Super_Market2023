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
using DevExpress.XtraGrid.Views.Grid;

namespace Super_Market2023.Forms
{
    public partial class frm_sale_add : DevExpress.XtraEditors.XtraForm
    {
        public frm_sale_add()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        CLASSES.cls_pro ncls_pro = new CLASSES.cls_pro();
        CLASSES.cls_sales ncls_sal = new CLASSES.cls_sales();
        CLASSES.cls_cust ncls_cust = new CLASSES.cls_cust();
        CLASSES.cls_inv ncls_inv = new CLASSES.cls_inv();
        CLASSES.cls_sa_list ncls_sal_list = new CLASSES.cls_sa_list();
        int id_x;
        double price_x;
        double quan_x;
        int sal_id;
        bool add_cust;
        decimal tot_pr;
        decimal tot_qu;
        decimal pro_qua;

        public  void filltxt()
        {
            
 
        }
        public void sum_data()
        {



            try
            {
                DataTable dt = new DataTable();
                dt = CLASSES.cls_sales.sal_data.sum_price_and_qu();
                if (decimal.TryParse(dt.Rows[0]["SUM_SAL"].ToString(), out tot_pr))
                {
                    if (decimal.TryParse(dt.Rows[0]["SUM_QUA"].ToString(), out tot_qu))
                    {
                        lbl_total_price.Text = tot_pr.ToString();
                        lbl_total_quantity.Text = tot_qu.ToString();


                    }
                    else
                    {
                        lbl_total_price.Text = "0";
                        lbl_total_quantity.Text = "0";
                    }
                }
                else
                {
                    lbl_total_price.Text = "0";
                    lbl_total_quantity.Text = "0";
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          


        }





        private void frm_sale_add_Load(object sender, EventArgs e)
        {
            try
            {
                gridView3_sale.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView3_sale.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                gridView2_sale.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2_sale.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                clear_data();
                sum_data();
                btn_state();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           



        }
        public void btn_state()
        {


            com_push_stat.Enabled = false;
            txt_cust_name.Enabled = false;
            txt_cust_adress.Enabled = false;
            txt_cust_phone.Enabled = false;
            btn_add_sale.Enabled = false;
            btn_Del_sal.Enabled = false;
 

        }
        public void clear_data()
        {
            try
            {
                gridControl_sale1.DataSource = ncls_pro.datalist(txt_search_sale1.Text);
                gridControl_sale2.DataSource = ncls_sal.datalist("");

                gridView3_sale.Columns.Remove(gridView3_sale.Columns["sal_date"]);
                gridView3_sale.Columns.Remove(gridView3_sale.Columns["sal_list_id"]);
                gridView3_sale.Columns.Remove(gridView3_sale.Columns["cust_id"]);
                gridView3_sale.Columns.Remove(gridView3_sale.Columns["sal_id"]);
                gridView3_sale.Columns.Remove(gridView3_sale.Columns["pro_id"]);
                gridView3_sale.Columns.Remove(gridView3_sale.Columns["Expr1"]);
                gridView3_sale.Columns.Remove(gridView3_sale.Columns["sal_time"]);
                gridView3_sale.Columns.Remove(gridView3_sale.Columns["sal_s_stat"]);
                gridView3_sale.Columns["sal_price"].Caption = "السعر";
                gridView3_sale.Columns["sal_push_stat"].Caption = "نوع الدفع";
                gridView3_sale.Columns["sal_quantity"].Caption = "الكمية";
                //gridView3_sale.Columns["sal_date"].Caption = "التاريخ";
                gridView3_sale.Columns["pro_name"].Caption = "اسم المنتج";


                gridView2_sale.Columns.Remove(gridView2_sale.Columns["pro_id"]);
                gridView2_sale.Columns.Remove(gridView2_sale.Columns["cat_id"]);
                gridView2_sale.Columns["pro_name"].Caption = "اسم المنتج";
                gridView2_sale.Columns["cat_name"].Caption = "الصنف";
                gridView2_sale.Columns["pro_price"].Caption = "سعر المنتج";
                gridView2_sale.Columns["pro_company"].Caption = "اسم الشركة";
                gridView2_sale.Columns["pro_quantity"].Caption = "الكمية الموجودة";

                txt_num_sal.Text = "0";
                add_cust = false;
                btn_fetch_cust.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            

            
            
           

        }

        private void com_stat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (com_stat.Text == "طلبية")
                {

                    com_push_stat.Enabled = false;
                    com_push_stat.Text = "دين";
                    txt_cust_name.Enabled = true;
                    txt_cust_adress.Enabled = true;
                    txt_cust_phone.Enabled = true;

                }
                else if (com_stat.Text == "بيع")
                {

                    com_push_stat.Enabled = true;
                    com_push_stat.Text = "";
                    txt_cust_name.Enabled = false;
                    txt_cust_adress.Enabled = false;
                    txt_cust_phone.Enabled = false;

                }
                else
                {
                    clear_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void com_push_stat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (com_push_stat.Text == "دين")
                {
                    txt_cust_name.Enabled = true;
                    txt_cust_adress.Enabled = true;
                    txt_cust_phone.Enabled = true;
                    btn_fetch_cust.Visible = true;

                }
                else
                {
                    txt_cust_name.Enabled = false;
                    txt_cust_adress.Enabled = false;
                    txt_cust_phone.Enabled = false;
                    btn_fetch_cust.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          


        }

        private void btn_add_sale_Click(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(txt_num_sal.Text) > 0 && id_x != 0 && (com_stat.Text == "طلبية" || com_stat.Text == "بيع") && com_push_stat.Text == "نقدي" || com_push_stat.Text == "دين" && Convert.ToInt32(txt_num_sal.Text) > 0 && id_x != 0)
                {
                    if (Convert.ToDecimal(txt_num_sal.Text) <= Convert.ToDecimal(gridView2_sale.GetRowCellValue(gridView2_sale.FocusedRowHandle, gridView2_sale.Columns["pro_quantity"]).ToString()))
                    {
                        if (is_click_cust==false)
                        {
                            ncls_cust.cust_list();
                        }
               
                        CLASSES.cls_sa_list.sal_list_data.Insertsal_list(
                            Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "yyy/mm/dd").ToString()),
                            DateTime.Now.TimeOfDay,
                            Convert.ToDecimal( price_x),
                            Convert.ToDecimal(txt_num_sal.Text),
                            CLASSES.cls_cust.cust_id,
                            id_x);


                        double result = price_x * Convert.ToInt32(txt_num_sal.Text);


                        ncls_sal_list.select_data();
                        CLASSES.cls_sales.sal_data.Insert_sale(com_stat.Text, com_push_stat.Text, Convert.ToDecimal(result), Convert.ToDecimal(txt_num_sal.Text), id_x, CLASSES.cls_cust.cust_id, CLASSES.cls_sa_list.sal_list_id );





                        double result_qu = quan_x - Convert.ToInt32(txt_num_sal.Text);
                        CLASSES.cls_pro.data.Update_by_quantity(Convert.ToDecimal(result_qu), id_x, id_x);

                    }
                    else
                    {
                        MessageBox.Show("لايوجد لديك بضاعة كافية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("خطأ في عملية البيع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                clear_data();
                sum_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gridView2_sale_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ncls_pro.datalist(gridView2_sale.GetRowCellValue(gridView2_sale.FocusedRowHandle, gridView2_sale.Columns["pro_name"]).ToString());

                id_x = CLASSES.cls_pro.pro_id;

                price_x = CLASSES.cls_pro.pro_price;

                quan_x = CLASSES.cls_pro.pro_quantity;
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        int num_cust = 0;

        private void btn_add_cust_sale_Click(object sender, EventArgs e)
        {
            try
            {
                add_cust = true;

                if (num_cust == 0)
                {
                    if (com_stat.Text == "طلبية" || (com_stat.Text == "بيع" && (com_push_stat.Text == "نقدي" || com_push_stat.Text == "دين")))
                    {
                        CLASSES.cls_cust.cust_data.Insert_cust(txt_cust_name.Text, txt_cust_phone.Text, txt_cust_adress.Text);
                        com_push_stat.Enabled = false;
                        com_stat.Enabled = false;
                        txt_cust_name.Enabled = false;
                        txt_cust_adress.Enabled = false;
                        txt_cust_phone.Enabled = false;
                        btn_add_sale.Enabled = true;
                        btn_Del_sal.Enabled = true;
                        add_cust = false;
                        num_cust++;

                        MessageBox.Show("تم اضافة زبون", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("خطأ في ادخال بيانات الزبون", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("لايمكنك اضافة زبون في الوقت الحالي ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            


        }

        public static int sal_list_id;
        private void gridView3_sale_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ncls_sal.datalist(gridView3_sale.GetRowCellValue(gridView3_sale.FocusedRowHandle, gridView3_sale.Columns["pro_name"]).ToString());
                sal_id = CLASSES.cls_sales.sal_id;
                txt_num_sal.Text = CLASSES.cls_sales.sal_quantity.ToString();
                id_x = CLASSES.cls_sales.pro_id;
                sal_list_id = CLASSES.cls_sales.sal_list_id;
                //MessageBox.Show(sal_list_id.ToString());

                DataTable dtt = CLASSES.cls_sales.sal_data.get_qu(sal_id);

                if (decimal.TryParse(dtt.Rows[0]["pro_quantity"].ToString(), out pro_qua))
                {



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
            
        }

        private void btn_Del_sal_Click(object sender, EventArgs e)
        {
            try
            {
                decimal result_qu = pro_qua + Convert.ToDecimal(txt_num_sal.Text);
                CLASSES.cls_pro.data.Update_by_quantity(Convert.ToDecimal(result_qu), id_x, id_x);
                CLASSES.cls_sa_list.sal_list_data.Delete_sal_list(CLASSES.cls_sales.sal_list_id);

                //CLASSES.cls_sales.sal_data.Delete_sales(CLASSES.cls_sales.sal_id);




                //CLASSES.cls_sales.sal_data.Delete_sales(sal_id);
                clear_data();
                sum_data();
                com_stat.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btn_invoice_sal_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder valuesBuilder = new StringBuilder();


                GridView gridview = gridControl_sale2.MainView as GridView;


                if (gridview != null && gridView3_sale.RowCount > 0)
                {


                    for (int rowIndex = 0; rowIndex < gridview.RowCount; rowIndex++)
                    {


                        DataRow row = gridview.GetDataRow(rowIndex);


                        object cellValue = row["pro_name"];

                        valuesBuilder.Append(cellValue.ToString());
                        valuesBuilder.Append(",");
                    }
                }
                string columnValuesString = valuesBuilder.ToString().TrimEnd(',');




                if (is_click_cust == false)
                {
                    ncls_cust.cust_list();
                }


                CLASSES.cls_inv.inv_data.Insert_inv(Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "yyy/mm/dd").ToString()),
                                DateTime.Now.TimeOfDay,
                                tot_pr
                                , com_stat.Text, columnValuesString, CLASSES.cls_cust.cust_id);

                if (com_push_stat.Text == "دين")
                {

                    ncls_inv.selct_inv_end();

                    CLASSES.cls_loan.loan_data.Insert_loan(
                        Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "yyy/mm/dd").ToString()),
                                DateTime.Now.TimeOfDay, columnValuesString, CLASSES.cls_inv.inv_id);

                    MessageBox.Show("تمت الاضافة الى قائمة الديون", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult result = MessageBox.Show("هل تريد طباعة عملية البيع هذه ؟", "الطباعة", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
                else
                {
                    CLASSES.cls_sales.sal_data.Delete_all_sal();
                    clear_data();
                    sum_data();
                    btn_state();
                    num_cust = 0;
                    com_stat.Enabled = true;
                    com_stat.Text = "";
                    com_push_stat.Text = "";
                    txt_cust_adress.Text = "";
                    txt_cust_name.Text = "";
                    txt_cust_phone.Text = "";
                    is_click_cust = false;

                }

                CLASSES.cls_sales.sal_data.Delete_all_sal();
                clear_data();
                sum_data();
                btn_state();
                num_cust = 0;
                com_stat.Enabled = true;
                com_stat.Text = "";
                com_push_stat.Text = "";
                txt_cust_adress.Text = "";
                txt_cust_name.Text = "";
                txt_cust_phone.Text = "";
                is_click_cust = false;
                txt_search_sale1.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_print_sal_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {

                printDocument1.Print();
 

            }



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                float margin = 30;
                Font f = new Font("Arial", 18, FontStyle.Bold);
                string strNO = "المستخدم" + CLASSES.clc_users.user_name;
                string strDate = "التاريخ:" + DateTime.Now.ToShortDateString();
                string strName = "مطلوب من: " + txt_cust_name.Text;
                string strtTime = "" + DateTime.Now.ToShortTimeString();



                SizeF fontSizeNO = e.Graphics.MeasureString(strNO, f);
                SizeF fontSizeDate = e.Graphics.MeasureString(strDate, f);
                SizeF fontSizeName = e.Graphics.MeasureString(strName, f);
                SizeF fontsizetime = e.Graphics.MeasureString(strtTime, f);
                //SizeF fontsizecust_name = e.Graphics.MeasureString(txt_cust_name.Text, f);
                //SizeF fontsizecust_total_price = e.Graphics.MeasureString(lbl_total_price.Text, f);





                e.Graphics.DrawImage(Properties.Resources.icons8_supermarket_901, 5, 5, 200, 200);

                //e.Graphics.DrawString(strNO, f, Brushes.Black, (e.PageBounds.Width - fontSizeNO.Width) / 2, margin);

                //e.Graphics.DrawString(strDate, f, Brushes.Black, e.PageBounds.Width - fontSizeDate.Width - margin,margin+fontSizeNO.Height);
                //e.Graphics.DrawString(strName, f, Brushes.Navy, e.PageBounds.Width - fontSizeName.Width - margin, margin + fontSizeNO.Height + fontSizeDate.Height);

                e.Graphics.DrawString(strNO, f, Brushes.Black, (e.PageBounds.Width - fontSizeNO.Width) / 2, margin);
                e.Graphics.DrawString(strDate, f, Brushes.Black, (e.PageBounds.Width - 200), margin);
                e.Graphics.DrawString(strtTime, f, Brushes.Black, (e.PageBounds.Width - 200), margin + fontSizeNO.Height);
                e.Graphics.DrawString(strName, f, Brushes.Black, (e.PageBounds.Width - 200) - margin, 70 + fontsizetime.Height + fontSizeNO.Height + fontSizeDate.Height);



                float preHeights = margin + fontSizeNO.Height + fontSizeDate.Height + fontSizeName.Height + 70;

                e.Graphics.DrawRectangle(Pens.Black, margin, preHeights, e.PageBounds.Width - margin * 2, e.PageBounds.Height - margin - preHeights);

                float colheight = 40;

                float col1width = 250;
                float col2width = 125 + col1width;
                float col3width = 125 + col2width;
                float col4width = 125 + col3width;

                e.Graphics.DrawLine(Pens.Black, margin, preHeights + colheight, e.PageBounds.Width - margin, preHeights + colheight);

                e.Graphics.DrawString("اسم المنتج", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col1width, preHeights);
                e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col1width, preHeights, e.PageBounds.Width - margin * 2 - col1width, e.PageBounds.Height - margin);

                e.Graphics.DrawString("الكمية", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHeights);
                e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col2width, preHeights, e.PageBounds.Width - margin * 2 - col2width, e.PageBounds.Height - margin);

                e.Graphics.DrawString("السعر", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHeights);
                e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col3width, preHeights, e.PageBounds.Width - margin * 2 - col3width, e.PageBounds.Height - margin);

                e.Graphics.DrawString("حالة الدفع", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHeights);


                //preHeights += colheight;


                float col5width = e.PageBounds.Width - margin * 2 - col4width - col3width - col2width - col1width;

                DevExpress.XtraGrid.Views.Grid.GridView gridView3_sale = gridControl_sale2.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

                float rowHeight = 50;

                for (int x = 0; x < gridView3_sale.RowCount; x++)
                {

                    object cellValue1 = gridView3_sale.GetRowCellValue(x, gridView3_sale.Columns["pro_name"]);
                    object cellValue2 = gridView3_sale.GetRowCellValue(x, gridView3_sale.Columns["sal_quantity"]);
                    object cellValue3 = gridView3_sale.GetRowCellValue(x, gridView3_sale.Columns["sal_price"]);
                    object cellValue4 = gridView3_sale.GetRowCellValue(x, gridView3_sale.Columns["sal_push_stat"]);


                    if (cellValue1 != null && cellValue2 != null && cellValue3 != null && cellValue4 != null)
                    {
                        string text1 = cellValue1.ToString();
                        string text2 = cellValue2.ToString();
                        string text3 = cellValue3.ToString();
                        string text4 = cellValue4.ToString();




                        e.Graphics.DrawString(text1, f, Brushes.Black, e.PageBounds.Width - margin * 2 - col1width, preHeights + rowHeight);
                        e.Graphics.DrawString(text2, f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHeights + rowHeight);
                        e.Graphics.DrawString(text3, f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHeights + rowHeight);
                        e.Graphics.DrawString(text4, f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHeights + rowHeight);


                        e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowHeight + colheight, e.PageBounds.Width - margin, preHeights + rowHeight + colheight);


                        rowHeight += 50;
                    }

                }
                e.Graphics.DrawString("الاجمالي", f, Brushes.Red, e.PageBounds.Width - margin * 2 - col2width, preHeights + rowHeight);
                e.Graphics.DrawString(lbl_total_price.Text, f, Brushes.Blue, e.PageBounds.Width - margin * 2 - col3width, preHeights + rowHeight);
                e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowHeight + colheight, e.PageBounds.Width - margin, preHeights + rowHeight + colheight);
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void txt_search_sale1_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_sale1.DataSource = ncls_pro.datalist(txt_search_sale1.Text);
        }
        public static int pro_id1;
        public static decimal sal_num;
        public static decimal pro_quantity;
        public static decimal resultSum;
        public static int sales_id1;
        public void getproid()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = CLASSES.cls_sales.sal_data.GetData();

                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    sales_id1 = Convert.ToInt32(dt.Rows[i]["sal_id"]);

                    DataTable dt1 = new DataTable();
                    dt1 = CLASSES.cls_sales.sal_data.get_qu(sales_id1);

                    if (decimal.TryParse(dt1.Rows[0]["pro_quantity"].ToString(), out pro_quantity))
                    {

                    }

                    sal_num = Convert.ToDecimal(dt.Rows[i]["sal_quantity"].ToString());
                    pro_id1 = Convert.ToInt32(dt.Rows[i]["pro_id"]);
                    if (dt.Rows.Count > 0)
                    {
                        resultSum = sal_num + pro_quantity;
                        //MessageBox.Show(resultSum.ToString());
                        CLASSES.cls_pro.data.Update_by_quantity(resultSum, pro_id1, pro_id1);
                        MessageBox.Show("تم الفاء عملية البيع ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
           

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من الغاء عملية البيع؟", "تأكيد الغاء", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    getproid();
                    ncls_cust.cust_list();
                    CLASSES.cls_cust.cust_data.Delete_customer(CLASSES.cls_cust.cust_id);
                    CLASSES.cls_sales.sal_data.Delete_all_sal();


                    

                    MessageBox.Show("تم الغاء عنلية البيع.", "تم الغاء", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
                
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show("حدث خطأ : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clear_data();
            sum_data();
            btn_state();
            num_cust = 0;
            com_stat.Enabled = true;
            com_stat.Text = "";
            com_push_stat.Text = "";
            txt_cust_adress.Text = "";
            txt_cust_name.Text = "";
            txt_cust_phone.Text = "";
        }

        private void txt_num_sal_EditValueChanged(object sender, EventArgs e)
        {
           
        }
        public static bool is_click_cust = false;


        private void btn_fetch_cust_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.frm_fetch_cust frm = new Forms.frm_fetch_cust();
                frm.Show();

                //txt_cust_name.Text = CLASSES.cls_cust.cust_name;
                //txt_cust_phone.Text = CLASSES.cls_cust.cust_phon;
                //txt_cust_adress.Text = CLASSES.cls_cust.cust_address;


                com_push_stat.Enabled = false;
                com_stat.Enabled = false;
                txt_cust_name.Enabled = false;
                txt_cust_adress.Enabled = false;
                txt_cust_phone.Enabled = false;
                btn_add_sale.Enabled = true;
                btn_Del_sal.Enabled = true;
                is_click_cust = true;
                num_cust++;
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

    }
}