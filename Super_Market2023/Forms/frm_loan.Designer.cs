namespace Super_Market2023.Forms
{
    partial class frm_loan
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
            this.panel1loan = new System.Windows.Forms.Panel();
            this.btn_loan_del = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_loan = new DevExpress.XtraGrid.GridControl();
            this.gridView_loan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelColoan = new DevExpress.XtraEditors.LabelControl();
            this.txt_search_loan = new System.Windows.Forms.TextBox();
            this.panel1loan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_loan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_loan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1loan
            // 
            this.panel1loan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1loan.Controls.Add(this.btn_loan_del);
            this.panel1loan.Controls.Add(this.gridControl_loan);
            this.panel1loan.Controls.Add(this.labelColoan);
            this.panel1loan.Controls.Add(this.txt_search_loan);
            this.panel1loan.Location = new System.Drawing.Point(0, -1);
            this.panel1loan.Name = "panel1loan";
            this.panel1loan.Size = new System.Drawing.Size(916, 550);
            this.panel1loan.TabIndex = 2;
            // 
            // btn_loan_del
            // 
            this.btn_loan_del.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_loan_del.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_loan_del.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_loan_del.Appearance.Font = new System.Drawing.Font("Cairo", 9.999999F, System.Drawing.FontStyle.Bold);
            this.btn_loan_del.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_loan_del.Appearance.Options.UseBackColor = true;
            this.btn_loan_del.Appearance.Options.UseBorderColor = true;
            this.btn_loan_del.Appearance.Options.UseFont = true;
            this.btn_loan_del.Appearance.Options.UseForeColor = true;
            this.btn_loan_del.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_loan_del.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_loan_del.AppearanceHovered.Options.UseBackColor = true;
            this.btn_loan_del.AppearanceHovered.Options.UseForeColor = true;
            this.btn_loan_del.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_loan_del.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_delete_trash_32;
            this.btn_loan_del.ImageOptions.ImageIndex = 1;
            this.btn_loan_del.Location = new System.Drawing.Point(653, 14);
            this.btn_loan_del.Name = "btn_loan_del";
            this.btn_loan_del.Size = new System.Drawing.Size(98, 30);
            this.btn_loan_del.TabIndex = 24;
            this.btn_loan_del.Text = "حذف ";
            this.btn_loan_del.Click += new System.EventHandler(this.btn_loan_del_Click);
            // 
            // gridControl_loan
            // 
            this.gridControl_loan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_loan.Location = new System.Drawing.Point(3, 48);
            this.gridControl_loan.MainView = this.gridView_loan;
            this.gridControl_loan.Name = "gridControl_loan";
            this.gridControl_loan.Size = new System.Drawing.Size(913, 499);
            this.gridControl_loan.TabIndex = 23;
            this.gridControl_loan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_loan});
            // 
            // gridView_loan
            // 
            this.gridView_loan.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView_loan.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView_loan.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView_loan.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView_loan.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_loan.Appearance.Empty.Options.UseBackColor = true;
            this.gridView_loan.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_loan.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_loan.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_loan.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView_loan.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.gridView_loan.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_loan.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView_loan.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_loan.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView_loan.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView_loan.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_loan.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_loan.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView_loan.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_loan.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_loan.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_loan.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView_loan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_loan.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_loan.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_loan.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView_loan.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView_loan.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_loan.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_loan.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_loan.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView_loan.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_loan.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView_loan.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView_loan.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_loan.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_loan.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_loan.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView_loan.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_loan.Appearance.Preview.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_loan.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_loan.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_loan.Appearance.Preview.Options.UseBackColor = true;
            this.gridView_loan.Appearance.Preview.Options.UseFont = true;
            this.gridView_loan.Appearance.Preview.Options.UseForeColor = true;
            this.gridView_loan.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_loan.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_loan.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_loan.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_loan.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_loan.Appearance.Row.Options.UseBackColor = true;
            this.gridView_loan.Appearance.Row.Options.UseBorderColor = true;
            this.gridView_loan.Appearance.Row.Options.UseFont = true;
            this.gridView_loan.Appearance.Row.Options.UseForeColor = true;
            this.gridView_loan.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_loan.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView_loan.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_loan.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_loan.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView_loan.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView_loan.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_loan.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_loan.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView_loan.GridControl = this.gridControl_loan;
            this.gridView_loan.Name = "gridView_loan";
            this.gridView_loan.OptionsView.ShowGroupPanel = false;
            this.gridView_loan.PaintStyleName = "UltraFlat";
            this.gridView_loan.DoubleClick += new System.EventHandler(this.gridView_loan_DoubleClick);
            // 
            // labelColoan
            // 
            this.labelColoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelColoan.Appearance.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Bold);
            this.labelColoan.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelColoan.Appearance.Options.UseFont = true;
            this.labelColoan.Appearance.Options.UseForeColor = true;
            this.labelColoan.Location = new System.Drawing.Point(558, 21);
            this.labelColoan.Name = "labelColoan";
            this.labelColoan.Size = new System.Drawing.Size(22, 23);
            this.labelColoan.TabIndex = 2;
            this.labelColoan.Text = "بحث";
            // 
            // txt_search_loan
            // 
            this.txt_search_loan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search_loan.BackColor = System.Drawing.Color.LightCyan;
            this.txt_search_loan.Location = new System.Drawing.Point(297, 22);
            this.txt_search_loan.Name = "txt_search_loan";
            this.txt_search_loan.Size = new System.Drawing.Size(244, 20);
            this.txt_search_loan.TabIndex = 1;
            this.txt_search_loan.TextChanged += new System.EventHandler(this.txt_search_loan_TextChanged);
            // 
            // frm_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 549);
            this.Controls.Add(this.panel1loan);
            this.Name = "frm_loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الديون";
            this.Load += new System.EventHandler(this.frm_loan_Load);
            this.panel1loan.ResumeLayout(false);
            this.panel1loan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_loan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_loan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1loan;
        private DevExpress.XtraGrid.GridControl gridControl_loan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_loan;
        private DevExpress.XtraEditors.LabelControl labelColoan;
        private System.Windows.Forms.TextBox txt_search_loan;
        private DevExpress.XtraEditors.SimpleButton btn_loan_del;
    }
}