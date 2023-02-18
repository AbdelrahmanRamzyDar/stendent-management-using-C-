using Student_Management.Screens.Templates;
using Student_Management.Utilites.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.Screens.employee
{
    public partial class manageemployeeForm : TemplateForm
    {
        public manageemployeeForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowemployeeinfoFormScreen(0, false);

        }

        private void ShowemployeeinfoFormScreen(int employeeid, bool isupdate)
        {
            employeeinfoForm di = new employeeinfoForm();
            di.Employeeid = employeeid;
            di.isUpdate = isupdate;

            di.ShowDialog();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            ListData.LoadDataIntoDataGridView(employeedataGridView, "usp_EmployeesGetEmployees");
        }

        private void DepatmentsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = employeedataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int employeeID = Convert.ToInt32(employeedataGridView.Rows[rowIndex].Cells["employeeid"].Value);
            ShowemployeeinfoFormScreen(employeeID, true);
        }

        private void manageemployeeForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();

        }
    }
}
