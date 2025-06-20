namespace UnicomTICManagementSystem.Views
{
    partial class Adminview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentbtn = new Button();
            teacherbtn = new Button();
            staffbtn = new Button();
            mancoursebtn = new Button();
            adtimetablebtn = new Button();
            adexamsbtn = new Button();
            admarksbtn = new Button();
            backbtn = new Button();
            SuspendLayout();
            // 
            // studentbtn
            // 
            studentbtn.Location = new Point(14, 24);
            studentbtn.Margin = new Padding(5, 4, 5, 4);
            studentbtn.Name = "studentbtn";
            studentbtn.Size = new Size(239, 40);
            studentbtn.TabIndex = 0;
            studentbtn.Text = "Add StudentsDetails";
            studentbtn.UseVisualStyleBackColor = true;
            studentbtn.Click += studentbtn_Click;
            // 
            // teacherbtn
            // 
            teacherbtn.Location = new Point(14, 149);
            teacherbtn.Margin = new Padding(5, 4, 5, 4);
            teacherbtn.Name = "teacherbtn";
            teacherbtn.Size = new Size(239, 39);
            teacherbtn.TabIndex = 1;
            teacherbtn.Text = "Add Teachers Details";
            teacherbtn.UseVisualStyleBackColor = true;
            teacherbtn.Click += teacherbtn_Click;
            // 
            // staffbtn
            // 
            staffbtn.Location = new Point(14, 266);
            staffbtn.Margin = new Padding(5, 4, 5, 4);
            staffbtn.Name = "staffbtn";
            staffbtn.Size = new Size(239, 43);
            staffbtn.TabIndex = 2;
            staffbtn.Text = "Add Staffs Details";
            staffbtn.UseVisualStyleBackColor = true;
            staffbtn.Click += button1_Click;
            // 
            // mancoursebtn
            // 
            mancoursebtn.Location = new Point(371, 24);
            mancoursebtn.Name = "mancoursebtn";
            mancoursebtn.Size = new Size(222, 40);
            mancoursebtn.TabIndex = 3;
            mancoursebtn.Text = "Manage Courses";
            mancoursebtn.UseVisualStyleBackColor = true;
            mancoursebtn.Click += mancoursebtn_Click;
            // 
            // adtimetablebtn
            // 
            adtimetablebtn.Location = new Point(371, 102);
            adtimetablebtn.Name = "adtimetablebtn";
            adtimetablebtn.Size = new Size(222, 41);
            adtimetablebtn.TabIndex = 4;
            adtimetablebtn.Text = "Manage Timetable";
            adtimetablebtn.UseVisualStyleBackColor = true;
            adtimetablebtn.Click += adtimetablebtn_Click;
            // 
            // adexamsbtn
            // 
            adexamsbtn.Location = new Point(371, 181);
            adexamsbtn.Name = "adexamsbtn";
            adexamsbtn.Size = new Size(222, 37);
            adexamsbtn.TabIndex = 5;
            adexamsbtn.Text = "Manage Exams";
            adexamsbtn.UseVisualStyleBackColor = true;
            adexamsbtn.Click += adexamsbtn_Click;
            // 
            // admarksbtn
            // 
            admarksbtn.Location = new Point(371, 257);
            admarksbtn.Name = "admarksbtn";
            admarksbtn.Size = new Size(222, 40);
            admarksbtn.TabIndex = 6;
            admarksbtn.Text = "Manage Marks";
            admarksbtn.UseVisualStyleBackColor = true;
            admarksbtn.Click += admarksbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(595, 318);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(75, 23);
            backbtn.TabIndex = 7;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            // 
            // Adminview
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(682, 353);
            Controls.Add(backbtn);
            Controls.Add(admarksbtn);
            Controls.Add(adexamsbtn);
            Controls.Add(adtimetablebtn);
            Controls.Add(mancoursebtn);
            Controls.Add(staffbtn);
            Controls.Add(teacherbtn);
            Controls.Add(studentbtn);
            Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Adminview";
            Text = "Adminview";
            Load += Adminview_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button studentbtn;
        private Button teacherbtn;
        private Button staffbtn;
        private Button mancoursebtn;
        private Button adtimetablebtn;
        private Button adexamsbtn;
        private Button admarksbtn;
        private Button backbtn;
    }
}