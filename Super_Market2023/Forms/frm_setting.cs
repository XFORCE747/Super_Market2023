using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Super_Market2023.Forms
{
    public partial class frm_setting : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;
        private DataSet dataSet;
        private string connectionString = Forms.FormMainMenu.Databasecon;

        CLASSES.clc_users mcls_users = new CLASSES.clc_users();
        public frm_setting()
        {
            InitializeComponent();

            try
            {
               
                string connectionString = Forms.FormMainMenu.Databasecon;

               
                sqlConnection = new SqlConnection(connectionString);

                
                string query = "SELECT * FROM user_id";

               
                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                
                dataSet = new DataSet();

                
                sqlDataAdapter.Fill(dataSet, "user_id");

                
                gridControl_USERS.DataSource = dataSet.Tables["user_id"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


            
        }
        public void clear_data()
        {
            try
            {
                //gridControl_USERS.DataSource = CLASSES.clc_users.user_data.GetData();
                //gridControl_USERS.DataSource = dataSet.Tables["user_id"];
                gridView_users.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView_users.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                gridView_users.Columns.Remove(gridView_users.Columns["user_id"]);


                gridView_users.Columns["user_name"].Caption = "اسم المستخدم";
                gridView_users.Columns["user_password"].Caption = "كلمة المرور";
                gridView_users.Columns["Permissions"].Caption = "الصلاحيات";
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frm_setting_Load(object sender, EventArgs e)
        {
            clear_data();
        }

        private void btn_cat_add_Click(object sender, EventArgs e)
        {
            string userName = txt_username.Text;
            string password = txt_paswword.Text;
            int permissions = radioButton_admin.Checked ? 1 : 0; // 1 للمشرف، 0 للمستخدم العادي
            try
            {
                if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("الرجاء ملء جميع الحقول.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO user_id (user_name, user_password, Permissions) VALUES (@user_name, @user_password, @Permissions)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@user_name", userName);
                    cmd.Parameters.AddWithValue("@user_password", password);
                    cmd.Parameters.AddWithValue("@Permissions", permissions);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            BindGridView();
            ClearInputFields();
        }
        private void BindGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM user_id";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gridControl_USERS.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            //gridControl_USERS.DataSource = mcls_users.user_list2();
        }
        private void ClearInputFields()
        {
            txt_username.Text = "";
            txt_paswword.Text = "";
            radioButton_admin.Checked = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = gridView_users.FocusedRowHandle;

            int userID = Convert.ToInt32(gridView_users.GetRowCellValue(selectedRowIndex, "user_id"));



            string userName = txt_username.Text;
            string password = txt_paswword.Text;
            int permissions = radioButton_admin.Checked ? 1 : 0; // 1 للمشرف، 0 للمستخدم العادي
            try
            {
                if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("الرجاء ملء جميع الحقول.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE user_id SET user_name = @user_name, user_password = @user_password, Permissions = @Permissions WHERE user_id = @user_id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@user_name", userName);
                    cmd.Parameters.AddWithValue("@user_password", password);
                    cmd.Parameters.AddWithValue("@Permissions", permissions);
                    cmd.Parameters.AddWithValue("@user_id", userID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            BindGridView();
            ClearInputFields();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = gridView_users.FocusedRowHandle;
            int userID = Convert.ToInt32(gridView_users.GetRowCellValue(selectedRowIndex, "user_id"));
            try
            {
                // عرض رسالة تأكيد الحذف
                DialogResult result = MessageBox.Show("هل ترغب حقًا في حذف هذا السجل؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // إذا قرر المستخدم الاستمرار في الحذف
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM user_id WHERE user_id = @user_id";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@user_id", userID);
                        cmd.ExecuteNonQuery();
                    }

                    BindGridView();
                    ClearInputFields();
                }
                else
                {
                    // إذا قرر المستخدم عدم الحذف
                    // يمكنك تنفيذ أي شيء آخر هنا إذا لزم الأمر.
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void gridView_users_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridView_users_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridControl_USERS_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                var selectedRows = gridView_users.GetSelectedRows();
                if (selectedRows.Length > 0)
                {
                    var selectedRow = gridView_users.GetRow(selectedRows[0]);

                    // استخدم المعلمتين الصحيحتين في الدالة GetRowCellValue
                    txt_username.Text = (string)gridView_users.GetRowCellValue(selectedRows[0], "user_name");
                    txt_paswword.Text = (string)gridView_users.GetRowCellValue(selectedRows[0], "user_password");

                    int permissions;
                    if (int.TryParse(gridView_users.GetRowCellValue(selectedRows[0], "Permissions").ToString(), out permissions))
                    {
                        radioButton_admin.Checked = (permissions == 1);
                        
                    }
                    else
                    {
                        
                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void radioButtonLocal_CheckedChanged(object sender, EventArgs e)
        {
            setconType();
        }
        private void setconType()
        {
            if (radioButtonLocal.Checked == true)
            {
                txt_DBname.Enabled = false;
                txt_PortNum.Enabled = false;
                txtUserDB.Enabled = false;
                txtPasswordDB.Enabled = false;
            }
            else
            {
                txt_DBname.Enabled = true;
                txt_PortNum.Enabled = true;
                txtUserDB.Enabled = true;
                txtPasswordDB.Enabled = true;
            }
 

        }

        private void btn_SAVE_SETING_Click(object sender, EventArgs e)
        {
            SaveconString();
        }
        private void SaveconString() 
        {
            try
            {
                var server = txt_servername.Text;
                var dbname = txt_DBname.Text;
                var port = "," + txt_PortNum.Text;
                var user = txtUserDB.Text;
                var password = txtPasswordDB;


                if (radioButtonLocal.Checked == true)
                {
                    var conString = @"Data Source=" + server + ";Initial Catalog=" + dbname + ";Integrated Security=True";

                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    connectionStringsSection.ConnectionStrings["Super_market_2023ConnectionString"].ConnectionString = conString;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");

                    MessageBox.Show("تم تحديث الاتصال بنجاح , سيتم اعادة تشغيل البرنامج لتطبيق الاعدادات");
                    Application.Restart();
                }
                else
                {
                    var conString = @"Data Source=" + server + port + ";Initial Catalog=" + dbname + ";user id= " + user + ";password=" + password + ";connect Timeout=60;Integrated Security=True";

                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    connectionStringsSection.ConnectionStrings["Super_market_2023ConnectionString"].ConnectionString = conString;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");

                    MessageBox.Show("تم تحديث الاتصال بنجاح , سيتم اعادة تشغيل البرنامج لتطبيق الاعدادات");
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}
