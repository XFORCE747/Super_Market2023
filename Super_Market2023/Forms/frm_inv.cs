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
using DevExpress.XtraPrinting;
using DevExpress.Export;
using System.IO;



namespace Super_Market2023.Forms
{
    public partial class frm_inv : DevExpress.XtraEditors.XtraForm
    {

        private DataTable dataTable;
        private DevExpress.XtraPrinting.IPrintable printableGrid;
        public frm_inv()
        {
            InitializeComponent();
            
            
        }

        private void frm_inv_Load(object sender, EventArgs e)
        {
            gridControl_inv.DataSource = CLASSES.cls_inv.inv_data.select_inv();

            printableGrid = gridControl_inv;
            

            gridView_inv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView_inv.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView_inv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView_inv.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


            gridView_inv.Columns.Remove(gridView_inv.Columns["inv_id"]);
            gridView_inv.Columns.Remove(gridView_inv.Columns["cust_id"]);



            gridView_inv.Columns["cust_name"].Caption = "اسم الزبون";
            gridView_inv.Columns["inv_pro_name"].Caption = "المنتج";
            gridView_inv.Columns["inv_stat"].Caption = "حالة الفاتورة";
            gridView_inv.Columns["inv_total"].Caption = "مجموع الفاتورة";
            gridView_inv.Columns["inv_date"].Caption = "تاريخ الفاتورة";
            gridView_inv.Columns["inv_time"].Caption = "وقت الفاتورة";
            ApplyDateFilter();

        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            ApplyDateFilter();
        }
        private void ApplyDateFilter()
        {
          
            DateTime fromDate = dateEditFrom.Value.Date;
            DateTime toDate = dateEditTo.Value.Date;

         
          (gridControl_inv.DataSource as DataTable).DefaultView.RowFilter = "[inv_date] >= #" + fromDate.ToString("yyyy-MM-dd") + "# AND [inv_date] <= #" + toDate.ToString("yyyy-MM-dd") + "#";
        }

        private void dateEditTo_ValueChanged(object sender, EventArgs e)
        {
            ApplyDateFilter();
        }
        private void ClearFilter()
        {
            try
            {
                dateEditFrom.Value = dateEditFrom.MinDate;
                dateEditTo.Value = dateEditTo.MaxDate;
                ApplyDateFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء محاولة إلغاء الفلترة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }
        private void ExportToPdf(DevExpress.XtraPrinting.IPrintable printableGrid, string filePath)
        {
            if (printableGrid != null)
            {
                // إعداد الطباعة
                PrintingSystem printingSystem = new PrintingSystem();
                PrintableComponentLink link = new PrintableComponentLink(printingSystem);
                link.Component = printableGrid;

                // تهيئة خيارات التصدير إلى PDF
                PdfExportOptions pdfOptions = new PdfExportOptions();
                pdfOptions.Compressed = false;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Medium;

                // تصدير البيانات إلى ملف PDF
                link.ExportToPdf(filePath, pdfOptions);

                // إغلاق الطباعة
                printingSystem.Dispose();
            }
            else
            {
                MessageBox.Show("قيمة printableGrid خالية (null).", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
        }

        
        

        private void btn_inv_clear_Click(object sender, EventArgs e)
        {
            try
            {
                PrintingSystem printingSystem = new PrintingSystem();
                PrintableComponentLink link = new PrintableComponentLink(printingSystem);
                link.Component = printableGrid;


                PdfExportOptions pdfOptions = new PdfExportOptions();
                pdfOptions.Compressed = false;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Medium;


                MemoryStream pdfStream = new MemoryStream();
                link.ExportToPdf(pdfStream, pdfOptions);


                TextBrick totalBrick = new TextBrick();
                totalBrick.Text = "المجموع: " + CalculateTotal();
                totalBrick.Rect = new RectangleF(10, 10, 200, 20);
                link.PrintingSystem.Graph.DrawBrick(totalBrick);


                PrintTool printTool = new PrintTool(printingSystem);
                printTool.ShowRibbonPreviewDialog();


                printingSystem.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء محاولة طباعة التقرير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           

        }
        private string CalculateTotal()
        {
            try
            {
                DataTable dataTable = gridControl_inv.DataSource as DataTable;
                if (dataTable != null)
                {
                    decimal total = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["inv_total"] != DBNull.Value)
                        {
                            total += Convert.ToDecimal(row["inv_total"]);
                        }
                    }
                    return total.ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            
        }
 




        
    }
}