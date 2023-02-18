using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JIIDBFramewor;

namespace Student_Management.Utilites.Lists
{
   public  class ListData
    {

        public static void LoadDataIntoDataGridView(DataGridView dgv, string storedProceName)
         {
            DbSQLServer db = new DbSQLServer(AppSetting.connectionString());

            dgv.DataSource = db.GetDataList(storedProceName);
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
        
         }

     


    }
}
