namespace StudentManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            login_register_btn = new Button();
            label5 = new Label();
            exit = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_showpass = new CheckBox();
            login_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(login_register_btn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 521);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(82, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 249);
            label6.Name = "label6";
            label6.Size = new Size(275, 22);
            label6.TabIndex = 2;
            label6.Text = "Student Management System";
            // 
            // login_register_btn
            // 
            login_register_btn.BackColor = Color.MediumSlateBlue;
            login_register_btn.Cursor = Cursors.Hand;
            login_register_btn.FlatAppearance.BorderSize = 0;
            login_register_btn.FlatAppearance.MouseDownBackColor = Color.Navy;
            login_register_btn.FlatAppearance.MouseOverBackColor = Color.Navy;
            login_register_btn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_register_btn.ForeColor = Color.White;
            login_register_btn.Location = new Point(11, 455);
            login_register_btn.Name = "login_register_btn";
            login_register_btn.Size = new Size(287, 33);
            login_register_btn.TabIndex = 1;
            login_register_btn.Text = "REGISTER";
            login_register_btn.UseVisualStyleBackColor = false;
            login_register_btn.Click += login_register_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(72, 420);
            label5.Name = "label5";
            label5.Size = new Size(184, 22);
            label5.TabIndex = 0;
            label5.Text = "Register Your Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(667, 9);
            exit.Name = "exit";
            exit.Size = new Size(20, 22);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 73);
            label2.Name = "label2";
            label2.Size = new Size(213, 32);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(344, 164);
            label3.Name = "label3";
            label3.Size = new Size(96, 22);
            label3.TabIndex = 3;
            label3.Text = "UserName:";
            // 
            // login_username
            // 
            login_username.Location = new Point(344, 189);
            login_username.Name = "login_username";
            login_username.Size = new Size(331, 27);
            login_username.TabIndex = 4;
            login_username.TextChanged += textBox1_TextChanged;
            // 
            // login_password
            // 
            login_password.Location = new Point(344, 275);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(331, 27);
            login_password.TabIndex = 6;
            login_password.TextChanged += login_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(344, 250);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // login_showpass
            // 
            login_showpass.AutoSize = true;
            login_showpass.Cursor = Cursors.Hand;
            login_showpass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showpass.Location = new Point(543, 308);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(130, 22);
            login_showpass.TabIndex = 7;
            login_showpass.Text = "Show Password";
            login_showpass.UseVisualStyleBackColor = true;
            login_showpass.CheckedChanged += login_showpass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.DarkSlateBlue;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.Navy;
            login_btn.FlatAppearance.MouseOverBackColor = Color.Navy;
            login_btn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(344, 379);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(144, 45);
            login_btn.TabIndex = 8;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(715, 521);
            Controls.Add(login_btn);
            Controls.Add(login_showpass);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox login_password;
        private Label label4;
        private CheckBox login_showpass;
        private Button login_btn;
        private Button login_register_btn;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
