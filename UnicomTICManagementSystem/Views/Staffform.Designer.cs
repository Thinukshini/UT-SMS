namespace UnicomTICManagementSystem.Views
{
    partial class Staffform
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
            stanamelbl = new Label();
            stanametxt = new TextBox();
            staidbl = new Label();
            staidtxt = new TextBox();
            staniclbl = new Label();
            stanictxt = new TextBox();
            dataGridView1 = new DataGridView();
            add2btn = new Button();
            update2btn = new Button();
            delete2btn = new Button();
            course2btn = new Button();
            timta2btn = new Button();
            exam2btn = new Button();
            mark2btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // stanamelbl
            // 
            stanamelbl.AutoSize = true;
            stanamelbl.Location = new Point(96, 9);
            stanamelbl.Margin = new Padding(4, 0, 4, 0);
            stanamelbl.Name = "stanamelbl";
            stanamelbl.Size = new Size(52, 20);
            stanamelbl.TabIndex = 0;
            stanamelbl.Text = "Name";
            // 
            // stanametxt
            // 
            stanametxt.Location = new Point(359, 2);
            stanametxt.Margin = new Padding(4);
            stanametxt.Name = "stanametxt";
            stanametxt.Size = new Size(296, 27);
            stanametxt.TabIndex = 1;
            // 
            // staidbl
            // 
            staidbl.AutoSize = true;
            staidbl.Location = new Point(98, 55);
            staidbl.Margin = new Padding(4, 0, 4, 0);
            staidbl.Name = "staidbl";
            staidbl.Size = new Size(26, 20);
            staidbl.TabIndex = 2;
            staidbl.Text = "ID";
            // 
            // staidtxt
            // 
            staidtxt.Location = new Point(359, 52);
            staidtxt.Margin = new Padding(4);
            staidtxt.Name = "staidtxt";
            staidtxt.Size = new Size(296, 27);
            staidtxt.TabIndex = 3;
            // 
            // staniclbl
            // 
            staniclbl.AutoSize = true;
            staniclbl.Location = new Point(98, 107);
            staniclbl.Margin = new Padding(4, 0, 4, 0);
            staniclbl.Name = "staniclbl";
            staniclbl.Size = new Size(99, 20);
            staniclbl.TabIndex = 4;
            staniclbl.Text = "NIC_Number";
            // 
            // stanictxt
            // 
            stanictxt.Location = new Point(359, 104);
            stanictxt.Margin = new Padding(4);
            stanictxt.Name = "stanictxt";
            stanictxt.Size = new Size(296, 27);
            stanictxt.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(96, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(572, 216);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // add2btn
            // 
            add2btn.Location = new Point(122, 392);
            add2btn.Name = "add2btn";
            add2btn.Size = new Size(75, 32);
            add2btn.TabIndex = 7;
            add2btn.Text = "Add";
            add2btn.UseVisualStyleBackColor = true;
            add2btn.Click += add2btn_Click;
            // 
            // update2btn
            // 
            update2btn.Location = new Point(330, 392);
            update2btn.Name = "update2btn";
            update2btn.Size = new Size(75, 32);
            update2btn.TabIndex = 8;
            update2btn.Text = "Update";
            update2btn.UseVisualStyleBackColor = true;
            update2btn.Click += update2btn_Click;
            // 
            // delete2btn
            // 
            delete2btn.Location = new Point(545, 392);
            delete2btn.Name = "delete2btn";
            delete2btn.Size = new Size(75, 30);
            delete2btn.TabIndex = 9;
            delete2btn.Text = "Delete";
            delete2btn.UseVisualStyleBackColor = true;
            delete2btn.Click += delete2btn_Click;
            // 
            // course2btn
            // 
            course2btn.Location = new Point(716, 149);
            course2btn.Name = "course2btn";
            course2btn.Size = new Size(101, 34);
            course2btn.TabIndex = 10;
            course2btn.Text = "Course";
            course2btn.UseVisualStyleBackColor = true;
            course2btn.Click += course2btn_Click;
            // 
            // timta2btn
            // 
            timta2btn.Location = new Point(716, 211);
            timta2btn.Name = "timta2btn";
            timta2btn.Size = new Size(101, 38);
            timta2btn.TabIndex = 11;
            timta2btn.Text = "Timetable";
            timta2btn.UseVisualStyleBackColor = true;
            timta2btn.Click += timta2btn_Click;
            // 
            // exam2btn
            // 
            exam2btn.Location = new Point(716, 277);
            exam2btn.Name = "exam2btn";
            exam2btn.Size = new Size(101, 37);
            exam2btn.TabIndex = 12;
            exam2btn.Text = "Exams";
            exam2btn.UseVisualStyleBackColor = true;
            exam2btn.Click += exam2btn_Click;
            // 
            // mark2btn
            // 
            mark2btn.Location = new Point(716, 340);
            mark2btn.Name = "mark2btn";
            mark2btn.Size = new Size(101, 36);
            mark2btn.TabIndex = 13;
            mark2btn.Text = "Marks";
            mark2btn.UseVisualStyleBackColor = true;
            mark2btn.Click += mark2btn_Click;
            // 
            // Staffform
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(889, 482);
            Controls.Add(mark2btn);
            Controls.Add(exam2btn);
            Controls.Add(timta2btn);
            Controls.Add(course2btn);
            Controls.Add(delete2btn);
            Controls.Add(update2btn);
            Controls.Add(add2btn);
            Controls.Add(dataGridView1);
            Controls.Add(stanictxt);
            Controls.Add(staniclbl);
            Controls.Add(staidtxt);
            Controls.Add(staidbl);
            Controls.Add(stanametxt);
            Controls.Add(stanamelbl);
            Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Staffform";
            Text = "Staffform";
            Load += Staffform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stanamelbl;
        private TextBox stanametxt;
        private Label staidbl;
        private TextBox staidtxt;
        private Label staniclbl;
        private TextBox stanictxt;
        private DataGridView dataGridView1;
        private Button add2btn;
        private Button update2btn;
        private Button delete2btn;
        private Button course2btn;
        private Button timta2btn;
        private Button exam2btn;
        private Button mark2btn;
    }
}