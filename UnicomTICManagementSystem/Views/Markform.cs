using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
    public partial class Markform : Form
    {
        private MarkController controller;
        private string selectedMark = null;
        public Markform()
        {
            InitializeComponent();
        }

        private void Markform_Load(object sender, EventArgs e)
        {
            controller = new MarkController();
            LoadMarks();
            markgridview.SelectionChanged += markgridview_SelectionChanged;
        }

        private void LoadMarks()
        {
            List<Marks> marks = controller.GetAllMarks();
            markgridview.DataSource = marks;
            markgridview.ClearSelection();
            ClearInputs();
            selectedMark = null;
        }

        private void ClearInputs()
        {
            extytxxt.Text = "";
            mastnametxt.Text = "";
            marktxt.Text = "";
            gradetxt.Text = "";
        }

        private void markgridview_SelectionChanged(object sender, EventArgs e)
        {
            if (markgridview.SelectedRows.Count > 0)
            {
                var row = markgridview.SelectedRows[0];
                Marks selectedMarks = (Marks)row.DataBoundItem;

                marktxt.Text = selectedMarks.ToString();
                mastnametxt.Text = selectedMarks.Student_Name;
                extytxxt.Text = selectedMarks.Exam_type;
                //gradetxt.Text = selectedMarks.Grade;

                selectedMark = selectedMarks.Exam_type;
            }
        }
        private void backbtn_Click(object sender, EventArgs e)
        {

        }

        private void markgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void marupdatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMark))

            {
                MessageBox.Show("Please select a Student to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(mastnametxt.Text) || string.IsNullOrWhiteSpace(marktxt.Text))
            {
                MessageBox.Show("Please enter both Marks and Grade.");
                return;
            }

            Marks marks = new Marks
            {

                Student_Name = mastnametxt.Text,
                Exam_type = extytxxt.Text,
                // Marks = marktxt.Text,
            };

            controller.UpdateMarks(marks);
            MessageBox.Show("Marks Updated Successfully");
            LoadMarks();
        }

        private void maraddbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mastnametxt.Text) || string.IsNullOrWhiteSpace(extytxxt.Text))
            {
                MessageBox.Show("Please enter both Marks and Grade.");
                return;
            }

            Marks marks = new Marks
            {

                Student_Name = mastnametxt.Text,
                Exam_type = extytxxt.Text
            };

            controller.AddMarks(marks);
            MessageBox.Show("Marks Added Successfully");
            LoadMarks();
        }

        private void madeletebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMark))
            {
                MessageBox.Show("Please select a Student Marks to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this Student Marks?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // controller.DeleteMarks(int.Parse(selectedMark));
                MessageBox.Show("Marks Deleted Successfully");
                LoadMarks();
            }
        }
    }
}
