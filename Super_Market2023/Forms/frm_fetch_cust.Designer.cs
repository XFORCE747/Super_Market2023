namespace Super_Market2023.Forms
{
    partial class frm_fetch_cust
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
            this.panel1321 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelCo = new DevExpress.XtraEditors.LabelControl();
            this.txt_search_cust_fetch = new System.Windows.Forms.TextBox();
            this.gridControl_cust_loan_list = new DevExpress.XtraGrid.GridControl();
            this.gridView_cust_loan_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1321.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_cust_loan_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cust_loan_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1321
            // 
            this.panel1321.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1321.Controls.Add(this.labelControl2);
            this.panel1321.Controls.Add(this.labelCo);
            this.panel1321.Controls.Add(this.txt_search_cust_fetch);
            this.panel1321.Controls.Add(this.gridControl_cust_loan_list);
            this.panel1321.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1321.Location = new System.Drawing.Point(0, 0);
            this.panel1321.Name = "panel1321";
            this.panel1321.Size = new System.Drawing.Size(838, 448);
            this.panel1321.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(345, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 34);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "قم باختيار الزبون";
            // 
            // labelCo
            // 
            this.labelCo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCo.Appearance.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.labelCo.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelCo.Appearance.Options.UseFont = true;
            this.labelCo.Appearance.Options.UseForeColor = true;
            this.labelCo.Location = new System.Drawing.Point(531, 56);
            this.labelCo.Name = "labelCo";
            this.labelCo.Size = new System.Drawing.Size(25, 26);
            this.labelCo.TabIndex = 26;
            this.labelCo.Text = "بحث";
            // 
            // txt_search_cust_fetch
            // 
            this.txt_search_cust_fetch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search_cust_fetch.BackColor = System.Drawing.Color.LightCyan;
            this.txt_search_cust_fetch.Location = new System.Drawing.Point(269, 59);
            this.txt_search_cust_fetch.Name = "txt_search_cust_fetch";
            this.txt_search_cust_fetch.Size = new System.Drawing.Size(244, 20);
            this.txt_search_cust_fetch.TabIndex = 25;
            this.txt_search_cust_fetch.TextChanged += new System.EventHandler(this.txt_search_cust_fetch_TextChanged);
            // 
            // gridControl_cust_loan_list
            // 
            this.gridControl_cust_loan_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_cust_loan_list.Location = new System.Drawing.Point(3, 84);
            this.gridControl_cust_loan_list.MainView = this.gridView_cust_loan_list;
            this.gridControl_cust_loan_list.Name = "gridControl_cust_loan_list";
            this.gridControl_cust_loan_list.Size = new System.Drawing.Size(835, 364);
            this.gridControl_cust_loan_list.TabIndex = 24;
            this.gridControl_cust_loan_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_cust_loan_list});
            // 
            // gridView_cust_loan_list
            // 
            this.gridView_cust_loan_list.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView_cust_loan_list.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView_cust_loan_list.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView_cust_loan_list.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView_cust_loan_list.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust_loan_list.Appearance.Empty.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust_loan_list.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust_loan_list.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.gridView_cust_loan_list.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_cust_loan_list.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView_cust_loan_list.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView_cust_loan_list.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView_cust_loan_list.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust_loan_list.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust_loan_list.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView_cust_loan_list.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_cust_loan_list.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_cust_loan_list.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView_cust_loan_list.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_cust_loan_list.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_cust_loan_list.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_cust_loan_list.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView_cust_loan_list.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_cust_loan_list.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_cust_loan_list.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust_loan_list.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust_loan_list.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView_cust_loan_list.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_cust_loan_list.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_cust_loan_list.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust_loan_list.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust_loan_list.Appearance.Preview.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust_loan_list.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_cust_loan_list.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_cust_loan_list.Appearance.Preview.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.Preview.Options.UseFont = true;
            this.gridView_cust_loan_list.Appearance.Preview.Options.UseForeColor = true;
            this.gridView_cust_loan_list.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust_loan_list.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust_loan_list.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust_loan_list.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_cust_loan_list.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_cust_loan_list.Appearance.Row.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.Row.Options.UseBorderColor = true;
            this.gridView_cust_loan_list.Appearance.Row.Options.UseFont = true;
            this.gridView_cust_loan_list.Appearance.Row.Options.UseForeColor = true;
            this.gridView_cust_loan_list.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust_loan_list.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView_cust_loan_list.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_cust_loan_list.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_cust_loan_list.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView_cust_loan_list.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView_cust_loan_list.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust_loan_list.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust_loan_list.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView_cust_loan_list.GridControl = this.gridControl_cust_loan_list;
            this.gridView_cust_loan_list.Name = "gridView_cust_loan_list";
            this.gridView_cust_loan_list.OptionsView.ShowGroupPanel = false;
            this.gridView_cust_loan_list.PaintStyleName = "UltraFlat";
            this.gridView_cust_loan_list.DoubleClick += new System.EventHandler(this.gridView_cust_loan_list_DoubleClick);
            // 
            // frm_fetch_cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 448);
            this.Controls.Add(this.panel1321);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(854, 487);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(854, 487);
            this.Name = "frm_fetch_cust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اختيار زبون";
            this.Load += new System.EventHandler(this.frm_fetch_cust_Load);
            this.panel1321.ResumeLayout(false);
            this.panel1321.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_cust_loan_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cust_loan_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1321;
        private DevExpress.XtraGrid.GridControl gridControl_cust_loan_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_cust_loan_list;
        private DevExpress.XtraEditors.LabelControl labelCo;
        private System.Windows.Forms.TextBox txt_search_cust_fetch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}