using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Super_Market2023.DataSetTableAdapters;
using System.Data;

namespace Super_Market2023.CLASSES
{
    class cls_loan
    {
        public static int loan_id;
        public static string loan_date;
        public static string loan_time;
        public static string loan_cust_anme;
        public static string loan_cust_phon;
        public static string loan_cust_addres;
        public static string loan_name_pro;
        public static int inv_id;


        public static loan_tblTableAdapter loan_data = new loan_tblTableAdapter();


        public DataTable select_loan(string s_cust, string s_pro) 
        {
            DataTable dt = new DataTable();
            dt = loan_data.select_loan_by_pro_by_cust(s_cust, s_pro);

            if (dt.Rows.Count>0)

            {
                loan_id= Convert.ToInt32( dt.Rows[0][0].ToString());
                loan_date= dt.Rows[0][1].ToString();
                loan_time=dt.Rows[0][2].ToString();
                loan_name_pro=dt.Rows[0][3].ToString();
                inv_id = Convert.ToInt32( dt.Rows[0][4].ToString());




            }
            return dt;
        }
        public DataTable serach_loan(string s_cust)
        {
            DataTable dt = new DataTable();
            dt = loan_data.loan_cearch(s_cust);

            if (dt.Rows.Count > 0)
            {
                loan_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                loan_date = dt.Rows[0][1].ToString();
                loan_time = dt.Rows[0][2].ToString();
                loan_name_pro = dt.Rows[0][3].ToString();
                inv_id = Convert.ToInt32(dt.Rows[0][4].ToString());




            }
            return dt;
        }


      
    }
}
