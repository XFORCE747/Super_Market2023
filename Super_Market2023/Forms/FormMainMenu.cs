using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Super_Market2023.Forms
{
    public partial class FormMainMenu : Form
    {
        internal static string Databasecon = ConfigurationManager.ConnectionStrings["Super_market_2023ConnectionString"].ConnectionString;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //internal static string conectDB = @"Data Source=.\SQLEXPRESS;Initial Catalog=Super_market_2023;Integrated Security=True";

        
        


        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btn_closeChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        CLASSES.clc_users mcls_user = new CLASSES.clc_users();
        private void Power()
        {

            if (CLASSES.clc_users.Permissions == true)
            {
                btn_seting.Enabled = true;
            }
            else
            {
                btn_seting.Enabled = false;
            }
            
            
        }

       

        
        

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
           
            try
            {
                timer1.Interval = 1000;
                timer1.Start();

                DateTime currentTime = DateTime.Now;

                string greetingMessage = string.Empty;
                if (currentTime.Hour >= 0 && currentTime.Hour < 12)
                {
                    greetingMessage = "!صباح الخير";
                }
                else
                {
                    greetingMessage = "!مساء الخير";
                }


                lblGreeting1.Text = greetingMessage;

                label1_user1.Text = CLASSES.clc_users.user_name.ToString();


                DateTime currentDate = DateTime.Now;


                labelControlDateNow.Text = currentDate.ToString("dd MMMM yyyy");
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ أثناء تحميل الصفحة الرئيسة: " + ex.Message);
            }
            getsumtody();
            loansum();
            requestSum();
            CountProduct();
            Power();

        }
        
       
    
   
    
        private void loansum()
        {
            try
            {

                // استعلام SQL للحصول على مجموع الديون لجميع الأيام
                string connectionString = Databasecon;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SUM(inv_total) FROM invoice_tbl WHERE inv_stat = 'دين'";
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        // عرض مجموع الديون العام
                        labelControl_loanSum.Text = result.ToString();
                    }
                    else
                    {
                        labelControl_loanSum.Text = "0";
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ أثناء جلب مجموع الديون: " + ex.Message);
            }
           
 

        }
        private void getsumtody()
        {
            try
            {


                string connectionString = Databasecon;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string today = DateTime.Now.Date.ToString("yyyy-MM-dd"); 

                    string query = "SELECT SUM(inv_total) FROM invoice_tbl WHERE inv_date = @Today";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Today", today);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        
                        labelsum.Text = result.ToString();
                    }
                    else
                    {
                        labelsum.Text = "0";
                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ أثناء جلب المبيعات اليومية: " + ex.Message);
            }
        }






        private void requestSum()
        {



            try
            {
                string connectionString = Databasecon;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM invoice_tbl WHERE inv_stat = 'طلبية'";
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowCount = (int)command.ExecuteScalar();


                    labelContro_req_count.Text = rowCount.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ أثناء جلب عدد الطلبات: " + ex.Message);
            }
          
 

        }
        private void CountProduct()
        {

            try
            {
                string connectionString = Databasecon;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM pro_tbl ";
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowCount = (int)command.ExecuteScalar();


                    labelContro_pro.Text = rowCount.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ أثناء جلب عدد المنتجات: " + ex.Message);
            }
 


        }

        
    
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            btn_closeChildForm.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frm_pro_add(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frm_cat_add(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frm_sale_add(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frm_inv(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frm_cust(), sender);
        }

        private void btn_closeChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }

        private void Reset()
        {
            lblTitle.Text = "الصفحة الرئيسة";
            currentButton = null;
            btn_closeChildForm.Visible = false;
            getsumtody();
            loansum();
            requestSum();
            CountProduct();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frm_loan(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frm_req(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            frm.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            DateTime currentTime = DateTime.Now;

            
            clock1.Text = currentTime.ToString("h:mm:ss tt");
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_seting_Click(object sender, EventArgs e)
        {
            frm_setting frm = new frm_setting();
            frm.ShowDialog();
        }
          

    }
}
