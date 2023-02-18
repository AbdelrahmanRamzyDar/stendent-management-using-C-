using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JIIDBFramewor;
using Student_Management.Models.Department;
using Student_Management.Models.Users;
using Student_Management.Utilites;
using Student_Management.Utilites.Lists;

namespace Student_Management.Screens.Departmaent
{
    public partial class DepartInfo : Form
    {
        public DepartInfo()
        {
            InitializeComponent();
        }

        private void DepartInfo_Load(object sender, EventArgs e)
        {

           
            LoadDataAndBindToControlIfUpdata();
        }

       

        private void LoadDataAndBindToControlIfUpdata()
        {
            if(this.isupdate) {

                DbSQLServer db = new DbSQLServer(AppSetting.connectionString());

                DbParameter para = new DbParameter();
                para.parameter = "@DepartId";
                para.value =this. DepartId;
                DataTable dtDepart = db.GetDataList("usp_DepartmentsGetDepartmentDetailByDepartId", new DbParameter {parameter="@DepartId",value=this.DepartId });
                DataRow row = dtDepart.Rows[0];



                studentnametextBox.Text=row["StudentName"].ToString();
                DepartmentNametextBox.Text = row["DepatmentName"].ToString();
                EmailAddresstextBox.Text = row["Email"].ToString();
                TelephonetextBox.Text = row["Telephone"].ToString();
                WebsitetextBox.Text = row["Website"].ToString();
                 logopictureBox.Image = (row["StudentImage"] is DBNull) ? null :
                  Imageman.PutPhoto((byte[])row["StudentImage"]);
                AddresstextBox.Text = row["Address"].ToString();
                            }
        }

        public int DepartId { get; set; }
        public bool isupdate { get; internal set; }

        private void DepartmentNametextBox_TextChanged(object sender, EventArgs e)
        {
            TopPanelLabel.Text = DepartmentNametextBox.Text;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logopictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select logo";
            op.Filter="Logo File(*.png;*.jpg;*.gif;*.bmp;)| *.png; *.jpg; *.gif; *.bmp;";
           if( op.ShowDialog()== DialogResult.OK)
           {
            logopictureBox.Image = new Bitmap(op.FileName);
        } 
        }

        private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
        if (IsFormValidated()){
            if (this.isupdate)
            {

                UpdateRecord();
                MessageBox.Show("Record is update sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                saveRecord();
                MessageBox.Show("Record is added sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

 }

        }

        private void saveRecord()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.connectionString());
            db.SaveOrUpdateRecord("usp_DepartmentsAddNewDepartment", GetObject());
        }

        private Department GetObject()
        {
            Department department = new Department();
            department.DepartId = (this.isupdate) ? this.DepartId : 0;
            department.StudentName = studentnametextBox.Text;
            department.DepatmentName = DepartmentNametextBox.Text;
            department.Email = EmailAddresstextBox.Text;
            department.Website = WebsitetextBox.Text;
            department.Address = AddresstextBox.Text;
            department.Telephone = TelephonetextBox.Text;
            department.StudentImage = Imageman.GetPhoto(logopictureBox);
            
            return department;
        }

        private void UpdateRecord()
        {

            DbSQLServer db = new DbSQLServer(AppSetting.connectionString());
            db.SaveOrUpdateRecord("usp_DepartmentsUpdateDepartmentDetail", GetObject());
        }

        private bool IsFormValidated()
        {
           if(DepartmentNametextBox.Text.Trim()==string.Empty) {


                MessageBox.Show("Department is Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DepartmentNametextBox.Focus();
                return false;
            }

            if (EmailAddresstextBox.Text.Trim() == string.Empty)
            {


                MessageBox.Show("Email is Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DepartmentNametextBox.Focus();
                return false;
            }
            if (TelephonetextBox.Text.Trim() == string.Empty)
            {


                MessageBox.Show("Telephone is Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DepartmentNametextBox.Focus();
                return false;
            }
            return true;
        }
    }
    }

