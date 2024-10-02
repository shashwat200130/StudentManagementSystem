namespace StudentManagementSystem
{
    partial class MainForm
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
            panel1 = new Panel();
            exit = new Label();
            greetuser = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            logout_btn = new Button();
            branch_button = new Button();
            addStudent_btn = new Button();
            dashboard_btn = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            uid1 = new UID();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            addStudents1 = new AddStudents();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            pictureBox2 = new PictureBox();
            dashboard1 = new Dashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(exit);
            panel1.Controls.Add(greetuser);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1495, 63);
            panel1.TabIndex = 0;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(1460, 18);
            exit.Name = "exit";
            exit.Size = new Size(20, 21);
            exit.TabIndex = 2;
            exit.Text = "X";
            exit.Click += label5_Click;
            // 
            // greetuser
            // 
            greetuser.AutoSize = true;
            greetuser.Location = new Point(12, 18);
            greetuser.Name = "greetuser";
            greetuser.Size = new Size(252, 21);
            greetuser.TabIndex = 1;
            greetuser.Text = "Student Managemnt System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(2010, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 21);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(branch_button);
            panel2.Controls.Add(addStudent_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 763);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 719);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 6;
            label4.Text = "Log Out";
            label4.Click += label4_Click;
            // 
            // logout_btn
            // 
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Image = Properties.Resources.icons8_logout_rounded_up_filled_25px;
            logout_btn.Location = new Point(13, 708);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(45, 43);
            logout_btn.TabIndex = 5;
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // branch_button
            // 
            branch_button.BackColor = Color.DarkSlateBlue;
            branch_button.ForeColor = Color.White;
            branch_button.Image = Properties.Resources.icons8_employee_card_30px3;
            branch_button.ImageAlign = ContentAlignment.MiddleLeft;
            branch_button.Location = new Point(12, 482);
            branch_button.Name = "branch_button";
            branch_button.Size = new Size(253, 43);
            branch_button.TabIndex = 4;
            branch_button.Text = "Branch";
            branch_button.UseVisualStyleBackColor = false;
            branch_button.Click += branch_button_Click;
            // 
            // addStudent_btn
            // 
            addStudent_btn.BackColor = Color.DarkSlateBlue;
            addStudent_btn.ForeColor = Color.White;
            addStudent_btn.Image = Properties.Resources.icons8_employee_card_30px1;
            addStudent_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addStudent_btn.Location = new Point(12, 410);
            addStudent_btn.Name = "addStudent_btn";
            addStudent_btn.Size = new Size(253, 46);
            addStudent_btn.TabIndex = 3;
            addStudent_btn.Text = "Add Student";
            addStudent_btn.UseVisualStyleBackColor = false;
            addStudent_btn.Click += addStudent_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.DarkSlateBlue;
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Image = Properties.Resources.icons8_dashboard_30px;
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(12, 338);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(252, 46);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 229);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 1;
            label3.Text = "Welcome, User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(67, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uid1
            // 
            uid1.Location = new Point(280, 63);
            uid1.Name = "uid1";
            uid1.Size = new Size(1514, 954);
            uid1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(333, 139);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 3;
            label5.Text = "Student UID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(333, 220);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 4;
            label6.Text = "Full Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(333, 366);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 5;
            label7.Text = "Branch:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(333, 292);
            label8.Name = "label8";
            label8.Size = new Size(131, 21);
            label8.TabIndex = 6;
            label8.Text = "Admission Year:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(659, 115);
            label9.Name = "label9";
            label9.Size = new Size(102, 28);
            label9.TabIndex = 7;
            label9.Text = "Students";
            // 
            // addStudents1
            // 
            addStudents1.Location = new Point(280, 63);
            addStudents1.Name = "addStudents1";
            addStudents1.Size = new Size(1514, 954);
            addStudents1.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(319, 132);
            label10.Name = "label10";
            label10.Size = new Size(157, 28);
            label10.TabIndex = 9;
            label10.Text = "Students Data";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonHighlight;
            label11.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(352, 556);
            label11.Name = "label11";
            label11.Size = new Size(101, 21);
            label11.TabIndex = 10;
            label11.Text = "Student UID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonHighlight;
            label12.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(352, 601);
            label12.Name = "label12";
            label12.Size = new Size(84, 21);
            label12.TabIndex = 11;
            label12.Text = "Full Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ButtonHighlight;
            label13.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(352, 655);
            label13.Name = "label13";
            label13.Size = new Size(63, 21);
            label13.TabIndex = 12;
            label13.Text = "Gender";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ButtonHighlight;
            label14.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(790, 545);
            label14.Name = "label14";
            label14.Size = new Size(118, 21);
            label14.TabIndex = 13;
            label14.Text = "Phone Number";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1333, 545);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 137);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(280, 63);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1514, 954);
            dashboard1.TabIndex = 15;
            dashboard1.Load += dashboard1_Load_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 826);
            Controls.Add(dashboard1);
            Controls.Add(pictureBox2);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(addStudents1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(uid1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label greetuser;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button dashboard_btn;
        private Label label3;
        private Button branch_button;
        private Button addStudent_btn;
        private Button logout_btn;
        private Label label4;
        private Label exit;
        private UID uid1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private AddStudents addStudents1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox2;
        private Dashboard dashboard1;
    }
}