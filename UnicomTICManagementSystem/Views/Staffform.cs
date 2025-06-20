using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Views
{
    public partial class Staffform : Form
    {
        private StaffController controller;
        private string selectedStaffID = null;

        public Staffform()
        {
            InitializeComponent();
            controller = new StaffController();
            LoadStaffs();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
           
        }

        private void LoadStaffs()
        {
            List<Staff> staffs = controller.GetAllStaff();
            dataGridView1.DataSource = staffs;
            dataGridView1.ClearSelection();
            ClearInputs();
            selectedStaffID = null;

            add2btn.Visible = false;
            update2btn.Visible = false;
            delete2btn.Visible = false;
        }

        private void ClearInputs()
        {
            staidtxt.Text = "";
            stanametxt.Text = "";
            stanictxt.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                

                Staff selectedStaff = (Staff)row.DataBoundItem;

                staidtxt.Text = selectedStaff.ID.ToString();
                stanametxt.Text = selectedStaff.Name;
                stanictxt.Text = selectedStaff.NIC_Number;

                selectedStaffID = selectedStaff.ID;
            }
        }

        private void add2btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(stanametxt.Text) || string.IsNullOrWhiteSpace(stanictxt.Text))
            {
                MessageBox.Show("Please enter both Name and NIC Number.");
                return;
            }

            Staff staff = new Staff
            {
                ID = staidtxt.Text,
                Name = stanametxt.Text,
                NIC_Number = stanictxt.Text
            };

            controller.AddStaff(staff);
            MessageBox.Show("Staff Added Successfully");
            LoadStaffs();

            
            
        }

        private void update2btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedStaffID))
            {
                MessageBox.Show("Please select a staff to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(stanametxt.Text) || string.IsNullOrWhiteSpace(stanictxt.Text))
            {
                MessageBox.Show("Please enter both Name and NIC Number.");
                return;
            }

            Staff staff = new Staff
            {
                ID = staidtxt.Text,
                Name = stanametxt.Text,
                NIC_Number = stanictxt.Text
            };

            controller.UpdateStaff(staff);
            MessageBox.Show("Staff Updated Successfully");
            LoadStaffs();
        }

        private void delete2btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedStaffID))
            {
                MessageBox.Show("Please select a staff to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this staff?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                controller.DeleteStaff(int.Parse(selectedStaffID));
                MessageBox.Show("Staff Deleted Successfully");
                LoadStaffs();
            }
        }

        private void Staffform_Load(object sender, EventArgs e)
        {



        }

        private void course2btn_Click(object sender, EventArgs e)
        {
            Courseform courseform = new Courseform();
            courseform.Show();
            this.Hide();
        }

        private void timta2btn_Click(object sender, EventArgs e)
        {

            Timetableform timetableform = new Timetableform();
            timetableform.Show();
            this.Hide();
        }

        private void exam2btn_Click(object sender, EventArgs e)
        {
            Examform examform = new Examform();
            examform.Show();
            this.Hide();
        }

        private void mark2btn_Click(object sender, EventArgs e)
        {
            Markform markform = new Markform();
            markform.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
