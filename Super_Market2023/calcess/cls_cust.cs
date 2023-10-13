using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Super_Market2023.DataSetTableAdapters;

namespace Super_Market2023.CLASSES
{
    class cls_cust
    {
        public static int cust_id;
        public static string cust_name;
        public static string cust_phon;
        public static string cust_address;

        public static cust_tblTableAdapter cust_data = new cust_tblTableAdapter();

        public DataTable cust_list()
        {
            DataTable dt = new DataTable();
            dt = cust_data.GetData();
            if (dt.Rows.Count>0)
            {
                cust_id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString());
                cust_name = dt.Rows[dt.Rows.Count-1][1].ToString();
                cust_phon = dt.Rows[dt.Rows.Count - 1][2].ToString();
                cust_address = dt.Rows[dt.Rows.Count - 1][3].ToString();
            }
            return dt;
        }
        public DataTable cust_list_by_name_ph_app(string s_cust_name, string s_cust_phone, string s_cust_add)
        {
            DataTable dt = new DataTable();
            dt = cust_data.select_cust_by_name_and_add(s_cust_name, s_cust_phone, s_cust_add);
            if (dt.Rows.Count > 0)
            {
                cust_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                cust_name = dt.Rows[0][1].ToString();
                cust_phon = dt.Rows[0][2].ToString();
                cust_address = dt.Rows[0][3].ToString();
            }
            return dt;
        }
    }
}
