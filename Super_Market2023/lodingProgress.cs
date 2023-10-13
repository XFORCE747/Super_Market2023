using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market2023
{
    public partial class lodingProgress : Form
    {
        public lodingProgress()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width >= 599)
            {
                timer1.Stop();
                Forms.FormMainMenu frm = new Forms.FormMainMenu();
                frm.Show();
                this.Hide();
            }
        }

        private void lodingProgress_Load(object sender, EventArgs e)
        {
           
        }
    }
}
