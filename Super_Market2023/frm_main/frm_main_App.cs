using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Super_Market2023.Forms;

namespace Super_Market2023.frm_main
{
    public partial class frm_main_App : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_main_App()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            Forms.frm_cat_add frm_cat = new Forms.frm_cat_add();
            frm_cat.TopLevel=false;
            fluentDesignFormContainer1.Controls.Add(frm_cat);
            frm_cat.FormBorderStyle = FormBorderStyle. None;
            frm_cat.Dock = DockStyle.Fill;
            frm_cat.Show();
        }

        

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            Forms.frm_pro_add frm_pro = new Forms.frm_pro_add();
            frm_pro.TopLevel=false;
            fluentDesignFormContainer1.Controls.Add(frm_pro);
            frm_pro.FormBorderStyle = FormBorderStyle. None;
            frm_pro.Dock = DockStyle.Fill;
            frm_pro.Show();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            Forms.frm_sale_add frm_sale = new Forms.frm_sale_add();
            frm_sale.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_sale);
            frm_sale.FormBorderStyle = FormBorderStyle.None;
            frm_sale.Dock = DockStyle.Fill;
            frm_sale.Show();
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            


            fluentDesignFormContainer1.Controls.Clear();
            Forms.frm_inv frm_inv1 = new Forms.frm_inv();
            frm_inv1.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_inv1);
            frm_inv1.FormBorderStyle = FormBorderStyle.None;
            frm_inv1.Dock = DockStyle.Fill;
            frm_inv1.Show();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            Forms.frm_cust frm_cust1 = new Forms.frm_cust();
            frm_cust1.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_cust1);
            frm_cust1.FormBorderStyle = FormBorderStyle.None;
            frm_cust1.Dock = DockStyle.Fill;
            frm_cust1.Show();
        }
        
    }
}
