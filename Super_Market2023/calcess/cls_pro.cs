using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Super_Market2023.DataSetTableAdapters;
using System.Data;

namespace Super_Market2023.CLASSES
{
    class cls_pro
    {
        public static int pro_id;
        public static string pro_name;
        public static double pro_price;
        public static int pro_quantity;
        public static string pro_company;
        public static int cat_id;

        public static pro_tblTableAdapter data = new pro_tblTableAdapter();

        public DataTable datalist(string s_pro_name)
        {
            DataTable dt = new DataTable();
            dt = data.select_pro_by_name(s_pro_name);
            if (dt.Rows.Count>0)
            {
             pro_id = Convert.ToInt32(dt.Rows[0][0].ToString());
             pro_name = dt.Rows[0][1].ToString();
             pro_price = Convert.ToDouble (dt.Rows[0][2].ToString());
             pro_quantity = Convert.ToInt32 (dt.Rows[0][3].ToString());
             pro_company = dt.Rows[0][4].ToString();
             cat_id = Convert.ToInt32 (dt.Rows[0][5].ToString());
            }
            return dt;
        }
        
    }
}
