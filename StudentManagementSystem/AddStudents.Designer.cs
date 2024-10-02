namespace StudentManagementSystem
{
    partial class AddStudents
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            addStudent_status = new ComboBox();
            addStudent_deletebtn = new Button();
            addStudent_clearbtn = new Button();
            addStudent_updatebtn = new Button();
            addStudent_addbtn = new Button();
            addStudent_importbtn = new Button();
            addStudent_picture = new PictureBox();
            addStudent_number = new TextBox();
            label5 = new Label();
            addStudent_gender = new ComboBox();
            label4 = new Label();
            addStudent_fullname = new TextBox();
            label3 = new Label();
            addStudent_uid = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addStudent_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 387);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1148, 290);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 0;
            label1.Text = "Student's Data";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addStudent_status);
            panel2.Controls.Add(addStudent_deletebtn);
            panel2.Controls.Add(addStudent_clearbtn);
            panel2.Controls.Add(addStudent_updatebtn);
            panel2.Controls.Add(addStudent_addbtn);
            panel2.Controls.Add(addStudent_importbtn);
            panel2.Controls.Add(addStudent_picture);
            panel2.Controls.Add(addStudent_number);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addStudent_gender);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addStudent_fullname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addStudent_uid);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(20, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(1177, 295);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(560, 116);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 15;
            label6.Text = "Status";
            // 
            // addStudent_status
            // 
            addStudent_status.FormattingEnabled = true;
            addStudent_status.Items.AddRange(new object[] { "Active", "Inactive" });
            addStudent_status.Location = new Point(616, 113);
            addStudent_status.Name = "addStudent_status";
            addStudent_status.Size = new Size(212, 28);
            addStudent_status.TabIndex = 14;
            // 
            // addStudent_deletebtn
            // 
            addStudent_deletebtn.BackColor = Color.DarkSlateBlue;
            addStudent_deletebtn.Cursor = Cursors.Hand;
            addStudent_deletebtn.FlatAppearance.BorderSize = 0;
            addStudent_deletebtn.FlatAppearance.CheckedBackColor = Color.Navy;
            addStudent_deletebtn.FlatAppearance.MouseDownBackColor = Color.Navy;
            addStudent_deletebtn.FlatAppearance.MouseOverBackColor = Color.Navy;
            addStudent_deletebtn.ForeColor = Color.White;
            addStudent_deletebtn.Location = new Point(762, 217);
            addStudent_deletebtn.Name = "addStudent_deletebtn";
            addStudent_deletebtn.Size = new Size(165, 49);
            addStudent_deletebtn.TabIndex = 13;
            addStudent_deletebtn.Text = "Delete";
            addStudent_deletebtn.UseVisualStyleBackColor = false;
            addStudent_deletebtn.Click += addStudent_deletebtn_Click;
            // 
            // addStudent_clearbtn
            // 
            addStudent_clearbtn.BackColor = Color.DarkSlateBlue;
            addStudent_clearbtn.Cursor = Cursors.Hand;
            addStudent_clearbtn.FlatAppearance.BorderSize = 0;
            addStudent_clearbtn.FlatAppearance.CheckedBackColor = Color.Navy;
            addStudent_clearbtn.FlatAppearance.MouseDownBackColor = Color.Navy;
            addStudent_clearbtn.FlatAppearance.MouseOverBackColor = Color.Navy;
            addStudent_clearbtn.ForeColor = Color.White;
            addStudent_clearbtn.Location = new Point(576, 217);
            addStudent_clearbtn.Name = "addStudent_clearbtn";
            addStudent_clearbtn.Size = new Size(165, 49);
            addStudent_clearbtn.TabIndex = 12;
            addStudent_clearbtn.Text = "Clear";
            addStudent_clearbtn.UseVisualStyleBackColor = false;
            addStudent_clearbtn.Click += addStudent_clearbtn_Click;
            // 
            // addStudent_updatebtn
            // 
            addStudent_updatebtn.BackColor = Color.DarkSlateBlue;
            addStudent_updatebtn.Cursor = Cursors.Hand;
            addStudent_updatebtn.FlatAppearance.BorderSize = 0;
            addStudent_updatebtn.FlatAppearance.CheckedBackColor = Color.Navy;
            addStudent_updatebtn.FlatAppearance.MouseDownBackColor = Color.Navy;
            addStudent_updatebtn.FlatAppearance.MouseOverBackColor = Color.Navy;
            addStudent_updatebtn.ForeColor = Color.White;
            addStudent_updatebtn.Location = new Point(392, 217);
            addStudent_updatebtn.Name = "addStudent_updatebtn";
            addStudent_updatebtn.Size = new Size(165, 49);
            addStudent_updatebtn.TabIndex = 11;
            addStudent_updatebtn.Text = "Update";
            addStudent_updatebtn.UseVisualStyleBackColor = false;
            addStudent_updatebtn.Click += addStudent_updatebtn_Click;
            // 
            // addStudent_addbtn
            // 
            addStudent_addbtn.BackColor = Color.DarkSlateBlue;
            addStudent_addbtn.Cursor = Cursors.Hand;
            addStudent_addbtn.FlatAppearance.BorderSize = 0;
            addStudent_addbtn.FlatAppearance.CheckedBackColor = Color.Navy;
            addStudent_addbtn.FlatAppearance.MouseDownBackColor = Color.Navy;
            addStudent_addbtn.FlatAppearance.MouseOverBackColor = Color.Navy;
            addStudent_addbtn.ForeColor = Color.White;
            addStudent_addbtn.Location = new Point(206, 217);
            addStudent_addbtn.Name = "addStudent_addbtn";
            addStudent_addbtn.Size = new Size(165, 49);
            addStudent_addbtn.TabIndex = 10;
            addStudent_addbtn.Text = "Add";
            addStudent_addbtn.UseVisualStyleBackColor = false;
            addStudent_addbtn.Click += addStudent_addbtn_Click;
            // 
            // addStudent_importbtn
            // 
            addStudent_importbtn.BackColor = Color.DarkSlateBlue;
            addStudent_importbtn.FlatAppearance.BorderSize = 0;
            addStudent_importbtn.ForeColor = Color.White;
            addStudent_importbtn.Location = new Point(1052, 183);
            addStudent_importbtn.Name = "addStudent_importbtn";
            addStudent_importbtn.Size = new Size(94, 29);
            addStudent_importbtn.TabIndex = 9;
            addStudent_importbtn.Text = "Import";
            addStudent_importbtn.UseVisualStyleBackColor = false;
            addStudent_importbtn.Click += addStudent_importbtn_Click;
            // 
            // addStudent_picture
            // 
            addStudent_picture.BackColor = SystemColors.ButtonShadow;
            addStudent_picture.BorderStyle = BorderStyle.FixedSingle;
            addStudent_picture.Location = new Point(1046, 60);
            addStudent_picture.Name = "addStudent_picture";
            addStudent_picture.Size = new Size(100, 117);
            addStudent_picture.TabIndex = 8;
            addStudent_picture.TabStop = false;
            addStudent_picture.Click += addStudent_picture_Click;
            // 
            // addStudent_number
            // 
            addStudent_number.Location = new Point(616, 45);
            addStudent_number.Name = "addStudent_number";
            addStudent_number.Size = new Size(212, 27);
            addStudent_number.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 51);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 6;
            label5.Text = "Phone Number";
            // 
            // addStudent_gender
            // 
            addStudent_gender.FormattingEnabled = true;
            addStudent_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            addStudent_gender.Location = new Point(158, 149);
            addStudent_gender.Name = "addStudent_gender";
            addStudent_gender.Size = new Size(212, 28);
            addStudent_gender.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(77, 152);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 4;
            label4.Text = "Gender";
            // 
            // addStudent_fullname
            // 
            addStudent_fullname.Location = new Point(158, 95);
            addStudent_fullname.Name = "addStudent_fullname";
            addStudent_fullname.Size = new Size(212, 27);
            addStudent_fullname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 98);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // addStudent_uid
            // 
            addStudent_uid.Location = new Point(158, 45);
            addStudent_uid.Name = "addStudent_uid";
            addStudent_uid.Size = new Size(212, 27);
            addStudent_uid.TabIndex = 1;
            addStudent_uid.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 48);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Student UID";
            // 
            // AddStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddStudents";
            Size = new Size(1211, 763);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addStudent_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox addStudent_fullname;
        private Label label3;
        private TextBox addStudent_uid;
        private Label label2;
        private Button addStudent_importbtn;
        private PictureBox addStudent_picture;
        private TextBox addStudent_number;
        private Label label5;
        private ComboBox addStudent_gender;
        private Button addStudent_deletebtn;
        private Button addStudent_clearbtn;
        private Button addStudent_updatebtn;
        private Button addStudent_addbtn;
        private Label label6;
        private ComboBox addStudent_status;
    }
}
