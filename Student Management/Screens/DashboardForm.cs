using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management.Screens.Branches;
using Student_Management.Screens.Templates;
using Student_Management.Screens.Departmaent;
using Student_Management.Screens.help;
using Student_Management.Screens.employee;
using Student_Management.Screens.system;

namespace Student_Management.Screens
{
    public partial class DashboardForm : TemplateForm
    {

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageDeptoolStripButton1_Click(object sender, EventArgs e)
        {
            manageDepartForm md = new manageDepartForm();
            md.ShowDialog();
        }

        private void NewStudenttoolStripButton1_Click(object sender, EventArgs e)
        {
            DepartInfo di = new DepartInfo();
           
            di.ShowDialog();
            
        }

        private void EditProfiletoolStripButton7_Click(object sender, EventArgs e)
        {
            manageDepartForm md = new manageDepartForm();
            md.ShowDialog();
        }

        private void HelptoolStripButton2_Click(object sender, EventArgs e)
        {
            helpform  h = new helpform();
            h.ShowDialog();
        }

        private void ReportstoolStripButton9_Click(object sender, EventArgs e)
        {
            employeeinfoForm ef =new employeeinfoForm();
            ef.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            manageemployeeForm mf =new manageemployeeForm();
            mf.ShowDialog();
        }

        private void SystemtoolStripButton10_Click(object sender, EventArgs e)
        {
             systemForm sf =new systemForm();
            sf.ShowDialog();
        }
    }
}
