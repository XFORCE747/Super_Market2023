namespace Super_Market2023.Forms
{
    partial class frm_data_cust
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
            this.belCon = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_totalSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl_data_cust = new DevExpress.XtraGrid.GridControl();
            this.gridView_data_cust = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_closeChildForm_cust = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_data_cust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_data_cust)).BeginInit();
            this.SuspendLayout();
            // 
            // belCon
            // 
            this.belCon.Appearance.Font = new System.Drawing.Font("Cairo", 16.25F, System.Drawing.FontStyle.Bold);
            this.belCon.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.belCon.Appearance.Options.UseFont = true;
            this.belCon.Appearance.Options.UseForeColor = true;
            this.belCon.Location = new System.Drawing.Point(408, 15);
            this.belCon.Name = "belCon";
            this.belCon.Size = new System.Drawing.Size(192, 42);
            this.belCon.TabIndex = 25;
            this.belCon.Text = "مشتريات هذا الزبون";
            this.belCon.Click += new System.EventHandler(this.belCon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_totalSum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gridControl_data_cust);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 486);
            this.panel1.TabIndex = 24;
            // 
            // text_totalSum
            // 
            this.text_totalSum.BackColor = System.Drawing.Color.LightCyan;
            this.text_totalSum.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold);
            this.text_totalSum.Location = new System.Drawing.Point(483, 436);
            this.text_totalSum.Name = "text_totalSum";
            this.text_totalSum.Size = new System.Drawing.Size(127, 43);
            this.text_totalSum.TabIndex = 25;
            this.text_totalSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(630, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "مجموع المشتريات";
            // 
            // gridControl_data_cust
            // 
            this.gridControl_data_cust.Location = new System.Drawing.Point(0, 0);
            this.gridControl_data_cust.MainView = this.gridView_data_cust;
            this.gridControl_data_cust.Name = "gridControl_data_cust";
            this.gridControl_data_cust.Size = new System.Drawing.Size(1023, 409);
            this.gridControl_data_cust.TabIndex = 23;
            this.gridControl_data_cust.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_data_cust});
            // 
            // gridView_data_cust
            // 
            this.gridView_data_cust.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView_data_cust.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView_data_cust.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView_data_cust.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView_data_cust.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_data_cust.Appearance.Empty.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_data_cust.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_data_cust.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.gridView_data_cust.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_data_cust.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView_data_cust.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView_data_cust.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView_data_cust.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_data_cust.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_data_cust.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView_data_cust.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_data_cust.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_data_cust.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView_data_cust.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_data_cust.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_data_cust.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_data_cust.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView_data_cust.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_data_cust.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_data_cust.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_data_cust.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_data_cust.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView_data_cust.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_data_cust.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_data_cust.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_data_cust.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_data_cust.Appearance.Preview.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_data_cust.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_data_cust.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_data_cust.Appearance.Preview.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.Preview.Options.UseFont = true;
            this.gridView_data_cust.Appearance.Preview.Options.UseForeColor = true;
            this.gridView_data_cust.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_data_cust.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_data_cust.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_data_cust.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_data_cust.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_data_cust.Appearance.Row.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.Row.Options.UseBorderColor = true;
            this.gridView_data_cust.Appearance.Row.Options.UseFont = true;
            this.gridView_data_cust.Appearance.Row.Options.UseForeColor = true;
            this.gridView_data_cust.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_data_cust.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView_data_cust.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_data_cust.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_data_cust.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView_data_cust.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView_data_cust.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_data_cust.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_data_cust.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView_data_cust.GridControl = this.gridControl_data_cust;
            this.gridView_data_cust.Name = "gridView_data_cust";
            this.gridView_data_cust.OptionsView.ShowGroupPanel = false;
            this.gridView_data_cust.PaintStyleName = "UltraFlat";
            // 
            // btn_closeChildForm_cust
            // 
            this.btn_closeChildForm_cust.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeChildForm_cust.FlatAppearance.BorderSize = 0;
            this.btn_closeChildForm_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeChildForm_cust.Image = global::Super_Market2023.Properties.Resources.cross_out__2_;
            this.btn_closeChildForm_cust.Location = new System.Drawing.Point(949, 0);
            this.btn_closeChildForm_cust.Name = "btn_closeChildForm_cust";
            this.btn_closeChildForm_cust.Size = new System.Drawing.Size(75, 72);
            this.btn_closeChildForm_cust.TabIndex = 26;
            this.btn_closeChildForm_cust.UseVisualStyleBackColor = true;
            this.btn_closeChildForm_cust.Click += new System.EventHandler(this.btn_closeChildForm_cust_Click);
            // 
            // frm_data_cust
            // 
            this.Appearance.BackColor = System.Drawing.Color.SlateGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 558);
            this.ControlBox = false;
            this.Controls.Add(this.btn_closeChildForm_cust);
            this.Controls.Add(this.belCon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_data_cust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشتريات هذا الزبون";
            this.Load += new System.EventHandler(this.frm_data_cust_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_data_cust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_data_cust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl belCon;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_data_cust;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_data_cust;
        private System.Windows.Forms.TextBox text_totalSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_closeChildForm_cust;
    }
}