using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management.Screens.Departmaent;
using Student_Management.Screens.Templates;
using Student_Management.Utilites.Lists;

namespace Student_Management.Screens.Branches
{
    public partial class manageDepartForm : TemplateForm
    {
        public manageDepartForm()
        {
            InitializeComponent();
        }

        private void DepartForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            ListData.LoadDataIntoDataGridView(DepatmentsdataGridView, "usp_DepartmentsGetAllDepartments");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowDepartInfoScreen(0, false);
        }

        private void ShowDepartInfoScreen(int departId, bool isUpdate)
        {
            DepartInfo di = new DepartInfo();
            di.DepartId = departId;
            di.isupdate = isUpdate;

            di.ShowDialog();
            LoadDataIntoDataGridView();

        }

       

        private void DepatmentsdataGridView_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void DepatmentsdataGridView_DoubleClick_1(object sender, EventArgs e)
        {
 int rowIndex = DepatmentsdataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int departId = Convert.ToInt32(DepatmentsdataGridView.Rows[rowIndex].Cells["DepartId"].Value);
            ShowDepartInfoScreen(departId, true);
        }
    }
}
