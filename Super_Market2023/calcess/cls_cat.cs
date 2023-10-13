using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Super_Market2023.DataSetTableAdapters;
using System.Data;

namespace Super_Market2023.CLASSES
{
    class cls_cat
    {
        public static int cat_id;
        public static string cat_name;
        public static string cat_description;  
                                     
        public static cat_tblTableAdapter CAT_DATA = new cat_tblTableAdapter();


        public DataTable data_list(string s_cat_name)
        {

            DataTable dt = new DataTable();
            dt = CAT_DATA.select_data_by_name(s_cat_name);
            if (dt.Rows.Count > 0)
            {
                cat_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                cat_name = dt.Rows[0][1].ToString();
                cat_description = dt.Rows[0][2].ToString();
            }
            return dt;
        }
       
    }
}
