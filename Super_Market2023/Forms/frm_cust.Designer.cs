namespace Super_Market2023.Forms
{
    partial class frm_cust
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cust_show = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_cust = new DevExpress.XtraGrid.GridControl();
            this.gridView_cust = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_cust_delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelCo = new DevExpress.XtraEditors.LabelControl();
            this.txt_search_inv = new System.Windows.Forms.TextBox();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_cust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.btn_cust_show);
            this.panel1.Controls.Add(this.gridControl_cust);
            this.panel1.Controls.Add(this.btn_cust_delete);
            this.panel1.Controls.Add(this.labelCo);
            this.panel1.Controls.Add(this.txt_search_inv);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 550);
            this.panel1.TabIndex = 0;
            // 
            // btn_cust_show
            // 
            this.btn_cust_show.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cust_show.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_cust_show.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_cust_show.Appearance.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.btn_cust_show.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_cust_show.Appearance.Options.UseBackColor = true;
            this.btn_cust_show.Appearance.Options.UseBorderColor = true;
            this.btn_cust_show.Appearance.Options.UseFont = true;
            this.btn_cust_show.Appearance.Options.UseForeColor = true;
            this.btn_cust_show.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_cust_show.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_cust_show.AppearanceHovered.Options.UseBackColor = true;
            this.btn_cust_show.AppearanceHovered.Options.UseForeColor = true;
            this.btn_cust_show.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_cust_show.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_show_property_32;
            this.btn_cust_show.Location = new System.Drawing.Point(699, 13);
            this.btn_cust_show.Name = "btn_cust_show";
            this.btn_cust_show.Size = new System.Drawing.Size(139, 39);
            this.btn_cust_show.TabIndex = 24;
            this.btn_cust_show.Text = "عرض المشتريات";
            this.btn_cust_show.Click += new System.EventHandler(this.btn_cust_delete_Click);
            // 
            // gridControl_cust
            // 
            this.gridControl_cust.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_cust.Location = new System.Drawing.Point(3, 60);
            this.gridControl_cust.MainView = this.gridView_cust;
            this.gridControl_cust.Name = "gridControl_cust";
            this.gridControl_cust.Size = new System.Drawing.Size(911, 487);
            this.gridControl_cust.TabIndex = 23;
            this.gridControl_cust.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_cust});
            // 
            // gridView_cust
            // 
            this.gridView_cust.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView_cust.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView_cust.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView_cust.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView_cust.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust.Appearance.Empty.Options.UseBackColor = true;
            this.gridView_cust.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_cust.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView_cust.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.gridView_cust.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_cust.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView_cust.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_cust.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView_cust.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView_cust.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView_cust.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_cust.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_cust.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_cust.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView_cust.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_cust.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_cust.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_cust.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView_cust.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView_cust.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_cust.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_cust.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView_cust.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView_cust.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView_cust.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_cust.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_cust.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView_cust.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust.Appearance.Preview.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_cust.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_cust.Appearance.Preview.Options.UseBackColor = true;
            this.gridView_cust.Appearance.Preview.Options.UseFont = true;
            this.gridView_cust.Appearance.Preview.Options.UseForeColor = true;
            this.gridView_cust.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_cust.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_cust.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_cust.Appearance.Row.Options.UseBackColor = true;
            this.gridView_cust.Appearance.Row.Options.UseBorderColor = true;
            this.gridView_cust.Appearance.Row.Options.UseFont = true;
            this.gridView_cust.Appearance.Row.Options.UseForeColor = true;
            this.gridView_cust.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView_cust.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_cust.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_cust.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView_cust.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView_cust.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_cust.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView_cust.GridControl = this.gridControl_cust;
            this.gridView_cust.Name = "gridView_cust";
            this.gridView_cust.OptionsView.ShowGroupPanel = false;
            this.gridView_cust.PaintStyleName = "UltraFlat";
            this.gridView_cust.DoubleClick += new System.EventHandler(this.gridView_cust_DoubleClick);
            // 
            // btn_cust_delete
            // 
            this.btn_cust_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cust_delete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_cust_delete.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_cust_delete.Appearance.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.btn_cust_delete.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_cust_delete.Appearance.Options.UseBackColor = true;
            this.btn_cust_delete.Appearance.Options.UseBorderColor = true;
            this.btn_cust_delete.Appearance.Options.UseFont = true;
            this.btn_cust_delete.Appearance.Options.UseForeColor = true;
            this.btn_cust_delete.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_cust_delete.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_cust_delete.AppearanceHovered.Options.UseBackColor = true;
            this.btn_cust_delete.AppearanceHovered.Options.UseForeColor = true;
            this.btn_cust_delete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_cust_delete.ImageOptions.Image = global::Super_Market2023.Properties.Resources.cross_out__2_;
            this.btn_cust_delete.ImageOptions.ImageIndex = 1;
            this.btn_cust_delete.Location = new System.Drawing.Point(107, 13);
            this.btn_cust_delete.Name = "btn_cust_delete";
            this.btn_cust_delete.Size = new System.Drawing.Size(139, 39);
            this.btn_cust_delete.TabIndex = 22;
            this.btn_cust_delete.Text = "حذف الزبون";
            // 
            // labelCo
            // 
            this.labelCo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCo.Appearance.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.labelCo.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelCo.Appearance.Options.UseFont = true;
            this.labelCo.Appearance.Options.UseForeColor = true;
            this.labelCo.Location = new System.Drawing.Point(581, 26);
            this.labelCo.Name = "labelCo";
            this.labelCo.Size = new System.Drawing.Size(25, 26);
            this.labelCo.TabIndex = 2;
            this.labelCo.Text = "بحث";
            // 
            // txt_search_inv
            // 
            this.txt_search_inv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search_inv.BackColor = System.Drawing.Color.LightCyan;
            this.txt_search_inv.Location = new System.Drawing.Point(319, 28);
            this.txt_search_inv.Name = "txt_search_inv";
            this.txt_search_inv.Size = new System.Drawing.Size(244, 20);
            this.txt_search_inv.TabIndex = 1;
            this.txt_search_inv.TextChanged += new System.EventHandler(this.txt_search_inv_TextChanged);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // frm_cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 549);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_cust";
            this.Text = "الزبائن";
            this.Load += new System.EventHandler(this.frm_cust_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_cust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelCo;
        private System.Windows.Forms.TextBox txt_search_inv;
        private DevExpress.XtraEditors.SimpleButton btn_cust_delete;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.GridControl gridControl_cust;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_cust;
        private DevExpress.XtraEditors.SimpleButton btn_cust_show;
    }
}