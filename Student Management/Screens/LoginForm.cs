using Student_Management.Screens.Templates;
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
using Student_Management.Utilites;
using Student_Management.Models.Users;

namespace Student_Management.Screens
{
    public partial class LoginForm : TemplateForm
    {
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        if(IsFormValid()) {


                DbSQLServer db = new DbSQLServer(AppSetting.connectionString());

                bool isLoginDetailsCorrect = Convert.ToBoolean(db.GetScalarValue("usp_UsersCheckLoginDetails", GetParameters()));
                DashboardForm df = new DashboardForm();
                df.Show();
                this.Hide();
                if (isLoginDetailsCorrect) {


                    GetLoggedInUserSettings();


                    this.Hide();
            DashboardForm d = new DashboardForm();
            d.Show();
                         }
                                            }
                                            else {

                MessageBox.Show("User name / Password is not  Correct ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void GetLoggedInUserSettings()
        {
            LoggedInUser.UserName = textBox1.Text.Trim();
        }



        private DbParameter[] GetParameters()

        {
            List<DbParameter> parameters = new List<DbParameter>();
            DbParameter Dbparam1 = new DbParameter();
            Dbparam1.parameter = "@UserName";
            Dbparam1.value = textBox1.Text;
            parameters.Add(Dbparam1);

            DbParameter Dbparam2 = new DbParameter();
            Dbparam1.parameter = "@Password";
            Dbparam1.value = textBox2.Text;
            parameters.Add(Dbparam2);



            return parameters.ToArray();
  
        }

        private bool IsFormValid()
        {
          
            if(textBox1.Text.Trim()== string.Empty) {
                MessageBox.Show("User name is required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();

                return false;

            }
            if (textBox2.Text.Trim() == string.Empty)
            {
             MessageBox.Show("Password is required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();

                return false;

            }




            return true;
        }
    }
}
