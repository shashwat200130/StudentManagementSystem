namespace StudentManagementSystem
{
    partial class RegisterForm
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
            register_btn = new Button();
            register_showpass = new CheckBox();
            register_password = new TextBox();
            label4 = new Label();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            register_login_btn = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.DarkSlateBlue;
            register_btn.Cursor = Cursors.Hand;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = Color.Navy;
            register_btn.FlatAppearance.MouseOverBackColor = Color.Navy;
            register_btn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = SystemColors.ButtonHighlight;
            register_btn.Location = new Point(349, 379);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(144, 45);
            register_btn.TabIndex = 17;
            register_btn.Text = "REGISTER";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += login_btn_Click;
            // 
            // register_showpass
            // 
            register_showpass.AutoSize = true;
            register_showpass.Cursor = Cursors.Hand;
            register_showpass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showpass.Location = new Point(548, 308);
            register_showpass.Name = "register_showpass";
            register_showpass.Size = new Size(130, 22);
            register_showpass.TabIndex = 16;
            register_showpass.Text = "Show Password";
            register_showpass.UseVisualStyleBackColor = true;
            register_showpass.CheckedChanged += register_showpass_CheckedChanged;
            // 
            // register_password
            // 
            register_password.Location = new Point(349, 275);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(331, 27);
            register_password.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(349, 250);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // register_username
            // 
            register_username.Location = new Point(349, 189);
            register_username.Name = "register_username";
            register_username.Size = new Size(331, 27);
            register_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 164);
            label3.Name = "label3";
            label3.Size = new Size(96, 22);
            label3.TabIndex = 12;
            label3.Text = "UserName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 73);
            label2.Name = "label2";
            label2.Size = new Size(253, 32);
            label2.TabIndex = 11;
            label2.Text = "Register Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(672, 9);
            exit.Name = "exit";
            exit.Size = new Size(20, 22);
            exit.TabIndex = 10;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(register_login_btn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 521);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(82, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            // register_login_btn
            // 
            register_login_btn.BackColor = Color.MediumSlateBlue;
            register_login_btn.Cursor = Cursors.Hand;
            register_login_btn.FlatAppearance.BorderSize = 0;
            register_login_btn.FlatAppearance.MouseDownBackColor = Color.Navy;
            register_login_btn.FlatAppearance.MouseOverBackColor = Color.Navy;
            register_login_btn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_login_btn.ForeColor = Color.White;
            register_login_btn.Location = new Point(11, 455);
            register_login_btn.Name = "register_login_btn";
            register_login_btn.Size = new Size(287, 33);
            register_login_btn.TabIndex = 1;
            register_login_btn.Text = "LOGIN";
            register_login_btn.UseVisualStyleBackColor = false;
            register_login_btn.Click += register_login_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(72, 420);
            label5.Name = "label5";
            label5.Size = new Size(164, 22);
            label5.TabIndex = 0;
            label5.Text = "Login Your Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(715, 521);
            Controls.Add(register_btn);
            Controls.Add(register_showpass);
            Controls.Add(register_password);
            Controls.Add(label4);
            Controls.Add(register_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button register_btn;
        private CheckBox register_showpass;
        private TextBox register_password;
        private Label label4;
        private TextBox register_username;
        private Label label3;
        private Label label2;
        private Label exit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button register_login_btn;
        private Label label5;
    }
}