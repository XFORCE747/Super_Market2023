namespace Super_Market2023.Forms
{
    partial class frm_inv
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnClearFilter = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditTo = new System.Windows.Forms.DateTimePicker();
            this.dateEditFrom = new System.Windows.Forms.DateTimePicker();
            this.gridControl_inv = new DevExpress.XtraGrid.GridControl();
            this.gridView_inv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_inv_clear = new DevExpress.XtraEditors.SimpleButton();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.btnClearFilter);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.dateEditTo);
            this.panel1.Controls.Add(this.dateEditFrom);
            this.panel1.Controls.Add(this.gridControl_inv);
            this.panel1.Controls.Add(this.btn_inv_clear);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 551);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Super_Market2023.Properties.Resources.icons8_cash_receipt_100;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(330, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 36);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "فواتير اليوم";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearFilter.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnClearFilter.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnClearFilter.Appearance.Font = new System.Drawing.Font("Cairo", 9.999999F, System.Drawing.FontStyle.Bold);
            this.btnClearFilter.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btnClearFilter.Appearance.Options.UseBackColor = true;
            this.btnClearFilter.Appearance.Options.UseBorderColor = true;
            this.btnClearFilter.Appearance.Options.UseFont = true;
            this.btnClearFilter.Appearance.Options.UseForeColor = true;
            this.btnClearFilter.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btnClearFilter.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btnClearFilter.AppearanceHovered.Options.UseBackColor = true;
            this.btnClearFilter.AppearanceHovered.Options.UseForeColor = true;
            this.btnClearFilter.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnClearFilter.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_show_property_32;
            this.btnClearFilter.Location = new System.Drawing.Point(114, 21);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(157, 42);
            this.btnClearFilter.TabIndex = 28;
            this.btnClearFilter.Text = "عرض كافة الفواتير";
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(789, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(18, 24);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "الى";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(788, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 24);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "من";
            // 
            // dateEditTo
            // 
            this.dateEditTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditTo.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.dateEditTo.Location = new System.Drawing.Point(648, 49);
            this.dateEditTo.Name = "dateEditTo";
            this.dateEditTo.Size = new System.Drawing.Size(129, 20);
            this.dateEditTo.TabIndex = 25;
            this.dateEditTo.ValueChanged += new System.EventHandler(this.dateEditTo_ValueChanged);
            // 
            // dateEditFrom
            // 
            this.dateEditFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditFrom.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.dateEditFrom.Location = new System.Drawing.Point(648, 15);
            this.dateEditFrom.Name = "dateEditFrom";
            this.dateEditFrom.Size = new System.Drawing.Size(129, 20);
            this.dateEditFrom.TabIndex = 24;
            this.dateEditFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // gridControl_inv
            // 
            this.gridControl_inv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_inv.Location = new System.Drawing.Point(0, 82);
            this.gridControl_inv.MainView = this.gridView_inv;
            this.gridControl_inv.Name = "gridControl_inv";
            this.gridControl_inv.Size = new System.Drawing.Size(847, 469);
            this.gridControl_inv.TabIndex = 23;
            this.gridControl_inv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_inv});
            // 
            // gridView_inv
            // 
            this.gridView_inv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Black;
            this.gridView_inv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView_inv.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView_inv.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView_inv.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_inv.Appearance.Empty.Options.UseBackColor = true;
            this.gridView_inv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_inv.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_inv.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_inv.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView_inv.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.gridView_inv.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_inv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView_inv.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_inv.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView_inv.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView_inv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_inv.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_inv.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView_inv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_inv.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_inv.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_inv.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView_inv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_inv.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.gridView_inv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView_inv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView_inv.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView_inv.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_inv.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_inv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_inv.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView_inv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_inv.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView_inv.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView_inv.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_inv.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_inv.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_inv.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView_inv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_inv.Appearance.Preview.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_inv.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_inv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_inv.Appearance.Preview.Options.UseBackColor = true;
            this.gridView_inv.Appearance.Preview.Options.UseFont = true;
            this.gridView_inv.Appearance.Preview.Options.UseForeColor = true;
            this.gridView_inv.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_inv.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_inv.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridView_inv.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_inv.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView_inv.Appearance.Row.Options.UseBackColor = true;
            this.gridView_inv.Appearance.Row.Options.UseBorderColor = true;
            this.gridView_inv.Appearance.Row.Options.UseFont = true;
            this.gridView_inv.Appearance.Row.Options.UseForeColor = true;
            this.gridView_inv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_inv.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView_inv.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_inv.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_inv.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView_inv.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView_inv.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_inv.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_inv.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView_inv.GridControl = this.gridControl_inv;
            this.gridView_inv.Name = "gridView_inv";
            this.gridView_inv.OptionsView.ShowGroupPanel = false;
            this.gridView_inv.PaintStyleName = "UltraFlat";
            // 
            // btn_inv_clear
            // 
            this.btn_inv_clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_inv_clear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btn_inv_clear.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_inv_clear.Appearance.Font = new System.Drawing.Font("Cairo", 9.999999F, System.Drawing.FontStyle.Bold);
            this.btn_inv_clear.Appearance.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_inv_clear.Appearance.Options.UseBackColor = true;
            this.btn_inv_clear.Appearance.Options.UseBorderColor = true;
            this.btn_inv_clear.Appearance.Options.UseFont = true;
            this.btn_inv_clear.Appearance.Options.UseForeColor = true;
            this.btn_inv_clear.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(49)))), ((int)(((byte)(233)))));
            this.btn_inv_clear.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_inv_clear.AppearanceHovered.Options.UseBackColor = true;
            this.btn_inv_clear.AppearanceHovered.Options.UseForeColor = true;
            this.btn_inv_clear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_inv_clear.ImageOptions.Image = global::Super_Market2023.Properties.Resources.icons8_print_32;
            this.btn_inv_clear.Location = new System.Drawing.Point(485, 21);
            this.btn_inv_clear.Name = "btn_inv_clear";
            this.btn_inv_clear.Size = new System.Drawing.Size(157, 42);
            this.btn_inv_clear.TabIndex = 22;
            this.btn_inv_clear.Text = "طباعة تقرير";
            this.btn_inv_clear.Click += new System.EventHandler(this.btn_inv_clear_Click);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // frm_inv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 549);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_inv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كافة الفواتير";
            this.Load += new System.EventHandler(this.frm_inv_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_inv_clear;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.GridControl gridControl_inv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_inv;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dateEditTo;
        private System.Windows.Forms.DateTimePicker dateEditFrom;
        private DevExpress.XtraEditors.SimpleButton btnClearFilter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}