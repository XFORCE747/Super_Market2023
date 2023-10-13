using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Super_Market2023.DataSetTableAdapters;
using System.Data.SqlClient;


namespace Super_Market2023.CLASSES
{
    class cls_inv
    {
        public static int inv_id;
        public static string inv_date;
        public static string inv_time;
        public static decimal inv_total;
        public static string inv_stat;
        public static string inv_pro_name;
        public static int cust_id;

        public static invoice_tblTableAdapter inv_data = new invoice_tblTableAdapter();

        public DataTable selct_inv_end()
        {

            DataTable dt = new DataTable();
            dt = inv_data.GetData();
            if (dt.Rows.Count>0)
            {

            inv_id=Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0].ToString());
            inv_date=dt.Rows[dt.Rows.Count-1][1].ToString();
            inv_time=dt.Rows[dt.Rows.Count-1][2].ToString();
            inv_total = Convert.ToDecimal(dt.Rows[dt.Rows.Count - 1][3].ToString());
            inv_stat = dt.Rows[dt.Rows.Count - 1][4].ToString();
            inv_pro_name = dt.Rows[dt.Rows.Count - 1][5].ToString();
            cust_id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][6].ToString());

                
            }
            return dt;


            

        }
       
        
    }
}
