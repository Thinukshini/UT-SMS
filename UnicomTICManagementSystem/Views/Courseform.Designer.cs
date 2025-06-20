namespace UnicomTICManagementSystem.Views
{
    partial class Courseform
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
            courselbl = new Label();
            coursecombobox = new ComboBox();
            subjectslbl = new Label();
            subjectcombobox = new ComboBox();
            lecturerlbl = new Label();
            lectcombobox = new ComboBox();
            selectbtn = new Button();
            backbtn = new Button();
            SuspendLayout();
            // 
            // courselbl
            // 
            courselbl.AutoSize = true;
            courselbl.BackColor = SystemColors.ControlDarkDark;
            courselbl.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            courselbl.Location = new Point(92, 50);
            courselbl.Margin = new Padding(4, 0, 4, 0);
            courselbl.Name = "courselbl";
            courselbl.Size = new Size(64, 20);
            courselbl.TabIndex = 0;
            courselbl.Text = "Courses";
            // 
            // coursecombobox
            // 
            coursecombobox.FormattingEnabled = true;
            coursecombobox.Location = new Point(301, 42);
            coursecombobox.Margin = new Padding(4);
            coursecombobox.Name = "coursecombobox";
            coursecombobox.Size = new Size(313, 28);
            coursecombobox.TabIndex = 1;
            coursecombobox.SelectedIndexChanged += coursecombobox_SelectedIndexChanged;
            // 
            // subjectslbl
            // 
            subjectslbl.AutoSize = true;
            subjectslbl.Location = new Point(92, 129);
            subjectslbl.Margin = new Padding(4, 0, 4, 0);
            subjectslbl.Name = "subjectslbl";
            subjectslbl.Size = new Size(69, 20);
            subjectslbl.TabIndex = 2;
            subjectslbl.Text = "Subjects";
            // 
            // subjectcombobox
            // 
            subjectcombobox.FormattingEnabled = true;
            subjectcombobox.Location = new Point(301, 121);
            subjectcombobox.Margin = new Padding(4);
            subjectcombobox.Name = "subjectcombobox";
            subjectcombobox.Size = new Size(313, 28);
            subjectcombobox.TabIndex = 3;
            subjectcombobox.SelectedIndexChanged += subjectcombobox_SelectedIndexChanged;
            // 
            // lecturerlbl
            // 
            lecturerlbl.AutoSize = true;
            lecturerlbl.Location = new Point(94, 212);
            lecturerlbl.Name = "lecturerlbl";
            lecturerlbl.Size = new Size(67, 20);
            lecturerlbl.TabIndex = 4;
            lecturerlbl.Text = "Lecturer";
            // 
            // lectcombobox
            // 
            lectcombobox.FormattingEnabled = true;
            lectcombobox.Location = new Point(301, 204);
            lectcombobox.Name = "lectcombobox";
            lectcombobox.Size = new Size(313, 28);
            lectcombobox.TabIndex = 5;
            lectcombobox.SelectedIndexChanged += lectcombobox_SelectedIndexChanged;
            // 
            // selectbtn
            // 
            selectbtn.Location = new Point(551, 281);
            selectbtn.Name = "selectbtn";
            selectbtn.Size = new Size(118, 41);
            selectbtn.TabIndex = 6;
            selectbtn.Text = "Select";
            selectbtn.UseVisualStyleBackColor = true;
            selectbtn.Click += selectbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(684, 356);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(77, 30);
            backbtn.TabIndex = 7;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // Courseform
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(803, 402);
            Controls.Add(backbtn);
            Controls.Add(selectbtn);
            Controls.Add(lectcombobox);
            Controls.Add(lecturerlbl);
            Controls.Add(subjectcombobox);
            Controls.Add(subjectslbl);
            Controls.Add(coursecombobox);
            Controls.Add(courselbl);
            Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Courseform";
            Text = "Courseform";
            Load += Courseform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label courselbl;
        private ComboBox coursecombobox;
        private Label subjectslbl;
        private ComboBox subjectcombobox;
        private Label lecturerlbl;
        private ComboBox lectcombobox;
        private Button selectbtn;
        private Button backbtn;
    }
}