using JIIDBFramewor;
using Student_Management.Models.employee;
using Student_Management.Screens.Templates;
using Student_Management.Utilites;
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
    public partial class employeeinfoForm : TemplateForm
    {
        public employeeinfoForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void labelToppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void departid_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeinfoForm_Load(object sender, EventArgs e)
        {

            LoadDataAndBindToControlIfUpdata();


        }

        private void LoadDataAndBindToControlIfUpdata()
        {
            if (this.isUpdate)
            {

                DbSQLServer db = new DbSQLServer(AppSetting.connectionString());

                DbParameter para = new DbParameter();
                para.parameter = "@employeeid";
                para.value = this.Employeeid;
                DataTable dtEmployee = db.GetDataList("usp_EmployeesGetEmployeeDetailsById", new DbParameter { parameter = "@employeeid", value = this.Employeeid });
                DataRow row = dtEmployee.Rows[0];


              
                fullname.Text = row["fullname"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row["dataofbirth"]);
                email.Text = row["email"].ToString();
                mobile.Text = row["mobile"].ToString();
                comboBox1.SelectedValue = row["DepartId"];
                logopictureBox.Image = (row["photo"] is DBNull) ? null :
                 Imageman.PutPhoto((byte[])row["photo"]);
            }




        }


        public int Employeeid { get; set; }
        public bool isUpdate { get; internal set; }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (IsFormValidated())
            {
                if (this.isUpdate)
                {

                    UpdateRecord();
                    MessageBox.Show("Record is update sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    saveRecord();
                    MessageBox.Show("Record is added sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }




        }


        private void saveRecord()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.connectionString());
            db.SaveOrUpdateRecord("usp_EmployeesAddNewEmployee", GetObject());
        }

        private Employee GetObject()
        {
            Employee department = new Employee();
            department.employeeid = (this.isUpdate) ? this.Employeeid : 0;
            department.fullname = fullname.Text;
            department.dataofbirth = dateTimePicker1.Value.Date ;
            department.email = email.Text;
            department.mobile = mobile.Text;
            department.DepartId = (comboBox1.SelectedIndex == -1) ? 0 : Convert.ToInt32 ( comboBox1.SelectedValue);

            department.photo = Imageman.GetPhoto(logopictureBox);

            return department;
        }

        private void UpdateRecord()
        {

            DbSQLServer db = new DbSQLServer(AppSetting.connectionString());
            db.SaveOrUpdateRecord("usp_EmployeesUpdateEmployeeDetails", GetObject());
        }


        private bool IsFormValidated()
        {
            if (fullname.Text.Trim() == string.Empty)
            {


                MessageBox.Show("Name is Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fullname.Focus();
                return false;
            }

            if (email.Text.Trim() == string.Empty)
            {


                MessageBox.Show("Email is Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.Focus();
                return false;
            }
            if (mobile.Text.Trim() == string.Empty)
            {


                MessageBox.Show("Telephone is Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mobile.Focus();
                return false;
            }
            return true;
        }





        private void logopictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select logo";
            op.Filter = "Logo File(*.png;*.jpg;*.gif;*.bmp;)| *.png; *.jpg; *.gif; *.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                logopictureBox.Image = new Bitmap(op.FileName);
            }
        }

        private void labelToppanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void fullname_TextChanged(object sender, EventArgs e)
        {
            TopPanelLabel.Text = fullname.Text;
        }

        private void TopPanelLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
