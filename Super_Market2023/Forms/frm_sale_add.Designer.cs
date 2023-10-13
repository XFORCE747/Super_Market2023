namespace Super_Market2023.Forms
{
    partial class frm_sale_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sale_add));
            this.lbl_total_price = new DevExpress.XtraEditors.LabelControl();
            this.lbl_total_quantity = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txt_num_sal = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_sale2 = new DevExpress.XtraGrid.GridControl();
            this.gridView3_sale = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_add_sale = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del_sal = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_search_sale1 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl_sale1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2_sale = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_cancel_sale = new DevExpress.XtraEditors.SimpleButton();
            this.btn_fetch_cust = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print_sal = new DevExpress.XtraEditors.SimpleButton();
            this.txt_cust_adress = new DevExpress.XtraEditors.TextEdit();
            this.btn_invoice_sal = new DevExpress.XtraEditors.SimpleButton();
            this.com_push_stat = new System.Windows.Forms.ComboBox();
            this.com_stat = new System.Windows.Forms.ComboBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cust_phone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cust_name = new DevExpress.XtraEditors.TextEdit();
            this.btn_add_cust_sale = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_sal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_sale2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3_sale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search_sale1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_sale1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2_sale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cust_adress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cust_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cust_name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_total_price
            // 
            this.lbl_total_price.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_total_price.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_price.Appearance.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbl_total_price.Appearance.Options.UseFont = true;
            this.lbl_total_price.Appearance.Options.UseForeColor = true;
            this.lbl_total_price.Location = new System.Drawing.Point(146, 521);
            this.lbl_total_price.Name = "lbl_total_price";
            this.lbl_total_price.Size = new System.Drawing.Size(10, 19);
            this.lbl_total_price.TabIndex = 32;
            this.lbl_total_price.Text = "0";
            // 
            // lbl_total_quantity
            // 
            this.lbl_total_quantity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_total_quantity.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_quantity.Appearance.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbl_total_quantity.Appearance.Options.UseFont = true;
            this.lbl_total_quantity.Appearance.Options.UseForeColor = true;
            this.lbl_total_quantity.Location = new System.Drawing.Point(365, 521);
            this.lbl_total_quantity.Name = "lbl_total_quantity";
            this.lbl_total_quantity.Size = new System.Drawing.Size(10, 19);
            this.lbl_total_quantity.TabIndex = 31;
            this.lbl_total_quantity.Text = "0";
            // 
            // labelControl17
            // 
            this.labelControl17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Location = new System.Drawing.Point(216, 514);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(100, 29);
            this.labelControl17.TabIndex = 30;
            this.labelControl17.Text = "المجموع الكلي ";
            // 
            // labelControl18
            // 
            this.labelControl18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(427, 514);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(75, 29);
            this.labelControl18.TabIndex = 29;
            this.labelControl18.Text = "العدد الكلي";
            // 
            // txt_num_sal
            // 
            this.txt_num_sal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_num_sal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_num_sal.Location = new System.Drawing.Point(96, 272);
            this.txt_num_sal.Name = "txt_num_sal";
            this.txt_num_sal.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_num_sal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_sal.Properties.Appearance.Options.UseBackColor = true;
            this.txt_num_sal.Properties.Appearance.Options.UseFont = true;
            this.txt_num_sal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_num_sal.Size = new System.Drawing.Size(66, 24);
            this.txt_num_sal.TabIndex = 2;
            this.txt_num_sal.EditValueChanged += new System.EventHandler(this.txt_num_sal_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(172, 269);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 29);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "الكمية";
            // 
            // gridControl_sale2
            // 
            this.gridControl_sale2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_sale2.Location = new System.Drawing.Point(2, 304);
            this.gridControl_sale2.MainView = this.gridView3_sale;
            this.gridControl_sale2.Name = "gridControl_sale2";
            this.gridControl_sale2.Size = new System.Drawing.Size(630, 204);
            this.gridControl_sale2.TabIndex = 0;
            this.gridControl_sale2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3_sale});
            // 
            // gridView3_sale
            // 
            this.gridView3_sale.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView3_sale.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView3_sale.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView3_sale.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView3_sale.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView3_sale.Appearance.Empty.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3_sale.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView3_sale.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.gridView3_sale.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView3_sale.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView3_sale.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView3_sale.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView3_sale.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3_sale.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3_sale.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView3_sale.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3_sale.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView3_sale.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView3_sale.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView3_sale.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView3_sale.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView3_sale.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView3_sale.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3_sale.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView3_sale.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3_sale.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3_sale.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView3_sale.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView3_sale.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView3_sale.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3_sale.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView3_sale.Appearance.Preview.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3_sale.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3_sale.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView3_sale.Appearance.Preview.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.Preview.Options.UseFont = true;
            this.gridView3_sale.Appearance.Preview.Options.UseForeColor = true;
            this.gridView3_sale.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView3_sale.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView3_sale.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView3_sale.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView3_sale.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView3_sale.Appearance.Row.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.Row.Options.UseBorderColor = true;
            this.gridView3_sale.Appearance.Row.Options.UseFont = true;
            this.gridView3_sale.Appearance.Row.Options.UseForeColor = true;
            this.gridView3_sale.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3_sale.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView3_sale.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3_sale.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView3_sale.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView3_sale.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView3_sale.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3_sale.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3_sale.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView3_sale.GridControl = this.gridControl_sale2;
            this.gridView3_sale.Name = "gridView3_sale";
            this.gridView3_sale.OptionsView.ShowGroupPanel = false;
            this.gridView3_sale.PaintStyleName = "UltraFlat";
            this.gridView3_sale.DoubleClick += new System.EventHandler(this.gridView3_sale_DoubleClick);
            // 
            // btn_add_sale
            // 
            this.btn_add_sale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add_sale.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_add_sale.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_add_sale.Appearance.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btn_add_sale.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_add_sale.Appearance.Options.UseBackColor = true;
            this.btn_add_sale.Appearance.Options.UseBorderColor = true;
            this.btn_add_sale.Appearance.Options.UseFont = true;
            this.btn_add_sale.Appearance.Options.UseForeColor = true;
            this.btn_add_sale.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_add_sale.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_add_sale.AppearanceHovered.Options.UseBackColor = true;
            this.btn_add_sale.AppearanceHovered.Options.UseForeColor = true;
            this.btn_add_sale.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_add_sale.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_add_16;
            this.btn_add_sale.Location = new System.Drawing.Point(285, 269);
            this.btn_add_sale.Name = "btn_add_sale";
            this.btn_add_sale.Size = new System.Drawing.Size(61, 26);
            this.btn_add_sale.TabIndex = 1;
            this.btn_add_sale.Text = "اضافة";
            this.btn_add_sale.Click += new System.EventHandler(this.btn_add_sale_Click);
            // 
            // btn_Del_sal
            // 
            this.btn_Del_sal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Del_sal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_Del_sal.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_Del_sal.Appearance.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btn_Del_sal.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Del_sal.Appearance.Options.UseBackColor = true;
            this.btn_Del_sal.Appearance.Options.UseBorderColor = true;
            this.btn_Del_sal.Appearance.Options.UseFont = true;
            this.btn_Del_sal.Appearance.Options.UseForeColor = true;
            this.btn_Del_sal.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_Del_sal.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_Del_sal.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Del_sal.AppearanceHovered.Options.UseForeColor = true;
            this.btn_Del_sal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_Del_sal.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_delete_trash_16;
            this.btn_Del_sal.Location = new System.Drawing.Point(389, 269);
            this.btn_Del_sal.Name = "btn_Del_sal";
            this.btn_Del_sal.Size = new System.Drawing.Size(61, 26);
            this.btn_Del_sal.TabIndex = 0;
            this.btn_Del_sal.Text = "حذف";
            this.btn_Del_sal.Click += new System.EventHandler(this.btn_Del_sal_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(336, 17);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(22, 23);
            this.labelControl9.TabIndex = 6;
            this.labelControl9.Text = "بحث";
            // 
            // txt_search_sale1
            // 
            this.txt_search_sale1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search_sale1.Location = new System.Drawing.Point(216, 19);
            this.txt_search_sale1.Name = "txt_search_sale1";
            this.txt_search_sale1.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_search_sale1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_sale1.Properties.Appearance.Options.UseBackColor = true;
            this.txt_search_sale1.Properties.Appearance.Options.UseFont = true;
            this.txt_search_sale1.Size = new System.Drawing.Size(100, 20);
            this.txt_search_sale1.TabIndex = 0;
            this.txt_search_sale1.EditValueChanged += new System.EventHandler(this.txt_search_sale1_EditValueChanged);
            // 
            // gridControl_sale1
            // 
            this.gridControl_sale1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_sale1.Location = new System.Drawing.Point(2, 47);
            this.gridControl_sale1.MainView = this.gridView2_sale;
            this.gridControl_sale1.Name = "gridControl_sale1";
            this.gridControl_sale1.Size = new System.Drawing.Size(630, 216);
            this.gridControl_sale1.TabIndex = 0;
            this.gridControl_sale1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2_sale});
            // 
            // gridView2_sale
            // 
            this.gridView2_sale.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView2_sale.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView2_sale.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2_sale.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2_sale.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView2_sale.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2_sale.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView2_sale.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.gridView2_sale.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2_sale.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView2_sale.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView2_sale.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2_sale.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2_sale.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2_sale.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView2_sale.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2_sale.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2_sale.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2_sale.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView2_sale.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView2_sale.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView2_sale.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView2_sale.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2_sale.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2_sale.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2_sale.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2_sale.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView2_sale.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2_sale.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2_sale.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2_sale.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView2_sale.Appearance.Preview.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2_sale.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView2_sale.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView2_sale.Appearance.Preview.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.Preview.Options.UseFont = true;
            this.gridView2_sale.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2_sale.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView2_sale.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView2_sale.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView2_sale.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView2_sale.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView2_sale.Appearance.Row.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.Row.Options.UseBorderColor = true;
            this.gridView2_sale.Appearance.Row.Options.UseFont = true;
            this.gridView2_sale.Appearance.Row.Options.UseForeColor = true;
            this.gridView2_sale.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2_sale.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView2_sale.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2_sale.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2_sale.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2_sale.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2_sale.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2_sale.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2_sale.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView2_sale.GridControl = this.gridControl_sale1;
            this.gridView2_sale.Name = "gridView2_sale";
            this.gridView2_sale.OptionsView.ShowGroupPanel = false;
            this.gridView2_sale.PaintStyleName = "UltraFlat";
            this.gridView2_sale.DoubleClick += new System.EventHandler(this.gridView2_sale_DoubleClick);
            // 
            // btn_cancel_sale
            // 
            this.btn_cancel_sale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_sale.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_cancel_sale.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_cancel_sale.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.btn_cancel_sale.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_cancel_sale.Appearance.Options.UseBackColor = true;
            this.btn_cancel_sale.Appearance.Options.UseBorderColor = true;
            this.btn_cancel_sale.Appearance.Options.UseFont = true;
            this.btn_cancel_sale.Appearance.Options.UseForeColor = true;
            this.btn_cancel_sale.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_cancel_sale.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel_sale.AppearanceHovered.Options.UseBackColor = true;
            this.btn_cancel_sale.AppearanceHovered.Options.UseForeColor = true;
            this.btn_cancel_sale.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_cancel_sale.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_remove_from_cart_32;
            this.btn_cancel_sale.Location = new System.Drawing.Point(648, 472);
            this.btn_cancel_sale.Name = "btn_cancel_sale";
            this.btn_cancel_sale.Size = new System.Drawing.Size(201, 43);
            this.btn_cancel_sale.TabIndex = 0;
            this.btn_cancel_sale.Text = "الغاء عملية البيع";
            this.btn_cancel_sale.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_fetch_cust
            // 
            this.btn_fetch_cust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fetch_cust.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_fetch_cust.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_fetch_cust.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.btn_fetch_cust.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_fetch_cust.Appearance.Options.UseBackColor = true;
            this.btn_fetch_cust.Appearance.Options.UseBorderColor = true;
            this.btn_fetch_cust.Appearance.Options.UseFont = true;
            this.btn_fetch_cust.Appearance.Options.UseForeColor = true;
            this.btn_fetch_cust.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_fetch_cust.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_fetch_cust.AppearanceHovered.Options.UseBackColor = true;
            this.btn_fetch_cust.AppearanceHovered.Options.UseForeColor = true;
            this.btn_fetch_cust.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_fetch_cust.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_data_migration_32;
            this.btn_fetch_cust.Location = new System.Drawing.Point(648, 124);
            this.btn_fetch_cust.Name = "btn_fetch_cust";
            this.btn_fetch_cust.Size = new System.Drawing.Size(150, 32);
            this.btn_fetch_cust.TabIndex = 3;
            this.btn_fetch_cust.Text = "ادراج زبون سابق";
            this.btn_fetch_cust.Click += new System.EventHandler(this.btn_fetch_cust_Click);
            // 
            // btn_print_sal
            // 
            this.btn_print_sal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print_sal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_print_sal.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_print_sal.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.btn_print_sal.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_print_sal.Appearance.Options.UseBackColor = true;
            this.btn_print_sal.Appearance.Options.UseBorderColor = true;
            this.btn_print_sal.Appearance.Options.UseFont = true;
            this.btn_print_sal.Appearance.Options.UseForeColor = true;
            this.btn_print_sal.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_print_sal.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_print_sal.AppearanceHovered.Options.UseBackColor = true;
            this.btn_print_sal.AppearanceHovered.Options.UseForeColor = true;
            this.btn_print_sal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_print_sal.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_print_32_12;
            this.btn_print_sal.Location = new System.Drawing.Point(648, 416);
            this.btn_print_sal.Name = "btn_print_sal";
            this.btn_print_sal.Size = new System.Drawing.Size(201, 43);
            this.btn_print_sal.TabIndex = 9;
            this.btn_print_sal.Text = "طباعة الفاتورة";
            this.btn_print_sal.Click += new System.EventHandler(this.btn_print_sal_Click);
            // 
            // txt_cust_adress
            // 
            this.txt_cust_adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cust_adress.Location = new System.Drawing.Point(648, 242);
            this.txt_cust_adress.Name = "txt_cust_adress";
            this.txt_cust_adress.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_cust_adress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_adress.Properties.Appearance.Options.UseBackColor = true;
            this.txt_cust_adress.Properties.Appearance.Options.UseFont = true;
            this.txt_cust_adress.Size = new System.Drawing.Size(100, 22);
            this.txt_cust_adress.TabIndex = 6;
            // 
            // btn_invoice_sal
            // 
            this.btn_invoice_sal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_invoice_sal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_invoice_sal.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_invoice_sal.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.btn_invoice_sal.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_invoice_sal.Appearance.Options.UseBackColor = true;
            this.btn_invoice_sal.Appearance.Options.UseBorderColor = true;
            this.btn_invoice_sal.Appearance.Options.UseFont = true;
            this.btn_invoice_sal.Appearance.Options.UseForeColor = true;
            this.btn_invoice_sal.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_invoice_sal.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_invoice_sal.AppearanceHovered.Options.UseBackColor = true;
            this.btn_invoice_sal.AppearanceHovered.Options.UseForeColor = true;
            this.btn_invoice_sal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_invoice_sal.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_file_invoice_dollar_32;
            this.btn_invoice_sal.Location = new System.Drawing.Point(648, 360);
            this.btn_invoice_sal.Name = "btn_invoice_sal";
            this.btn_invoice_sal.Size = new System.Drawing.Size(201, 43);
            this.btn_invoice_sal.TabIndex = 8;
            this.btn_invoice_sal.Text = "انشاء فاتورة";
            this.btn_invoice_sal.Click += new System.EventHandler(this.btn_invoice_sal_Click);
            // 
            // com_push_stat
            // 
            this.com_push_stat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_push_stat.BackColor = System.Drawing.Color.LightCyan;
            this.com_push_stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.com_push_stat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_push_stat.FormattingEnabled = true;
            this.com_push_stat.Items.AddRange(new object[] {
            "نقدي",
            "دين"});
            this.com_push_stat.Location = new System.Drawing.Point(648, 82);
            this.com_push_stat.Name = "com_push_stat";
            this.com_push_stat.Size = new System.Drawing.Size(100, 24);
            this.com_push_stat.TabIndex = 2;
            this.com_push_stat.SelectedIndexChanged += new System.EventHandler(this.com_push_stat_SelectedIndexChanged);
            // 
            // com_stat
            // 
            this.com_stat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_stat.BackColor = System.Drawing.Color.LightCyan;
            this.com_stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.com_stat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_stat.FormattingEnabled = true;
            this.com_stat.Items.AddRange(new object[] {
            "طلبية",
            "بيع"});
            this.com_stat.Location = new System.Drawing.Point(648, 47);
            this.com_stat.Name = "com_stat";
            this.com_stat.Size = new System.Drawing.Size(100, 24);
            this.com_stat.TabIndex = 1;
            this.com_stat.SelectedIndexChanged += new System.EventHandler(this.com_stat_SelectedIndexChanged);
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(753, 205);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(74, 29);
            this.labelControl15.TabIndex = 23;
            this.labelControl15.Text = "رقم الهاتف";
            // 
            // txt_cust_phone
            // 
            this.txt_cust_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cust_phone.Location = new System.Drawing.Point(648, 209);
            this.txt_cust_phone.Name = "txt_cust_phone";
            this.txt_cust_phone.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_cust_phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_phone.Properties.Appearance.Options.UseBackColor = true;
            this.txt_cust_phone.Properties.Appearance.Options.UseFont = true;
            this.txt_cust_phone.Size = new System.Drawing.Size(100, 22);
            this.txt_cust_phone.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(759, 237);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 29);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "العنوان";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(754, 171);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(72, 29);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "اسم الزبون";
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cust_name.Location = new System.Drawing.Point(648, 176);
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_cust_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_name.Properties.Appearance.Options.UseBackColor = true;
            this.txt_cust_name.Properties.Appearance.Options.UseFont = true;
            this.txt_cust_name.Size = new System.Drawing.Size(100, 22);
            this.txt_cust_name.TabIndex = 4;
            // 
            // btn_add_cust_sale
            // 
            this.btn_add_cust_sale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_cust_sale.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_add_cust_sale.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_add_cust_sale.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.btn_add_cust_sale.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_add_cust_sale.Appearance.Options.UseBackColor = true;
            this.btn_add_cust_sale.Appearance.Options.UseBorderColor = true;
            this.btn_add_cust_sale.Appearance.Options.UseFont = true;
            this.btn_add_cust_sale.Appearance.Options.UseForeColor = true;
            this.btn_add_cust_sale.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_add_cust_sale.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_add_cust_sale.AppearanceHovered.Options.UseBackColor = true;
            this.btn_add_cust_sale.AppearanceHovered.Options.UseForeColor = true;
            this.btn_add_cust_sale.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_add_cust_sale.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_add_administrator_32;
            this.btn_add_cust_sale.Location = new System.Drawing.Point(648, 304);
            this.btn_add_cust_sale.Name = "btn_add_cust_sale";
            this.btn_add_cust_sale.Size = new System.Drawing.Size(201, 43);
            this.btn_add_cust_sale.TabIndex = 7;
            this.btn_add_cust_sale.Text = "اضافة زبون جديد";
            this.btn_add_cust_sale.Click += new System.EventHandler(this.btn_add_cust_sale_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(753, 80);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(79, 29);
            this.labelControl13.TabIndex = 10;
            this.labelControl13.Text = "عملية الدفع";
            // 
            // labelControl14
            // 
            this.labelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(759, 44);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(61, 30);
            this.labelControl14.TabIndex = 8;
            this.labelControl14.Text = "نوع البيع";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frm_sale_add
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 550);
            this.Controls.Add(this.btn_cancel_sale);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.gridControl_sale1);
            this.Controls.Add(this.btn_fetch_cust);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txt_search_sale1);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.btn_print_sal);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.txt_cust_adress);
            this.Controls.Add(this.btn_add_cust_sale);
            this.Controls.Add(this.lbl_total_price);
            this.Controls.Add(this.gridControl_sale2);
            this.Controls.Add(this.btn_invoice_sal);
            this.Controls.Add(this.txt_cust_name);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.com_push_stat);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txt_num_sal);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.com_stat);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.btn_Del_sal);
            this.Controls.Add(this.lbl_total_quantity);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.txt_cust_phone);
            this.Controls.Add(this.btn_add_sale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_sale_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عمليات البيع";
            this.Load += new System.EventHandler(this.frm_sale_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_sal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_sale2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3_sale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search_sale1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_sale1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2_sale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cust_adress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cust_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cust_name.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_search_sale1;
        private DevExpress.XtraGrid.GridControl gridControl_sale1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2_sale;
        private DevExpress.XtraEditors.SimpleButton btn_add_cust_sale;
        private DevExpress.XtraEditors.SimpleButton btn_Del_sal;
        private DevExpress.XtraEditors.SimpleButton btn_add_sale;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        public DevExpress.XtraEditors.TextEdit txt_cust_name;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.ComboBox com_push_stat;
        private System.Windows.Forms.ComboBox com_stat;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        public DevExpress.XtraEditors.TextEdit txt_cust_phone;
        private DevExpress.XtraGrid.GridControl gridControl_sale2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3_sale;
        public DevExpress.XtraEditors.TextEdit txt_cust_adress;
        private DevExpress.XtraEditors.SimpleButton btn_invoice_sal;
        private DevExpress.XtraEditors.SimpleButton btn_print_sal;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl lbl_total_price;
        private DevExpress.XtraEditors.LabelControl lbl_total_quantity;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private DevExpress.XtraEditors.SimpleButton btn_fetch_cust;
        private DevExpress.XtraEditors.SimpleButton btn_cancel_sale;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit txt_num_sal;
    }
}