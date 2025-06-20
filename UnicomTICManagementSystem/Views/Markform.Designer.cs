namespace UnicomTICManagementSystem.Views
{
    partial class Markform
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
            mastnamelbl = new Label();
            mastnametxt = new TextBox();
            extylbl = new Label();
            extytxxt = new TextBox();
            marklbl = new Label();
            marktxt = new TextBox();
            gradelbl = new Label();
            gradetxt = new TextBox();
            markgridview = new DataGridView();
            maraddbtn = new Button();
            marupdatebtn = new Button();
            madeletebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)markgridview).BeginInit();
            SuspendLayout();
            // 
            // mastnamelbl
            // 
            mastnamelbl.AutoSize = true;
            mastnamelbl.Location = new Point(30, 9);
            mastnamelbl.Margin = new Padding(4, 0, 4, 0);
            mastnamelbl.Name = "mastnamelbl";
            mastnamelbl.Size = new Size(119, 21);
            mastnamelbl.TabIndex = 0;
            mastnamelbl.Text = "Sudent_Name";
            // 
            // mastnametxt
            // 
            mastnametxt.Location = new Point(229, 6);
            mastnametxt.Margin = new Padding(4, 4, 4, 4);
            mastnametxt.Name = "mastnametxt";
            mastnametxt.Size = new Size(284, 29);
            mastnametxt.TabIndex = 1;
            // 
            // extylbl
            // 
            extylbl.AutoSize = true;
            extylbl.Location = new Point(30, 58);
            extylbl.Margin = new Padding(4, 0, 4, 0);
            extylbl.Name = "extylbl";
            extylbl.Size = new Size(96, 21);
            extylbl.TabIndex = 2;
            extylbl.Text = "Exam Type";
            // 
            // extytxxt
            // 
            extytxxt.Location = new Point(229, 50);
            extytxxt.Margin = new Padding(4, 4, 4, 4);
            extytxxt.Name = "extytxxt";
            extytxxt.Size = new Size(284, 29);
            extytxxt.TabIndex = 3;
            // 
            // marklbl
            // 
            marklbl.AutoSize = true;
            marklbl.Location = new Point(30, 102);
            marklbl.Margin = new Padding(4, 0, 4, 0);
            marklbl.Name = "marklbl";
            marklbl.Size = new Size(61, 21);
            marklbl.TabIndex = 4;
            marklbl.Text = "Marks";
            // 
            // marktxt
            // 
            marktxt.Location = new Point(229, 94);
            marktxt.Margin = new Padding(4, 4, 4, 4);
            marktxt.Name = "marktxt";
            marktxt.Size = new Size(284, 29);
            marktxt.TabIndex = 5;
            // 
            // gradelbl
            // 
            gradelbl.AutoSize = true;
            gradelbl.Location = new Point(33, 146);
            gradelbl.Margin = new Padding(4, 0, 4, 0);
            gradelbl.Name = "gradelbl";
            gradelbl.Size = new Size(58, 21);
            gradelbl.TabIndex = 6;
            gradelbl.Text = "Grade";
            // 
            // gradetxt
            // 
            gradetxt.Location = new Point(229, 143);
            gradetxt.Margin = new Padding(4, 4, 4, 4);
            gradetxt.Name = "gradetxt";
            gradetxt.Size = new Size(284, 29);
            gradetxt.TabIndex = 7;
            // 
            // markgridview
            // 
            markgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            markgridview.Location = new Point(30, 194);
            markgridview.Margin = new Padding(4, 4, 4, 4);
            markgridview.Name = "markgridview";
            markgridview.Size = new Size(646, 255);
            markgridview.TabIndex = 8;
            // 
            // maraddbtn
            // 
            maraddbtn.Location = new Point(60, 467);
            maraddbtn.Margin = new Padding(4, 4, 4, 4);
            maraddbtn.Name = "maraddbtn";
            maraddbtn.Size = new Size(126, 46);
            maraddbtn.TabIndex = 9;
            maraddbtn.Text = "Add";
            maraddbtn.UseVisualStyleBackColor = true;
            // 
            // marupdatebtn
            // 
            marupdatebtn.Location = new Point(285, 467);
            marupdatebtn.Margin = new Padding(4, 4, 4, 4);
            marupdatebtn.Name = "marupdatebtn";
            marupdatebtn.Size = new Size(119, 46);
            marupdatebtn.TabIndex = 10;
            marupdatebtn.Text = "Update";
            marupdatebtn.UseVisualStyleBackColor = true;
            // 
            // madeletebtn
            // 
            madeletebtn.Location = new Point(493, 468);
            madeletebtn.Margin = new Padding(4, 4, 4, 4);
            madeletebtn.Name = "madeletebtn";
            madeletebtn.Size = new Size(119, 45);
            madeletebtn.TabIndex = 11;
            madeletebtn.Text = "Delete";
            madeletebtn.UseVisualStyleBackColor = true;
            // 
            // Markform
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(770, 534);
            Controls.Add(madeletebtn);
            Controls.Add(marupdatebtn);
            Controls.Add(maraddbtn);
            Controls.Add(markgridview);
            Controls.Add(gradetxt);
            Controls.Add(gradelbl);
            Controls.Add(marktxt);
            Controls.Add(marklbl);
            Controls.Add(extytxxt);
            Controls.Add(extylbl);
            Controls.Add(mastnametxt);
            Controls.Add(mastnamelbl);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Markform";
            Text = "Markform";
            ((System.ComponentModel.ISupportInitialize)markgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mastnamelbl;
        private TextBox mastnametxt;
        private Label extylbl;
        private TextBox extytxxt;
        private Label marklbl;
        private TextBox marktxt;
        private Label gradelbl;
        private TextBox gradetxt;
        private DataGridView markgridview;
        private Button maraddbtn;
        private Button marupdatebtn;
        private Button madeletebtn;
    }
}