namespace Super_Market2023.Forms
{
    partial class frm_pro_add
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
            this.txt_name_pro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cat_price = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_num = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_company = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.com_cat_name = new System.Windows.Forms.ComboBox();
            this.btn_pro_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pro_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pro_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pro_clear = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_pro = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_search_pro = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name_pro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cat_price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_company.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_pro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search_pro.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name_pro
            // 
            this.txt_name_pro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name_pro.Location = new System.Drawing.Point(686, 59);
            this.txt_name_pro.Name = "txt_name_pro";
            this.txt_name_pro.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_name_pro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_pro.Properties.Appearance.Options.UseBackColor = true;
            this.txt_name_pro.Properties.Appearance.Options.UseFont = true;
            this.txt_name_pro.Size = new System.Drawing.Size(100, 20);
            this.txt_name_pro.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(796, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 30);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "اسم المنتج";
            // 
            // txt_cat_price
            // 
            this.txt_cat_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cat_price.Location = new System.Drawing.Point(686, 110);
            this.txt_cat_price.Name = "txt_cat_price";
            this.txt_cat_price.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_cat_price.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cat_price.Properties.Appearance.Options.UseBackColor = true;
            this.txt_cat_price.Properties.Appearance.Options.UseFont = true;
            this.txt_cat_price.Size = new System.Drawing.Size(100, 20);
            this.txt_cat_price.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(796, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 30);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "سعر المنتج";
            // 
            // txt_num
            // 
            this.txt_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_num.Location = new System.Drawing.Point(686, 161);
            this.txt_num.Name = "txt_num";
            this.txt_num.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_num.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Properties.Appearance.Options.UseBackColor = true;
            this.txt_num.Properties.Appearance.Options.UseFont = true;
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(796, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(120, 30);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "الكمية الموجودة";
            // 
            // txt_company
            // 
            this.txt_company.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_company.Location = new System.Drawing.Point(686, 212);
            this.txt_company.Name = "txt_company";
            this.txt_company.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_company.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_company.Properties.Appearance.Options.UseBackColor = true;
            this.txt_company.Properties.Appearance.Options.UseFont = true;
            this.txt_company.Size = new System.Drawing.Size(100, 20);
            this.txt_company.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(796, 209);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 30);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "الشركة المصنعة";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(796, 262);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 30);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "الصنف";
            // 
            // com_cat_name
            // 
            this.com_cat_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_cat_name.BackColor = System.Drawing.Color.LightCyan;
            this.com_cat_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.com_cat_name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_cat_name.FormattingEnabled = true;
            this.com_cat_name.Location = new System.Drawing.Point(686, 263);
            this.com_cat_name.Name = "com_cat_name";
            this.com_cat_name.Size = new System.Drawing.Size(100, 22);
            this.com_cat_name.TabIndex = 5;
            this.com_cat_name.SelectedIndexChanged += new System.EventHandler(this.com_cat_name_SelectedIndexChanged);
            // 
            // btn_pro_add
            // 
            this.btn_pro_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pro_add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_pro_add.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_pro_add.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pro_add.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_pro_add.Appearance.Options.UseBackColor = true;
            this.btn_pro_add.Appearance.Options.UseBorderColor = true;
            this.btn_pro_add.Appearance.Options.UseFont = true;
            this.btn_pro_add.Appearance.Options.UseForeColor = true;
            this.btn_pro_add.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_pro_add.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.btn_pro_add.AppearanceHovered.Options.UseBackColor = true;
            this.btn_pro_add.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_pro_add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_pro_add.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_add_16;
            this.btn_pro_add.Location = new System.Drawing.Point(702, 364);
            this.btn_pro_add.Name = "btn_pro_add";
            this.btn_pro_add.Size = new System.Drawing.Size(199, 36);
            this.btn_pro_add.TabIndex = 6;
            this.btn_pro_add.Text = "اضافة";
            this.btn_pro_add.Click += new System.EventHandler(this.btn_pro_add_Click);
            // 
            // btn_pro_edit
            // 
            this.btn_pro_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pro_edit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_pro_edit.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_pro_edit.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btn_pro_edit.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_pro_edit.Appearance.Options.UseBackColor = true;
            this.btn_pro_edit.Appearance.Options.UseBorderColor = true;
            this.btn_pro_edit.Appearance.Options.UseFont = true;
            this.btn_pro_edit.Appearance.Options.UseForeColor = true;
            this.btn_pro_edit.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_pro_edit.AppearanceHovered.Options.UseBackColor = true;
            this.btn_pro_edit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_pro_edit.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_edit_16;
            this.btn_pro_edit.Location = new System.Drawing.Point(702, 462);
            this.btn_pro_edit.Name = "btn_pro_edit";
            this.btn_pro_edit.Size = new System.Drawing.Size(199, 36);
            this.btn_pro_edit.TabIndex = 8;
            this.btn_pro_edit.Text = "تعديل";
            this.btn_pro_edit.Click += new System.EventHandler(this.btn_pro_edit_Click);
            // 
            // btn_pro_del
            // 
            this.btn_pro_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pro_del.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_pro_del.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_pro_del.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btn_pro_del.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_pro_del.Appearance.Options.UseBackColor = true;
            this.btn_pro_del.Appearance.Options.UseBorderColor = true;
            this.btn_pro_del.Appearance.Options.UseFont = true;
            this.btn_pro_del.Appearance.Options.UseForeColor = true;
            this.btn_pro_del.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_pro_del.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.btn_pro_del.AppearanceHovered.Options.UseBackColor = true;
            this.btn_pro_del.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_pro_del.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_pro_del.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_delete_trash_16;
            this.btn_pro_del.Location = new System.Drawing.Point(702, 413);
            this.btn_pro_del.Name = "btn_pro_del";
            this.btn_pro_del.Size = new System.Drawing.Size(199, 36);
            this.btn_pro_del.TabIndex = 7;
            this.btn_pro_del.Text = "حذف";
            this.btn_pro_del.Click += new System.EventHandler(this.btn_pro_del_Click);
            // 
            // btn_pro_clear
            // 
            this.btn_pro_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pro_clear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_pro_clear.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_pro_clear.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btn_pro_clear.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_pro_clear.Appearance.Options.UseBackColor = true;
            this.btn_pro_clear.Appearance.Options.UseBorderColor = true;
            this.btn_pro_clear.Appearance.Options.UseFont = true;
            this.btn_pro_clear.Appearance.Options.UseForeColor = true;
            this.btn_pro_clear.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_pro_clear.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_pro_clear.AppearanceHovered.Options.UseBackColor = true;
            this.btn_pro_clear.AppearanceHovered.Options.UseForeColor = true;
            this.btn_pro_clear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_pro_clear.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_clear_symbol_16;
            this.btn_pro_clear.Location = new System.Drawing.Point(702, 511);
            this.btn_pro_clear.Name = "btn_pro_clear";
            this.btn_pro_clear.Size = new System.Drawing.Size(199, 36);
            this.btn_pro_clear.TabIndex = 9;
            this.btn_pro_clear.Text = "مسح الحقول";
            this.btn_pro_clear.Click += new System.EventHandler(this.btn_pro_clear_Click);
            // 
            // gridControl_pro
            // 
            this.gridControl_pro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_pro.Location = new System.Drawing.Point(0, 57);
            this.gridControl_pro.MainView = this.gridView1;
            this.gridControl_pro.Name = "gridControl_pro";
            this.gridControl_pro.Size = new System.Drawing.Size(680, 494);
            this.gridControl_pro.TabIndex = 11;
            this.gridControl_pro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl_pro.Click += new System.EventHandler(this.gridControl_pro_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView1.Appearance.Preview.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl_pro;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "UltraFlat";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(406, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 30);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "بحث";
            // 
            // txt_search_pro
            // 
            this.txt_search_pro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search_pro.Location = new System.Drawing.Point(226, 17);
            this.txt_search_pro.Name = "txt_search_pro";
            this.txt_search_pro.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_search_pro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_pro.Properties.Appearance.Options.UseBackColor = true;
            this.txt_search_pro.Properties.Appearance.Options.UseFont = true;
            this.txt_search_pro.Size = new System.Drawing.Size(151, 24);
            this.txt_search_pro.TabIndex = 10;
            this.txt_search_pro.EditValueChanged += new System.EventHandler(this.txt_search_pro_EditValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txt_search_pro);
            this.panel1.Controls.Add(this.gridControl_pro);
            this.panel1.Controls.Add(this.btn_pro_clear);
            this.panel1.Controls.Add(this.btn_pro_del);
            this.panel1.Controls.Add(this.txt_name_pro);
            this.panel1.Controls.Add(this.btn_pro_edit);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.btn_pro_add);
            this.panel1.Controls.Add(this.txt_cat_price);
            this.panel1.Controls.Add(this.com_cat_name);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.txt_num);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txt_company);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 551);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frm_pro_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 551);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_pro_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المنتجات";
            this.Load += new System.EventHandler(this.frm_pro_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_name_pro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cat_price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_company.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_pro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search_pro.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_name_pro;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_cat_price;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_num;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_company;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox com_cat_name;
        private DevExpress.XtraEditors.SimpleButton btn_pro_add;
        private DevExpress.XtraEditors.SimpleButton btn_pro_edit;
        private DevExpress.XtraEditors.SimpleButton btn_pro_del;
        private DevExpress.XtraEditors.SimpleButton btn_pro_clear;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_search_pro;
        private DevExpress.XtraGrid.GridControl gridControl_pro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;

    }
}