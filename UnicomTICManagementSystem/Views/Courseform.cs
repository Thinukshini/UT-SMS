using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class Courseform : Form
    {
        public Courseform()
        {
            InitializeComponent();
        }

        private void Courseform_Load(object sender, EventArgs e)
        {
            coursecombobox.Items.AddRange(new string[] { "Python", "C#", "C++", "Java", "HTML", "CSS", "Web Development" });
            coursecombobox.SelectedIndex = 0;
        }

        private void coursecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectcombobox.Items.Clear();

            switch (coursecombobox.SelectedItem.ToString())
            {
                case "Python":
                    subjectcombobox.Items.AddRange(new string[] { "Variables and Data Types", "Basics", "Data Types", "Operators", "Modules and Packages", "Loops", "Functions", "Lists", "File Handling", "Data Structures" });
                    lectcombobox.Items.Add("Mr.Kathir");
                    break;


                case "C#":
                    subjectcombobox.Items.AddRange(new string[] { "Syntax", "OOP", "Loops", "Windows form", "Methodes", "Exception Handling", "Memory Management", "Namespaces and Assemblies" });
                    lectcombobox.Items.Add("Mr.Kathir");
                    break;

                case "C++":
                    subjectcombobox.Items.AddRange(new string[] { "Pointers", "Classes", "Templates", "STL", "Memory Management" });
                    lectcombobox.Items.Add("Mr.Mayooran" );
                    break;

                case "Java":
                    subjectcombobox.Items.AddRange(new string[] { "JVM Basics", "Collections", "Streams", "Concurrency", "Spring Framework" });
                    lectcombobox.Items.Add( "Dr.Neil Anthony-Pillai");
                    break;


                case "HTML":
                    subjectcombobox.Items.AddRange(new string[] { "Elements", "Attributes", "Forms", "Tables", "SEO Basics" });
                    lectcombobox.Items.Add( "Ms.S.Dharsika");
                    break;

                case "CSS":
                    subjectcombobox.Items.AddRange(new string[] { "Selectors", "Box Model", "Flexbox", "Grid", "Animations" });
                    lectcombobox.Items.Add ("Mr.Mayooran");
                    break;

                case "Web Development":
                    subjectcombobox.Items.AddRange(new string[] { "Frontend Basics", "Backend Basics", "APIs", "Databases", "Deployment" });
                    lectcombobox.Items.Add("Mr.Kathir");
                    break;




            }
            if (lectcombobox.Items.Count > 0)
                lectcombobox.SelectedItem = 0;
        }

        private void lectcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subjectcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            
            
           if (coursecombobox.SelectedItem == null ||
               subjectcombobox.SelectedItem == null ||
               lectcombobox.SelectedItem == null)
           {
               MessageBox.Show("Please make sure all selections are made (Course, Subject, Lecturer).", "Selection Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
           }

           string selectedCourse = coursecombobox.SelectedItem.ToString();
           string selectedSubject = subjectcombobox.SelectedItem.ToString();
           string selectedLecturer = lectcombobox.SelectedItem.ToString();

           string message = $"Course: {selectedCourse}\nSubject: {selectedSubject}\nLecturer: {selectedLecturer}";

           MessageBox.Show(message, "Selection Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }
    }
}
