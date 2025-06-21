namespace UnicomTICManagementSystem.Views
{
    partial class Examform
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
            examlbl = new Label();
            subjectlbl = new Label();
            roomlbl = new Label();
            dataGridView1 = new DataGridView();
            subjecttxt = new TextBox();
            examtxt = new TextBox();
            roomtxt = new TextBox();
            examaddbtn = new Button();
            examupdatebtn = new Button();
            examdelbtn = new Button();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // examlbl
            // 
            examlbl.AutoSize = true;
            examlbl.Location = new Point(48, 62);
            examlbl.Margin = new Padding(4, 0, 4, 0);
            examlbl.Name = "examlbl";
            examlbl.Size = new Size(96, 21);
            examlbl.TabIndex = 0;
            examlbl.Text = "Exam Type";
            // 
            // subjectlbl
            // 
            subjectlbl.AutoSize = true;
            subjectlbl.Location = new Point(48, 16);
            subjectlbl.Margin = new Padding(4, 0, 4, 0);
            subjectlbl.Name = "subjectlbl";
            subjectlbl.Size = new Size(68, 21);
            subjectlbl.TabIndex = 1;
            subjectlbl.Text = "Subject";
            // 
            // roomlbl
            // 
            roomlbl.AutoSize = true;
            roomlbl.Location = new Point(48, 111);
            roomlbl.Margin = new Padding(4, 0, 4, 0);
            roomlbl.Name = "roomlbl";
            roomlbl.Size = new Size(56, 21);
            roomlbl.TabIndex = 2;
            roomlbl.Text = "Room";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 148);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(614, 210);
            dataGridView1.TabIndex = 3;
            // 
            // subjecttxt
            // 
            subjecttxt.Location = new Point(244, 8);
            subjecttxt.Margin = new Padding(4, 4, 4, 4);
            subjecttxt.Name = "subjecttxt";
            subjecttxt.Size = new Size(243, 29);
            subjecttxt.TabIndex = 4;
            // 
            // examtxt
            // 
            examtxt.Location = new Point(244, 62);
            examtxt.Margin = new Padding(4, 4, 4, 4);
            examtxt.Name = "examtxt";
            examtxt.Size = new Size(243, 29);
            examtxt.TabIndex = 5;
            // 
            // roomtxt
            // 
            roomtxt.Location = new Point(244, 111);
            roomtxt.Margin = new Padding(4, 4, 4, 4);
            roomtxt.Name = "roomtxt";
            roomtxt.Size = new Size(243, 29);
            roomtxt.TabIndex = 6;
            // 
            // examaddbtn
            // 
            examaddbtn.Location = new Point(71, 366);
            examaddbtn.Margin = new Padding(4, 4, 4, 4);
            examaddbtn.Name = "examaddbtn";
            examaddbtn.Size = new Size(107, 42);
            examaddbtn.TabIndex = 7;
            examaddbtn.Text = "Add";
            examaddbtn.UseVisualStyleBackColor = true;
            // 
            // examupdatebtn
            // 
            examupdatebtn.Location = new Point(276, 366);
            examupdatebtn.Margin = new Padding(4, 4, 4, 4);
            examupdatebtn.Name = "examupdatebtn";
            examupdatebtn.Size = new Size(107, 45);
            examupdatebtn.TabIndex = 8;
            examupdatebtn.Text = "Update";
            examupdatebtn.UseVisualStyleBackColor = true;
            // 
            // examdelbtn
            // 
            examdelbtn.Location = new Point(493, 367);
            examdelbtn.Margin = new Padding(4, 4, 4, 4);
            examdelbtn.Name = "examdelbtn";
            examdelbtn.Size = new Size(107, 42);
            examdelbtn.TabIndex = 9;
            examdelbtn.Text = "Delete";
            examdelbtn.UseVisualStyleBackColor = true;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(647, 417);
            backbtn.Margin = new Padding(4, 4, 4, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(107, 32);
            backbtn.TabIndex = 10;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            // 
            // Examform
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(782, 465);
            Controls.Add(backbtn);
            Controls.Add(examdelbtn);
            Controls.Add(examupdatebtn);
            Controls.Add(examaddbtn);
            Controls.Add(roomtxt);
            Controls.Add(examtxt);
            Controls.Add(subjecttxt);
            Controls.Add(dataGridView1);
            Controls.Add(roomlbl);
            Controls.Add(subjectlbl);
            Controls.Add(examlbl);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Examform";
            Text = "Examform";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label examlbl;
        private Label subjectlbl;
        private Label roomlbl;
        private DataGridView dataGridView1;
        private TextBox subjecttxt;
        private TextBox examtxt;
        private TextBox roomtxt;
        private Button examaddbtn;
        private Button examupdatebtn;
        private Button examdelbtn;
        private Button backbtn;
    }
}