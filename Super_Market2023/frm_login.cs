using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Super_Market2023.DataSetTableAdapters;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Super_Market2023
{
    public partial class frm_login : DevExpress.XtraEditors.XtraForm
    {
        public frm_login()
        {
            InitializeComponent();
        }

        CLASSES.clc_users mcls_user = new CLASSES.clc_users();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // قم بتنفيذ استعلام SQL لفحص جدول المستخدمين
                string connectionString = Forms.FormMainMenu.Databasecon;
                string query = "SELECT COUNT(*) FROM user_id"; // قم بتعديل الاستعلام والجدول حسب احتياجاتك

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();

                    if (userCount == 0)
                    {
                        // جدول المستخدمين فارغ، قم بفتح النموذج المعين
                        Forms.frm_setting frm = new Forms.frm_setting();
                        MessageBox.Show("مرحبا بك يرجى اضافة اسم مستخدم جديد وكلمة مرور ");
                        frm.ShowDialog();
                        
                    }
                    else
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
           
            


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                mcls_user.user_list(txt_user_name.Text, txt_pasword.Text);

                if (txt_user_name.Text == CLASSES.clc_users.user_name && txt_pasword.Text == CLASSES.clc_users.user_password)
                {

                    lodingProgress frm = new lodingProgress();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("Logged in successfully");
                    MessageBox.Show("خطا في بيانات تسجيل الدخول ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void txt_user_name_Click(object sender, EventArgs e)
        {
            txt_user_name.Clear();
        }

        private void txt_pasword_Click(object sender, EventArgs e)
        {

            txt_pasword.Clear();
            

        }

        private void btn_closeChildForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_pasword_TextChanged(object sender, EventArgs e)
        {
            txt_pasword.PasswordChar = '*';
        }
    }
}
