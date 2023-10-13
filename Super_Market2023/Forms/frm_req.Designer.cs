namespace Super_Market2023.Forms
{
    partial class frm_req
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
            this.panel1req = new System.Windows.Forms.Panel();
            this.btn_delete_req = new DevExpress.XtraEditors.SimpleButton();
            this.btn_req = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_req = new DevExpress.XtraGrid.GridControl();
            this.gridView_req = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelCoreq = new DevExpress.XtraEditors.LabelControl();
            this.txt_search_req = new System.Windows.Forms.TextBox();
            this.panel1req.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_req)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_req)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1req
            // 
            this.panel1req.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1req.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1req.Controls.Add(this.btn_delete_req);
            this.panel1req.Controls.Add(this.btn_req);
            this.panel1req.Controls.Add(this.gridControl_req);
            this.panel1req.Controls.Add(this.labelCoreq);
            this.panel1req.Controls.Add(this.txt_search_req);
            this.panel1req.Location = new System.Drawing.Point(0, -1);
            this.panel1req.Name = "panel1req";
            this.panel1req.Size = new System.Drawing.Size(916, 550);
            this.panel1req.TabIndex = 1;
            // 
            // btn_delete_req
            // 
            this.btn_delete_req.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete_req.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_delete_req.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_delete_req.Appearance.Font = new System.Drawing.Font("Cairo", 9.999999F, System.Drawing.FontStyle.Bold);
            this.btn_delete_req.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_delete_req.Appearance.Options.UseBackColor = true;
            this.btn_delete_req.Appearance.Options.UseBorderColor = true;
            this.btn_delete_req.Appearance.Options.UseFont = true;
            this.btn_delete_req.Appearance.Options.UseForeColor = true;
            this.btn_delete_req.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_delete_req.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_delete_req.AppearanceHovered.Options.UseBackColor = true;
            this.btn_delete_req.AppearanceHovered.Options.UseForeColor = true;
            this.btn_delete_req.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_delete_req.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_delete_trash_32;
            this.btn_delete_req.Location = new System.Drawing.Point(98, 13);
            this.btn_delete_req.Name = "btn_delete_req";
            this.btn_delete_req.Size = new System.Drawing.Size(141, 33);
            this.btn_delete_req.TabIndex = 25;
            this.btn_delete_req.Text = "الغاء الطلب";
            this.btn_delete_req.Click += new System.EventHandler(this.btn_delete_req_Click);
            // 
            // btn_req
            // 
            this.btn_req.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_req.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_req.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_req.Appearance.Font = new System.Drawing.Font("Cairo", 9.999999F, System.Drawing.FontStyle.Bold);
            this.btn_req.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_req.Appearance.Options.UseBackColor = true;
            this.btn_req.Appearance.Options.UseBorderColor = true;
            this.btn_req.Appearance.Options.UseFont = true;
            this.btn_req.Appearance.Options.UseForeColor = true;
            this.btn_req.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_req.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_req.AppearanceHovered.Options.UseBackColor = true;
            this.btn_req.AppearanceHovered.Options.UseForeColor = true;
            this.btn_req.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_req.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_order_completed_321;
            this.btn_req.Location = new System.Drawing.Point(667, 13);
            this.btn_req.Name = "btn_req";
            this.btn_req.Size = new System.Drawing.Size(141, 33);
            this.btn_req.TabIndex = 24;
            this.btn_req.Text = "تم تسليم الطلب";
            this.btn_req.Click += new System.EventHandler(this.btn_req_Click);
            // 
            // gridControl_req
            // 
            this.gridControl_req.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_req.Location = new System.Drawing.Point(3, 52);
            this.gridControl_req.MainView = this.gridView_req;
            this.gridControl_req.Name = "gridControl_req";
            this.gridControl_req.Size = new System.Drawing.Size(913, 495);
            this.gridControl_req.TabIndex = 23;
            this.gridControl_req.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_req});
            // 
            // gridView_req
            // 
            this.gridView_req.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView_req.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView_req.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView_req.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView_req.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_req.Appearance.Empty.Options.UseBackColor = true;
            this.gridView_req.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_req.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_req.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_req.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView_req.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.gridView_req.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_req.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView_req.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_req.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView_req.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView_req.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_req.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_req.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView_req.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_req.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_req.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_req.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView_req.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_req.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_req.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_req.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView_req.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView_req.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_req.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_req.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_req.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView_req.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_req.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView_req.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView_req.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_req.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_req.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_req.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView_req.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_req.Appearance.Preview.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_req.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_req.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_req.Appearance.Preview.Options.UseBackColor = true;
            this.gridView_req.Appearance.Preview.Options.UseFont = true;
            this.gridView_req.Appearance.Preview.Options.UseForeColor = true;
            this.gridView_req.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_req.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_req.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_req.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_req.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_req.Appearance.Row.Options.UseBackColor = true;
            this.gridView_req.Appearance.Row.Options.UseBorderColor = true;
            this.gridView_req.Appearance.Row.Options.UseFont = true;
            this.gridView_req.Appearance.Row.Options.UseForeColor = true;
            this.gridView_req.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_req.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView_req.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_req.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_req.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView_req.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView_req.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_req.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_req.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView_req.GridControl = this.gridControl_req;
            this.gridView_req.Name = "gridView_req";
            this.gridView_req.OptionsView.ShowGroupPanel = false;
            this.gridView_req.PaintStyleName = "UltraFlat";
            this.gridView_req.DoubleClick += new System.EventHandler(this.gridView_req_DoubleClick);
            // 
            // labelCoreq
            // 
            this.labelCoreq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCoreq.Appearance.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Bold);
            this.labelCoreq.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelCoreq.Appearance.Options.UseFont = true;
            this.labelCoreq.Appearance.Options.UseForeColor = true;
            this.labelCoreq.Location = new System.Drawing.Point(560, 25);
            this.labelCoreq.Name = "labelCoreq";
            this.labelCoreq.Size = new System.Drawing.Size(22, 23);
            this.labelCoreq.TabIndex = 2;
            this.labelCoreq.Text = "بحث";
            // 
            // txt_search_req
            // 
            this.txt_search_req.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search_req.BackColor = System.Drawing.Color.LightCyan;
            this.txt_search_req.Location = new System.Drawing.Point(298, 26);
            this.txt_search_req.Name = "txt_search_req";
            this.txt_search_req.Size = new System.Drawing.Size(244, 20);
            this.txt_search_req.TabIndex = 1;
            // 
            // frm_req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 549);
            this.Controls.Add(this.panel1req);
            this.Name = "frm_req";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الطلبات";
            this.Load += new System.EventHandler(this.frm_req_Load);
            this.panel1req.ResumeLayout(false);
            this.panel1req.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_req)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_req)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1req;
        private DevExpress.XtraGrid.GridControl gridControl_req;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_req;
        private DevExpress.XtraEditors.LabelControl labelCoreq;
        private System.Windows.Forms.TextBox txt_search_req;
        private DevExpress.XtraEditors.SimpleButton btn_req;
        private DevExpress.XtraEditors.SimpleButton btn_delete_req;
    }
}