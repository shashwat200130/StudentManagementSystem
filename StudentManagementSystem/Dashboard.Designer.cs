namespace StudentManagementSystem
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel5 = new Panel();
            dashboard_IS = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel4 = new Panel();
            dasboard_AS = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel3 = new Panel();
            dashboard_TS = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(22, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 206);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateBlue;
            panel5.Controls.Add(dashboard_IS);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(864, 33);
            panel5.Name = "panel5";
            panel5.Size = new Size(259, 139);
            panel5.TabIndex = 2;
            // 
            // dashboard_IS
            // 
            dashboard_IS.AutoSize = true;
            dashboard_IS.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_IS.ForeColor = Color.White;
            dashboard_IS.Location = new Point(217, 23);
            dashboard_IS.Name = "dashboard_IS";
            dashboard_IS.Size = new Size(30, 34);
            dashboard_IS.TabIndex = 6;
            dashboard_IS.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(91, 104);
            label6.Name = "label6";
            label6.Size = new Size(165, 24);
            label6.TabIndex = 5;
            label6.Text = "Inactive Students";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateBlue;
            panel4.Controls.Add(dasboard_AS);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(439, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(265, 139);
            panel4.TabIndex = 1;
            // 
            // dasboard_AS
            // 
            dasboard_AS.AutoSize = true;
            dasboard_AS.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dasboard_AS.ForeColor = Color.White;
            dasboard_AS.Location = new Point(220, 23);
            dasboard_AS.Name = "dasboard_AS";
            dasboard_AS.Size = new Size(30, 34);
            dasboard_AS.TabIndex = 4;
            dasboard_AS.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(110, 104);
            label4.Name = "label4";
            label4.Size = new Size(148, 24);
            label4.TabIndex = 3;
            label4.Text = "Active Students";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateBlue;
            panel3.Controls.Add(dashboard_TS);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(36, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 139);
            panel3.TabIndex = 0;
            // 
            // dashboard_TS
            // 
            dashboard_TS.AutoSize = true;
            dashboard_TS.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_TS.ForeColor = Color.White;
            dashboard_TS.Location = new Point(218, 23);
            dashboard_TS.Name = "dashboard_TS";
            dashboard_TS.Size = new Size(30, 34);
            dashboard_TS.TabIndex = 2;
            dashboard_TS.Text = "0";
            dashboard_TS.Click += dashboard_TS_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(108, 104);
            label1.Name = "label1";
            label1.Size = new Size(140, 24);
            label1.TabIndex = 1;
            label1.Text = "Total Students";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_student_card_60px;
            pictureBox1.Location = new Point(19, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(22, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(1172, 479);
            panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(1211, 763);
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label dashboard_TS;
        private Label label1;
        private Label dashboard_IS;
        private Label label6;
        private Label dasboard_AS;
        private Label label4;
    }
}
