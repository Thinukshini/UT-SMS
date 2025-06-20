using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UnicomTICManagementSystem.Models.Users;

namespace UnicomTICManagementSystem.Views
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Admin", "Staff", "Student", "Teacher" });
            comboBox1.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = UserName.Text.Trim();
            string password = Password.Text.Trim();
            string userType = comboBox1.SelectedItem?.ToString();

            
            Dictionary<string, (string user, string pass)> credentials = new Dictionary<string, (string, string)>()
        {
             { "Admin", ("Admin", "admin007") },
             { "Staff", ("Staff", "staff007") },
             { "Student",("Student", "student007") },
             { "Teacher",("Teacher", "teacher007") }
        };

            if (credentials.ContainsKey(userType))
            {
                var (validUsername, validPassword) = credentials[userType];

                if (username == validUsername && password == validPassword)
                {
                    MessageBox.Show($"{userType} Login Successfully.");

                    
                    if (userType == "Admin")
                    {
                        Adminview adminview = new Adminview();
                        adminview.SetAddButtonVisibility(true);
                       
                        adminview.Show();
                       // Adminview adminview = new Adminview();
                       // adminview.Show();
                    }
                    else if (userType == "Staff")
                    {
                        Staffform staffform = new Staffform();  
                        staffform.Show();
                    }
                    else if (userType == "Student")
                    {
                        Studentform studentform = new Studentform();  
                        studentform.Show();
                    }
                    else if (userType == "Teacher")
                    {
                        Teacherform teachers = new Teacherform();  
                        teachers.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserName.Clear();
                    Password.Clear();
                    UserName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user type.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
          
            
        }
    }
}

