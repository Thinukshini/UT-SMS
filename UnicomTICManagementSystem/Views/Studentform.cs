using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class Studentform : Form
    {
        private StudentController controller;
        private string selectedStudentID = null;

        public Studentform()
        {
            InitializeComponent();
            controller = new StudentController();
            LoadStudents();

            DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void LoadStudents()
        {
            List<Student> students = controller.GetAllStudents();
            DataGridView1.DataSource = students;
            DataGridView1.ClearSelection();
            ClearInputs();
            selectedStudentID = null;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(stnametxt.Text) || string.IsNullOrWhiteSpace(nicNumtxt.Text))
            {
                MessageBox.Show("Please enter both Name and NIC Number.");
                return;
            }

            Student student = new Student
            {
                Id = stIDtxt.Text,
                Name = stnametxt.Text,
                NIC_Number = nicNumtxt.Text
            };

            controller.AddStudent(student);
            MessageBox.Show("Student Added Successfully");
            LoadStudents();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            //if (selectedStudentID == -1)
            if (string.IsNullOrEmpty(selectedStudentID))
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(stnametxt.Text) || string.IsNullOrWhiteSpace(nicNumtxt.Text))
            {
                MessageBox.Show("Please enter both Name and NIC Number.");
                return;
            }

            Student student = new Student
            {
                Id = stIDtxt.Text,
                Name = stnametxt.Text,
                NIC_Number = nicNumtxt.Text
            };

            controller.UpdateStudent(student);
            MessageBox.Show("Student Updated Successfully");
            LoadStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (selectedStudentID == -1)
            if (string.IsNullOrEmpty(selectedStudentID))
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                controller.DeleteStudent(selectedStudentID);
                MessageBox.Show("Student Deleted Successfully");
                LoadStudents();
            }
        }

        private void ClearInputs()
        {
            stIDtxt.Text = "";
            stnametxt.Text = "";
            nicNumtxt.Text = "";
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                var row = DataGridView1.SelectedRows[0];
                Student selectedStudent = (Student)row.DataBoundItem;

              //  if (student != null)
                
                   //if (int.TryParse(student.Id, out int id))
                    
                       // selectedStudentID = student.id;
                 stIDtxt.Text = selectedStudent.Id.ToString();
                 stnametxt.Text = selectedStudent.Name;
                 nicNumtxt.Text = selectedStudent.NIC_Number;

                 selectedStudentID = selectedStudent.Id;
                    
                
            }
            else
            {
                ClearInputs();
                selectedStudentID = "";
            }
        }

        private void coursebtn_Click(object sender, EventArgs e)
        {
            Courseform courseform = new Courseform();
            courseform.Show();
            this.Hide();
        }

        private void titabtn_Click(object sender, EventArgs e)
        {
            Timetableform timetableform = new Timetableform();
            timetableform.Show();
            this.Hide();
        }

        private void marksbtn_Click(object sender, EventArgs e)
        {
            Markform markform = new Markform();
            markform.Show();
            this.Hide();
        }

        private void exambtn_Click(object sender, EventArgs e)
        {
            Examform examform = new Examform();
            examform.Show();
            this.Hide();
        }
    }
}
