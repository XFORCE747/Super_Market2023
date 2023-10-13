using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Super_Market2023.DataSetTableAdapters;


namespace Super_Market2023.CLASSES
{
    class cls_sales
    {
        public static int sal_id;
        public static string sal_s_stat;
        public static string sal_push_stat;
        public static decimal sal_price;
        public static decimal sal_quantity;
        public static string sal_date;
        public static string sal_time;
        public static string sal_addes;
        public static int pro_id;
        public static int cust_id;
        public static int sal_list_id;

        public static sales_tblTableAdapter sal_data = new sales_tblTableAdapter();

        public DataTable datalist(string s_pro_name)
        {
            DataTable dt = new DataTable();
            dt = sal_data.select_data(s_pro_name);
            if (dt.Rows.Count > 0)
            {
                sal_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                sal_s_stat = dt.Rows[0][1].ToString();
                sal_push_stat = dt.Rows[0][2].ToString(); 
                sal_price = Convert.ToDecimal(dt.Rows[0][3].ToString());
                sal_quantity = Convert.ToDecimal(dt.Rows[0][4].ToString());
                pro_id = Convert.ToInt32(dt.Rows[0][5].ToString());
                cust_id = Convert.ToInt32(dt.Rows[0][6].ToString());
                sal_list_id = Convert.ToInt32(dt.Rows[0][7].ToString());
 
            }
            return dt;
        }

    }
}
