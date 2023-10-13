namespace Super_Market2023.Forms
{
    partial class frm_cat_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cat_add));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_search_cat = new DevExpress.XtraEditors.TextEdit();
            this.gridControl_cat = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_cat_clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cat_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cat_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cat_add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cat_note = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_name_cat = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search_cat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cat_note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name_cat.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(407, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 30);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "بحث";
            // 
            // txt_search_cat
            // 
            this.txt_search_cat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search_cat.Location = new System.Drawing.Point(242, 24);
            this.txt_search_cat.Name = "txt_search_cat";
            this.txt_search_cat.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_search_cat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_cat.Properties.Appearance.Options.UseBackColor = true;
            this.txt_search_cat.Properties.Appearance.Options.UseFont = true;
            this.txt_search_cat.Size = new System.Drawing.Size(151, 26);
            this.txt_search_cat.TabIndex = 0;
            this.txt_search_cat.EditValueChanged += new System.EventHandler(this.txt_search_cat_EditValueChanged);
            // 
            // gridControl_cat
            // 
            this.gridControl_cat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_cat.Location = new System.Drawing.Point(1, 61);
            this.gridControl_cat.MainView = this.gridView1;
            this.gridControl_cat.Name = "gridControl_cat";
            this.gridControl_cat.Size = new System.Drawing.Size(625, 487);
            this.gridControl_cat.TabIndex = 0;
            this.gridControl_cat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.GridControl = this.gridControl_cat;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "UltraFlat";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(694, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 67);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btn_cat_clear
            // 
            this.btn_cat_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cat_clear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_cat_clear.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_cat_clear.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cat_clear.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_cat_clear.Appearance.Options.UseBackColor = true;
            this.btn_cat_clear.Appearance.Options.UseBorderColor = true;
            this.btn_cat_clear.Appearance.Options.UseFont = true;
            this.btn_cat_clear.Appearance.Options.UseForeColor = true;
            this.btn_cat_clear.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_cat_clear.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_cat_clear.AppearanceHovered.Options.UseBackColor = true;
            this.btn_cat_clear.AppearanceHovered.Options.UseForeColor = true;
            this.btn_cat_clear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_cat_clear.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_clear_symbol_16;
            this.btn_cat_clear.Location = new System.Drawing.Point(637, 514);
            this.btn_cat_clear.Name = "btn_cat_clear";
            this.btn_cat_clear.Size = new System.Drawing.Size(200, 34);
            this.btn_cat_clear.TabIndex = 6;
            this.btn_cat_clear.Text = "مسح الحقول";
            this.btn_cat_clear.Click += new System.EventHandler(this.btn_cat_clear_Click);
            // 
            // btn_cat_del
            // 
            this.btn_cat_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cat_del.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_cat_del.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_cat_del.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cat_del.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_cat_del.Appearance.Options.UseBackColor = true;
            this.btn_cat_del.Appearance.Options.UseBorderColor = true;
            this.btn_cat_del.Appearance.Options.UseFont = true;
            this.btn_cat_del.Appearance.Options.UseForeColor = true;
            this.btn_cat_del.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_cat_del.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_cat_del.AppearanceHovered.Options.UseBackColor = true;
            this.btn_cat_del.AppearanceHovered.Options.UseForeColor = true;
            this.btn_cat_del.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_cat_del.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_delete_trash_16;
            this.btn_cat_del.Location = new System.Drawing.Point(638, 412);
            this.btn_cat_del.Name = "btn_cat_del";
            this.btn_cat_del.Size = new System.Drawing.Size(199, 36);
            this.btn_cat_del.TabIndex = 4;
            this.btn_cat_del.Text = "حذف";
            this.btn_cat_del.Click += new System.EventHandler(this.btn_cat_del_Click);
            // 
            // btn_cat_edit
            // 
            this.btn_cat_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cat_edit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_cat_edit.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_cat_edit.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cat_edit.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_cat_edit.Appearance.Options.UseBackColor = true;
            this.btn_cat_edit.Appearance.Options.UseBorderColor = true;
            this.btn_cat_edit.Appearance.Options.UseFont = true;
            this.btn_cat_edit.Appearance.Options.UseForeColor = true;
            this.btn_cat_edit.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_cat_edit.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_cat_edit.AppearanceHovered.Options.UseBackColor = true;
            this.btn_cat_edit.AppearanceHovered.Options.UseForeColor = true;
            this.btn_cat_edit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_cat_edit.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_edit_16;
            this.btn_cat_edit.Location = new System.Drawing.Point(637, 465);
            this.btn_cat_edit.Name = "btn_cat_edit";
            this.btn_cat_edit.Size = new System.Drawing.Size(200, 36);
            this.btn_cat_edit.TabIndex = 5;
            this.btn_cat_edit.Text = "تعديل";
            this.btn_cat_edit.Click += new System.EventHandler(this.btn_cat_edit_Click);
            // 
            // btn_cat_add
            // 
            this.btn_cat_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cat_add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_cat_add.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_cat_add.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cat_add.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_cat_add.Appearance.Options.UseBackColor = true;
            this.btn_cat_add.Appearance.Options.UseBorderColor = true;
            this.btn_cat_add.Appearance.Options.UseFont = true;
            this.btn_cat_add.Appearance.Options.UseForeColor = true;
            this.btn_cat_add.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_cat_add.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_cat_add.AppearanceHovered.Options.UseBackColor = true;
            this.btn_cat_add.AppearanceHovered.Options.UseForeColor = true;
            this.btn_cat_add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_cat_add.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_add_16;
            this.btn_cat_add.Location = new System.Drawing.Point(638, 359);
            this.btn_cat_add.Name = "btn_cat_add";
            this.btn_cat_add.Size = new System.Drawing.Size(199, 36);
            this.btn_cat_add.TabIndex = 3;
            this.btn_cat_add.Text = "اضافة";
            this.btn_cat_add.Click += new System.EventHandler(this.btn_cat_add_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(741, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 30);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "ملاحظات";
            // 
            // txt_cat_note
            // 
            this.txt_cat_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cat_note.Location = new System.Drawing.Point(633, 161);
            this.txt_cat_note.Name = "txt_cat_note";
            this.txt_cat_note.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_cat_note.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cat_note.Properties.Appearance.Options.UseBackColor = true;
            this.txt_cat_note.Properties.Appearance.Options.UseFont = true;
            this.txt_cat_note.Size = new System.Drawing.Size(100, 24);
            this.txt_cat_note.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(741, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 30);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "اسم الصنف";
            // 
            // txt_name_cat
            // 
            this.txt_name_cat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name_cat.Location = new System.Drawing.Point(633, 62);
            this.txt_name_cat.Name = "txt_name_cat";
            this.txt_name_cat.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txt_name_cat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_cat.Properties.Appearance.Options.UseBackColor = true;
            this.txt_name_cat.Properties.Appearance.Options.UseFont = true;
            this.txt_name_cat.Size = new System.Drawing.Size(100, 24);
            this.txt_name_cat.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.btn_cat_clear);
            this.panel1.Controls.Add(this.txt_search_cat);
            this.panel1.Controls.Add(this.btn_cat_del);
            this.panel1.Controls.Add(this.gridControl_cat);
            this.panel1.Controls.Add(this.btn_cat_edit);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.btn_cat_add);
            this.panel1.Controls.Add(this.txt_name_cat);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txt_cat_note);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 551);
            this.panel1.TabIndex = 4;
            // 
            // frm_cat_add
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 551);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cat_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاصناف";
            this.Load += new System.EventHandler(this.frm_cat_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_search_cat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cat_note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name_cat.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_search_cat;
        private DevExpress.XtraGrid.GridControl gridControl_cat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_name_cat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_cat_note;
        private DevExpress.XtraEditors.SimpleButton btn_cat_clear;
        private DevExpress.XtraEditors.SimpleButton btn_cat_del;
        private DevExpress.XtraEditors.SimpleButton btn_cat_edit;
        private DevExpress.XtraEditors.SimpleButton btn_cat_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;


    }
}