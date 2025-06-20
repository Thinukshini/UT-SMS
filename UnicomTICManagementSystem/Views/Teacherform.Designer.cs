namespace UnicomTICManagementSystem.Views
{
    partial class Teacherform
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
            tenamelbl = new Label();
            tenametxt = new TextBox();
            teidlbl = new Label();
            teidtxt = new TextBox();
            teniclbl = new Label();
            tenictxt = new TextBox();
            tedataGridView = new DataGridView();
            teaddbtn = new Button();
            teupdatebtn = new Button();
            tedetetebtn = new Button();
            tecoursebtn = new Button();
            tetimebtn = new Button();
            teexambtn = new Button();
            temarkbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)tedataGridView).BeginInit();
            SuspendLayout();
            // 
            // tenamelbl
            // 
            tenamelbl.AutoSize = true;
            tenamelbl.Location = new Point(95, 16);
            tenamelbl.Margin = new Padding(4, 0, 4, 0);
            tenamelbl.Name = "tenamelbl";
            tenamelbl.Size = new Size(57, 21);
            tenamelbl.TabIndex = 0;
            tenamelbl.Text = "Name";
            // 
            // tenametxt
            // 
            tenametxt.Location = new Point(311, 8);
            tenametxt.Margin = new Padding(4);
            tenametxt.Name = "tenametxt";
            tenametxt.Size = new Size(310, 29);
            tenametxt.TabIndex = 1;
            // 
            // teidlbl
            // 
            teidlbl.AutoSize = true;
            teidlbl.Location = new Point(108, 60);
            teidlbl.Margin = new Padding(4, 0, 4, 0);
            teidlbl.Name = "teidlbl";
            teidlbl.Size = new Size(26, 21);
            teidlbl.TabIndex = 2;
            teidlbl.Text = "Id";
            // 
            // teidtxt
            // 
            teidtxt.Location = new Point(311, 52);
            teidtxt.Margin = new Padding(4);
            teidtxt.Name = "teidtxt";
            teidtxt.Size = new Size(310, 29);
            teidtxt.TabIndex = 3;
            // 
            // teniclbl
            // 
            teniclbl.AutoSize = true;
            teniclbl.Location = new Point(95, 95);
            teniclbl.Margin = new Padding(4, 0, 4, 0);
            teniclbl.Name = "teniclbl";
            teniclbl.Size = new Size(110, 21);
            teniclbl.TabIndex = 4;
            teniclbl.Text = "NIC_Number";
            // 
            // tenictxt
            // 
            tenictxt.Location = new Point(311, 95);
            tenictxt.Margin = new Padding(4);
            tenictxt.Name = "tenictxt";
            tenictxt.Size = new Size(310, 29);
            tenictxt.TabIndex = 5;
            // 
            // tedataGridView
            // 
            tedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tedataGridView.Location = new Point(13, 133);
            tedataGridView.Margin = new Padding(4);
            tedataGridView.Name = "tedataGridView";
            tedataGridView.Size = new Size(648, 266);
            tedataGridView.TabIndex = 6;
            // 
            // teaddbtn
            // 
            teaddbtn.Location = new Point(79, 407);
            teaddbtn.Margin = new Padding(4);
            teaddbtn.Name = "teaddbtn";
            teaddbtn.Size = new Size(111, 44);
            teaddbtn.TabIndex = 7;
            teaddbtn.Text = "Add";
            teaddbtn.UseVisualStyleBackColor = true;
            teaddbtn.Click += teaddbtn_Click;
            // 
            // teupdatebtn
            // 
            teupdatebtn.Location = new Point(287, 407);
            teupdatebtn.Margin = new Padding(4);
            teupdatebtn.Name = "teupdatebtn";
            teupdatebtn.Size = new Size(107, 44);
            teupdatebtn.TabIndex = 8;
            teupdatebtn.Text = "Update";
            teupdatebtn.UseVisualStyleBackColor = true;
            teupdatebtn.Click += teupdatebtn_Click;
            // 
            // tedetetebtn
            // 
            tedetetebtn.Location = new Point(483, 407);
            tedetetebtn.Margin = new Padding(4);
            tedetetebtn.Name = "tedetetebtn";
            tedetetebtn.Size = new Size(114, 44);
            tedetetebtn.TabIndex = 9;
            tedetetebtn.Text = "Delete";
            tedetetebtn.UseVisualStyleBackColor = true;
            tedetetebtn.Click += tedetetebtn_Click;
            // 
            // tecoursebtn
            // 
            tecoursebtn.Location = new Point(689, 128);
            tecoursebtn.Margin = new Padding(4);
            tecoursebtn.Name = "tecoursebtn";
            tecoursebtn.Size = new Size(113, 40);
            tecoursebtn.TabIndex = 10;
            tecoursebtn.Text = "Courses";
            tecoursebtn.UseVisualStyleBackColor = true;
            tecoursebtn.Click += tecoursebtn_Click;
            // 
            // tetimebtn
            // 
            tetimebtn.Location = new Point(689, 195);
            tetimebtn.Margin = new Padding(4);
            tetimebtn.Name = "tetimebtn";
            tetimebtn.Size = new Size(113, 43);
            tetimebtn.TabIndex = 11;
            tetimebtn.Text = "Timetable";
            tetimebtn.UseVisualStyleBackColor = true;
            tetimebtn.Click += tetimebtn_Click;
            // 
            // teexambtn
            // 
            teexambtn.Location = new Point(689, 265);
            teexambtn.Margin = new Padding(4);
            teexambtn.Name = "teexambtn";
            teexambtn.Size = new Size(113, 38);
            teexambtn.TabIndex = 12;
            teexambtn.Text = "Exams";
            teexambtn.UseVisualStyleBackColor = true;
            teexambtn.Click += teexambtn_Click;
            // 
            // temarkbtn
            // 
            temarkbtn.Location = new Point(689, 340);
            temarkbtn.Margin = new Padding(4);
            temarkbtn.Name = "temarkbtn";
            temarkbtn.Size = new Size(113, 41);
            temarkbtn.TabIndex = 13;
            temarkbtn.Text = "Marks";
            temarkbtn.UseVisualStyleBackColor = true;
            temarkbtn.Click += temarkbtn_Click;
            // 
            // Teacherform
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(845, 464);
            Controls.Add(temarkbtn);
            Controls.Add(teexambtn);
            Controls.Add(tetimebtn);
            Controls.Add(tecoursebtn);
            Controls.Add(tedetetebtn);
            Controls.Add(teupdatebtn);
            Controls.Add(teaddbtn);
            Controls.Add(tedataGridView);
            Controls.Add(tenictxt);
            Controls.Add(teniclbl);
            Controls.Add(teidtxt);
            Controls.Add(teidlbl);
            Controls.Add(tenametxt);
            Controls.Add(tenamelbl);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Teacherform";
            Text = "Teacherform";
            Load += Teacherform_Load;
            ((System.ComponentModel.ISupportInitialize)tedataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tenamelbl;
        private TextBox tenametxt;
        private Label teidlbl;
        private TextBox teidtxt;
        private Label teniclbl;
        private TextBox tenictxt;
        private DataGridView tedataGridView;
        private Button teaddbtn;
        private Button teupdatebtn;
        private Button tedetetebtn;
        private Button tecoursebtn;
        private Button tetimebtn;
        private Button teexambtn;
        private Button temarkbtn;
    }
}