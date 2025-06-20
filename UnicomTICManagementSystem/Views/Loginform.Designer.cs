namespace UnicomTICManagementSystem.Views
{
    partial class Loginform
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
            label1 = new Label();
            label2 = new Label();
            rolelbl = new Label();
            UserName = new TextBox();
            Password = new TextBox();
            Login = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // rolelbl
            // 
            rolelbl.AutoSize = true;
            rolelbl.Location = new Point(186, 212);
            rolelbl.Margin = new Padding(4, 0, 4, 0);
            rolelbl.Name = "rolelbl";
            rolelbl.Size = new Size(45, 21);
            rolelbl.TabIndex = 2;
            rolelbl.Text = "Role";
            rolelbl.Click += label3_Click;
            // 
            // UserName
            // 
            UserName.Location = new Point(413, 38);
            UserName.Margin = new Padding(4);
            UserName.Name = "UserName";
            UserName.Size = new Size(315, 29);
            UserName.TabIndex = 3;
            // 
            // Password
            // 
            Password.Location = new Point(413, 124);
            Password.Margin = new Padding(4);
            Password.Name = "Password";
            Password.Size = new Size(315, 29);
            Password.TabIndex = 4;
            // 
            // Login
            // 
            Login.Location = new Point(632, 315);
            Login.Name = "Login";
            Login.Size = new Size(75, 37);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(413, 209);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(315, 29);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(772, 389);
            Controls.Add(comboBox1);
            Controls.Add(Login);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(rolelbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4);
            Name = "Loginform";
            Text = "Login";
            Load += Loginform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label rolelbl;
        private TextBox UserName;
        private TextBox Password;
        private Button Login;
        private ComboBox comboBox1;
    }
}