namespace Super_Market2023.Forms
{
    partial class frm_setting
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
            this.txt_servername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SAVE_SETING = new DevExpress.XtraEditors.SimpleButton();
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.radioButtonNetWork = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswordDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PortNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DBname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.gridControl_USERS = new DevExpress.XtraGrid.GridControl();
            this.gridView_users = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_paswword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_USERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_users)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_servername
            // 
            this.txt_servername.BackColor = System.Drawing.Color.LightCyan;
            this.txt_servername.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.txt_servername.Location = new System.Drawing.Point(54, 126);
            this.txt_servername.Name = "txt_servername";
            this.txt_servername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_servername.Size = new System.Drawing.Size(130, 32);
            this.txt_servername.TabIndex = 0;
            this.txt_servername.Text = ".\\SQLEXPRESS";
            this.txt_servername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(223, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم السيرفر";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBox1.Controls.Add(this.btn_SAVE_SETING);
            this.groupBox1.Controls.Add(this.radioButtonLocal);
            this.groupBox1.Controls.Add(this.radioButtonNetWork);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPasswordDB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUserDB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_PortNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_DBname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_servername);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(422, 485);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اعدادات الشبكة";
            // 
            // btn_SAVE_SETING
            // 
            this.btn_SAVE_SETING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SAVE_SETING.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_SAVE_SETING.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_SAVE_SETING.Appearance.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.btn_SAVE_SETING.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_SAVE_SETING.Appearance.Options.UseBackColor = true;
            this.btn_SAVE_SETING.Appearance.Options.UseBorderColor = true;
            this.btn_SAVE_SETING.Appearance.Options.UseFont = true;
            this.btn_SAVE_SETING.Appearance.Options.UseForeColor = true;
            this.btn_SAVE_SETING.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_SAVE_SETING.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_SAVE_SETING.AppearanceHovered.Options.UseBackColor = true;
            this.btn_SAVE_SETING.AppearanceHovered.Options.UseForeColor = true;
            this.btn_SAVE_SETING.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_SAVE_SETING.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_save_32;
            this.btn_SAVE_SETING.Location = new System.Drawing.Point(281, 441);
            this.btn_SAVE_SETING.Name = "btn_SAVE_SETING";
            this.btn_SAVE_SETING.Size = new System.Drawing.Size(135, 38);
            this.btn_SAVE_SETING.TabIndex = 15;
            this.btn_SAVE_SETING.Text = "حفظ";
            this.btn_SAVE_SETING.Click += new System.EventHandler(this.btn_SAVE_SETING_Click);
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Checked = true;
            this.radioButtonLocal.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.radioButtonLocal.Location = new System.Drawing.Point(99, 36);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(64, 30);
            this.radioButtonLocal.TabIndex = 11;
            this.radioButtonLocal.TabStop = true;
            this.radioButtonLocal.Text = "محلي";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            this.radioButtonLocal.CheckedChanged += new System.EventHandler(this.radioButtonLocal_CheckedChanged);
            // 
            // radioButtonNetWork
            // 
            this.radioButtonNetWork.AutoSize = true;
            this.radioButtonNetWork.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.radioButtonNetWork.Location = new System.Drawing.Point(11, 36);
            this.radioButtonNetWork.Name = "radioButtonNetWork";
            this.radioButtonNetWork.Size = new System.Drawing.Size(71, 30);
            this.radioButtonNetWork.TabIndex = 10;
            this.radioButtonNetWork.Text = "شبكي";
            this.radioButtonNetWork.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(221, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "كلمة المرور";
            // 
            // txtPasswordDB
            // 
            this.txtPasswordDB.BackColor = System.Drawing.Color.LightCyan;
            this.txtPasswordDB.Enabled = false;
            this.txtPasswordDB.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.txtPasswordDB.Location = new System.Drawing.Point(54, 366);
            this.txtPasswordDB.Name = "txtPasswordDB";
            this.txtPasswordDB.Size = new System.Drawing.Size(130, 30);
            this.txtPasswordDB.TabIndex = 8;
            this.txtPasswordDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(221, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "اسم المستخدم";
            // 
            // txtUserDB
            // 
            this.txtUserDB.BackColor = System.Drawing.Color.LightCyan;
            this.txtUserDB.Enabled = false;
            this.txtUserDB.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.txtUserDB.Location = new System.Drawing.Point(54, 306);
            this.txtUserDB.Name = "txtUserDB";
            this.txtUserDB.Size = new System.Drawing.Size(130, 30);
            this.txtUserDB.TabIndex = 6;
            this.txtUserDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(221, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "رقم المنفذ";
            // 
            // txt_PortNum
            // 
            this.txt_PortNum.BackColor = System.Drawing.Color.LightCyan;
            this.txt_PortNum.Enabled = false;
            this.txt_PortNum.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.txt_PortNum.Location = new System.Drawing.Point(54, 246);
            this.txt_PortNum.Name = "txt_PortNum";
            this.txt_PortNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_PortNum.Size = new System.Drawing.Size(130, 30);
            this.txt_PortNum.TabIndex = 4;
            this.txt_PortNum.Text = "1433";
            this.txt_PortNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(223, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم قاعدة البيانات";
            // 
            // txt_DBname
            // 
            this.txt_DBname.BackColor = System.Drawing.Color.LightCyan;
            this.txt_DBname.Enabled = false;
            this.txt_DBname.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.txt_DBname.Location = new System.Drawing.Point(54, 186);
            this.txt_DBname.Name = "txt_DBname";
            this.txt_DBname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_DBname.Size = new System.Drawing.Size(130, 30);
            this.txt_DBname.TabIndex = 2;
            this.txt_DBname.Text = "Super_market_2023";
            this.txt_DBname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.radioButton_user);
            this.groupBox2.Controls.Add(this.radioButton_admin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.gridControl_USERS);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_paswword);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_username);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Location = new System.Drawing.Point(461, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(422, 481);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المستخدمين";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_edit.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_edit.Appearance.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_edit.Appearance.Options.UseBackColor = true;
            this.btn_edit.Appearance.Options.UseBorderColor = true;
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.Appearance.Options.UseForeColor = true;
            this.btn_edit.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_edit.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.AppearanceHovered.Options.UseBackColor = true;
            this.btn_edit.AppearanceHovered.Options.UseForeColor = true;
            this.btn_edit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_edit.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_edit_16;
            this.btn_edit.Location = new System.Drawing.Point(17, 136);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(77, 29);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_delete.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_delete.Appearance.Options.UseBackColor = true;
            this.btn_delete.Appearance.Options.UseBorderColor = true;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Appearance.Options.UseForeColor = true;
            this.btn_delete.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_delete.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.AppearanceHovered.Options.UseBackColor = true;
            this.btn_delete.AppearanceHovered.Options.UseForeColor = true;
            this.btn_delete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_delete.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_delete_trash_16;
            this.btn_delete.Location = new System.Drawing.Point(17, 92);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(77, 29);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_add.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_add.Appearance.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btn_add.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseBorderColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Appearance.Options.UseForeColor = true;
            this.btn_add.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_add.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_add.AppearanceHovered.Options.UseBackColor = true;
            this.btn_add.AppearanceHovered.Options.UseForeColor = true;
            this.btn_add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_add.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_add_16;
            this.btn_add.Location = new System.Drawing.Point(17, 48);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(77, 29);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_cat_add_Click);
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton_user.Location = new System.Drawing.Point(137, 136);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(74, 27);
            this.radioButton_user.TabIndex = 12;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "مستخدم";
            this.radioButton_user.UseVisualStyleBackColor = true;
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton_admin.Location = new System.Drawing.Point(220, 136);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(55, 27);
            this.radioButton_admin.TabIndex = 12;
            this.radioButton_admin.TabStop = true;
            this.radioButton_admin.Text = "ادمن";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(295, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "الصلاحيات";
            // 
            // gridControl_USERS
            // 
            this.gridControl_USERS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_USERS.Location = new System.Drawing.Point(0, 208);
            this.gridControl_USERS.MainView = this.gridView_users;
            this.gridControl_USERS.Name = "gridControl_USERS";
            this.gridControl_USERS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl_USERS.Size = new System.Drawing.Size(422, 269);
            this.gridControl_USERS.TabIndex = 5;
            this.gridControl_USERS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_users});
            this.gridControl_USERS.DoubleClick += new System.EventHandler(this.gridControl_USERS_DoubleClick);
            // 
            // gridView_users
            // 
            this.gridView_users.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView_users.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView_users.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView_users.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView_users.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_users.Appearance.Empty.Options.UseBackColor = true;
            this.gridView_users.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_users.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_users.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_users.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView_users.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.gridView_users.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_users.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView_users.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_users.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView_users.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView_users.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_users.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_users.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView_users.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_users.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_users.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_users.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView_users.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_users.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_users.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_users.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView_users.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView_users.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_users.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_users.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_users.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView_users.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_users.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView_users.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView_users.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_users.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_users.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_users.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView_users.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_users.Appearance.Preview.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_users.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_users.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_users.Appearance.Preview.Options.UseBackColor = true;
            this.gridView_users.Appearance.Preview.Options.UseFont = true;
            this.gridView_users.Appearance.Preview.Options.UseForeColor = true;
            this.gridView_users.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_users.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_users.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_users.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_users.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_users.Appearance.Row.Options.UseBackColor = true;
            this.gridView_users.Appearance.Row.Options.UseBorderColor = true;
            this.gridView_users.Appearance.Row.Options.UseFont = true;
            this.gridView_users.Appearance.Row.Options.UseForeColor = true;
            this.gridView_users.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_users.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView_users.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_users.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_users.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView_users.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView_users.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_users.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_users.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView_users.GridControl = this.gridControl_USERS;
            this.gridView_users.Name = "gridView_users";
            this.gridView_users.OptionsView.ShowGroupPanel = false;
            this.gridView_users.PaintStyleName = "UltraFlat";
            this.gridView_users.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_users_RowClick);
            this.gridView_users.DoubleClick += new System.EventHandler(this.gridView_users_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(286, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "كلمة المرور";
            // 
            // txt_paswword
            // 
            this.txt_paswword.BackColor = System.Drawing.Color.LightCyan;
            this.txt_paswword.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.txt_paswword.Location = new System.Drawing.Point(151, 91);
            this.txt_paswword.Name = "txt_paswword";
            this.txt_paswword.Size = new System.Drawing.Size(111, 30);
            this.txt_paswword.TabIndex = 2;
            this.txt_paswword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(286, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "اسم المستخدم";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.LightCyan;
            this.txt_username.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.txt_username.Location = new System.Drawing.Point(151, 48);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(111, 30);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(895, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات التطبيق";
            this.Load += new System.EventHandler(this.frm_setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_USERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_servername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPasswordDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PortNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DBname;
        private System.Windows.Forms.RadioButton radioButtonLocal;
        private System.Windows.Forms.RadioButton radioButtonNetWork;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_paswword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_username;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.GridControl gridControl_USERS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_users;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btn_SAVE_SETING;
        private System.Windows.Forms.RadioButton radioButton_user;
    }
}