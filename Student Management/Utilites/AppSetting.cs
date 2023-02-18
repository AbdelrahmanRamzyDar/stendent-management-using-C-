using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.Utilites
{
     public class AppSetting
    {

        public static string connectionString() {

            return ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        }






    }
}
