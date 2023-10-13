using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Super_Market2023.DataSetTableAdapters;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Super_Market2023.CLASSES
{
    class clc_users
    {
        public static int user_id;
        public static string user_name;
        public static string user_password;
        public static bool Permissions;


        public static user_idTableAdapter user_data = new user_idTableAdapter();

        

        public DataTable user_list(string s_user_name, string s_user_pas)
        {
            DataTable dt = new DataTable();
            dt = user_data.select_data_by_login(s_user_name, s_user_pas);
            if (dt.Rows.Count > 0)
            {
                user_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                user_name = dt.Rows[0][1].ToString();
                user_password = dt.Rows[0][2].ToString();
                Permissions = Convert.ToBoolean(dt.Rows[0][3]);
            }
            return dt;
        }
        
       
    }
}
