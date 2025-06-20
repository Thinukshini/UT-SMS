
namespace UnicomTICManagementSystem.Views
{
    partial class Studentform
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
            namelbl = new Label();
            IDlbl = new Label();
            nicNumlbl = new Label();
            stnametxt = new TextBox();
            stIDtxt = new TextBox();
            nicNumtxt = new TextBox();
            DataGridView1 = new DataGridView();
            addbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            titabtn = new Button();
            coursebtn = new Button();
            marksbtn = new Button();
            exambtn = new Button();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Location = new Point(38, 9);
            namelbl.Margin = new Padding(4, 0, 4, 0);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(55, 20);
            namelbl.TabIndex = 0;
            namelbl.Text = " Name";
            // 
            // IDlbl
            // 
            IDlbl.AutoSize = true;
            IDlbl.Location = new Point(47, 57);
            IDlbl.Margin = new Padding(4, 0, 4, 0);
            IDlbl.Name = "IDlbl";
            IDlbl.Size = new Size(29, 20);
            IDlbl.TabIndex = 1;
            IDlbl.Text = " ID";
            // 
            // nicNumlbl
            // 
            nicNumlbl.AutoSize = true;
            nicNumlbl.Location = new Point(47, 107);
            nicNumlbl.Margin = new Padding(4, 0, 4, 0);
            nicNumlbl.Name = "nicNumlbl";
            nicNumlbl.Size = new Size(99, 20);
            nicNumlbl.TabIndex = 2;
            nicNumlbl.Text = "NIC_Number";
            // 
            // stnametxt
            // 
            stnametxt.Location = new Point(318, 6);
            stnametxt.Margin = new Padding(4);
            stnametxt.Name = "stnametxt";
            stnametxt.Size = new Size(336, 27);
            stnametxt.TabIndex = 3;
            stnametxt.TextChanged += stname_TextChanged;
            // 
            // stIDtxt
            // 
            stIDtxt.Location = new Point(318, 57);
            stIDtxt.Margin = new Padding(4);
            stIDtxt.Name = "stIDtxt";
            stIDtxt.Size = new Size(336, 27);
            stIDtxt.TabIndex = 4;
            stIDtxt.TextChanged += textBox1_TextChanged;
            // 
            // nicNumtxt
            // 
            nicNumtxt.Location = new Point(318, 107);
            nicNumtxt.Margin = new Padding(4);
            nicNumtxt.Name = "nicNumtxt";
            nicNumtxt.Size = new Size(336, 27);
            nicNumtxt.TabIndex = 5;
            nicNumtxt.TextChanged += nicNumtxt_TextChanged;
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(47, 156);
            DataGridView1.Margin = new Padding(4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(616, 252);
            DataGridView1.TabIndex = 6;
            DataGridView1.CellContentClick += DataGridView1_CellContentClick;
            DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(111, 416);
            addbtn.Margin = new Padding(4);
            addbtn.Name = "addbtn";
            addbtn.RightToLeft = RightToLeft.Yes;
            addbtn.Size = new Size(96, 44);
            addbtn.TabIndex = 7;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(282, 416);
            updatebtn.Margin = new Padding(4);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(96, 44);
            updatebtn.TabIndex = 8;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(463, 416);
            deletebtn.Margin = new Padding(4);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(96, 44);
            deletebtn.TabIndex = 9;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += button1_Click;
            // 
            // titabtn
            // 
            titabtn.Location = new Point(680, 227);
            titabtn.Name = "titabtn";
            titabtn.Size = new Size(108, 37);
            titabtn.TabIndex = 10;
            titabtn.Text = "Timetable";
            titabtn.UseVisualStyleBackColor = true;
            titabtn.Click += titabtn_Click;
            // 
            // coursebtn
            // 
            coursebtn.Location = new Point(680, 165);
            coursebtn.Name = "coursebtn";
            coursebtn.Size = new Size(108, 37);
            coursebtn.TabIndex = 11;
            coursebtn.Text = "Course";
            coursebtn.UseVisualStyleBackColor = true;
            coursebtn.Click += coursebtn_Click;
            // 
            // marksbtn
            // 
            marksbtn.Location = new Point(680, 361);
            marksbtn.Name = "marksbtn";
            marksbtn.Size = new Size(108, 36);
            marksbtn.TabIndex = 12;
            marksbtn.Text = "Marks";
            marksbtn.UseVisualStyleBackColor = true;
            marksbtn.Click += marksbtn_Click;
            // 
            // exambtn
            // 
            exambtn.Location = new Point(680, 294);
            exambtn.Name = "exambtn";
            exambtn.Size = new Size(108, 35);
            exambtn.TabIndex = 13;
            exambtn.Text = "Exams";
            exambtn.UseVisualStyleBackColor = true;
            exambtn.Click += exambtn_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(725, 452);
            backbtn.Margin = new Padding(4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(87, 30);
            backbtn.TabIndex = 14;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // Studentform
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(825, 495);
            Controls.Add(backbtn);
            Controls.Add(exambtn);
            Controls.Add(marksbtn);
            Controls.Add(coursebtn);
            Controls.Add(titabtn);
            Controls.Add(deletebtn);
            Controls.Add(updatebtn);
            Controls.Add(addbtn);
            Controls.Add(DataGridView1);
            Controls.Add(nicNumtxt);
            Controls.Add(stIDtxt);
            Controls.Add(stnametxt);
            Controls.Add(nicNumlbl);
            Controls.Add(IDlbl);
            Controls.Add(namelbl);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Studentform";
            Text = "Studentform";
            Load += Studentform_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Studentform_Load(object sender, EventArgs e)
        {
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void nicNumtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void stname_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Label namelbl;
        private Label label1;
        private Label IDlbl;
        private Label nicNumlbl;
        private TextBox stnametxt;
        private TextBox stIDtxt;
        private TextBox nicNumtxt;
        private DataGridView DataGridView1;
        private Button addbtn;
        private Button updatebtn;
        private Button deletebtn;
        private Button titabtn;
        private Button coursebtn;
        private Button marksbtn;
        private Button exambtn;
        private Button backbtn;
    }
}