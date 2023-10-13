using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Super_Market2023.DataSetTableAdapters;
using System.Data;

namespace Super_Market2023.CLASSES
{
    class cls_sa_list
    {
        public static int sal_list_id;
        public static string sal_list_date;
        public static string sal_list_time;
        public static int cust_id;
        public static int pro_id;
        public static decimal sal_list_price;
        public static decimal sal_list_quantity;


        public static sal_list_tblTableAdapter sal_list_data = new sal_list_tblTableAdapter();



        public DataTable select_data()
        {
            DataTable dt = new DataTable();
            dt= sal_list_data.GetData();
            if (dt.Rows.Count > 0)
            {

                sal_list_id = Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0].ToString());
                sal_list_date= dt.Rows[dt.Rows.Count-1][1].ToString();
                sal_list_time= dt.Rows[dt.Rows.Count-1][2].ToString();
                sal_list_price= Convert.ToDecimal(dt.Rows[dt.Rows.Count-1][3].ToString());
                sal_list_quantity = Convert.ToDecimal(dt.Rows[dt.Rows.Count - 1][4].ToString());
                cust_id= Convert.ToInt32(dt.Rows[dt.Rows.Count-1][5].ToString());
                pro_id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][6].ToString());




            }
            return dt;
            
                
        }
        public DataTable data_list(string s_pro_name)
        {
            DataTable dt = new DataTable();
            dt = sal_list_data.select_id_sal_list(s_pro_name);
            if (dt.Rows.Count > 0)
            {

                sal_list_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                sal_list_date = dt.Rows[0][1].ToString();
                sal_list_time = dt.Rows[0][2].ToString();
                //sal_list_price = Convert.ToDecimal(dt.Rows[0][3].ToString());
                //sal_list_quantity = Convert.ToDecimal(dt.Rows[0][4].ToString());
                //cust_id = Convert.ToInt32(dt.Rows[0][5].ToString());
                //pro_id = Convert.ToInt32(dt.Rows[0][6].ToString());




            }
            return dt;


        }


    }
}
