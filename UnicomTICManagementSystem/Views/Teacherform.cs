using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
namespace UnicomTICManagementSystem.Views
{
    public partial class Teacherform : Form
    {
        private TeacherController controller;
        private string selectedTeacherId = null;

        public Teacherform()
        {
            InitializeComponent();
            controller = new TeacherController();
            LoadTeachers();
            tedataGridView.SelectionChanged += tedataGridView_SelectionChanged;
        }

        private void LoadTeachers()
        {
            List<Teacher> teachers = controller.GetAllTeacher();
            tedataGridView.DataSource = teachers;
            tedataGridView.ClearSelection();
            ClearInputs();
            selectedTeacherId = null;
        }

        private void ClearInputs()
        {
            teidtxt.Text = "";
            tenametxt.Text = "";
            tenictxt.Text = "";
        }

        private void tedataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (tedataGridView.SelectedRows.Count > 0)
            {
                var row = tedataGridView.SelectedRows[0];
                Teacher selectedTeacher = (Teacher)row.DataBoundItem;

                teidtxt.Text = selectedTeacher.Id.ToString();
                tenametxt.Text = selectedTeacher.Name;
                tenictxt.Text = selectedTeacher.NIC_Number;

                selectedTeacherId = selectedTeacher.Id;
            }
        }
        private void Teacherform_Load(object sender, EventArgs e)
        {

        }









        private void teupdatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTeacherId))
            {
                MessageBox.Show("Please select a Teacher to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tenametxt.Text) || string.IsNullOrWhiteSpace(tenictxt.Text))
            {
                MessageBox.Show("Please enter both Name and NIC Number.");
                return;
            }

            Teacher teacher = new Teacher
            {
                Id = teidtxt.Text,
                Name = tenametxt.Text,
                NIC_Number = tenictxt.Text
            };

            controller.UpdateTeacher(teacher);
            MessageBox.Show("Teacher Updated Successfully");
            LoadTeachers();
        }

        private void tecoursebtn_Click(object sender, EventArgs e)
        {
            Courseform courseform = new Courseform();
            courseform.Show();
            this.Hide();
        }

        private void tetimebtn_Click(object sender, EventArgs e)
        {
            Timetableform timetableform = new Timetableform();
            timetableform.Show();
            this.Hide();
        }

        private void teexambtn_Click(object sender, EventArgs e)
        {
            Examform examform = new Examform();
            examform.Show();
            this.Hide();
        }

        private void temarkbtn_Click(object sender, EventArgs e)
        {
            Markform markform = new Markform();
            markform.Show();
            this.Hide();
        }

        private void teaddbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tenametxt.Text) || string.IsNullOrWhiteSpace(tenictxt.Text))
            {
                MessageBox.Show("Please enter both Name and NIC Number.");
                return;
            }

            Teacher teacher = new Teacher
            {
                Id = teidtxt.Text,
                Name = tenametxt.Text,
                NIC_Number = tenictxt.Text
            };

            controller.AddTeacher(teacher);
            MessageBox.Show("Teacher Added Successfully");
            LoadTeachers();
        }

        private void tedetetebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTeacherId))
            {
                MessageBox.Show("Please select a Teacher to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this Teacher?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                controller.DeleteTeacher(int.Parse(selectedTeacherId));
                MessageBox.Show("Teacher Deleted Successfully");
                LoadTeachers();
            }
        }
    }
}
