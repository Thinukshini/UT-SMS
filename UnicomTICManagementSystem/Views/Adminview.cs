using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class Adminview : Form
    {
        

        

       
        public Adminview( )
        {
            InitializeComponent();
           

        }

      
        
       
           
        
        private void Adminview_Load(object sender, EventArgs e)
        {
           

        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            Studentform studentform = new Studentform();
            studentform.Show();
            this.Hide();
        }

        private void teacherbtn_Click(object sender, EventArgs e)
        {
            Teacherform teacherform = new Teacherform();
            teacherform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staffform staffform = new Staffform();
            staffform.Show();
            this.Hide();
        }

        private void mancoursebtn_Click(object sender, EventArgs e)
        {
            Courseform courseform = new Courseform();
            courseform.Show();
            this.Hide();
        }

        private void adtimetablebtn_Click(object sender, EventArgs e)
        {
            Timetableform timetableform = new Timetableform();
            timetableform.Show();
            this.Hide();
        }

        private void adexamsbtn_Click(object sender, EventArgs e)
        {
            Examform examform = new Examform();
            examform.Show();
            this.Hide();
        }

        private void admarksbtn_Click(object sender, EventArgs e)
        {
             Markform markform = new Markform();
             markform.Show();
             this.Hide();
        }
    }
}
