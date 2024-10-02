namespace StudentManagementSystem
{
    partial class UID
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
            uid_clearbtn = new Button();
            uid_updatebtn = new Button();
            uid_studentbranch = new TextBox();
            label5 = new Label();
            uid_studentyear = new TextBox();
            label4 = new Label();
            uid_studentname = new TextBox();
            label3 = new Label();
            uid_studentID = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(uid_clearbtn);
            panel1.Controls.Add(uid_updatebtn);
            panel1.Controls.Add(uid_studentbranch);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(uid_studentyear);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(uid_studentname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(uid_studentID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 728);
            panel1.TabIndex = 0;
            // 
            // uid_clearbtn
            // 
            uid_clearbtn.BackColor = Color.DarkSlateBlue;
            uid_clearbtn.ForeColor = Color.White;
            uid_clearbtn.Location = new Point(171, 414);
            uid_clearbtn.Name = "uid_clearbtn";
            uid_clearbtn.Size = new Size(111, 58);
            uid_clearbtn.TabIndex = 9;
            uid_clearbtn.Text = "Clear";
            uid_clearbtn.UseVisualStyleBackColor = false;
            uid_clearbtn.Click += button2_Click;
            // 
            // uid_updatebtn
            // 
            uid_updatebtn.BackColor = Color.DarkSlateBlue;
            uid_updatebtn.ForeColor = Color.White;
            uid_updatebtn.Location = new Point(26, 414);
            uid_updatebtn.Name = "uid_updatebtn";
            uid_updatebtn.Size = new Size(111, 58);
            uid_updatebtn.TabIndex = 8;
            uid_updatebtn.Text = "Update";
            uid_updatebtn.UseVisualStyleBackColor = false;
            uid_updatebtn.Click += uid_updatebtn_Click;
            // 
            // uid_studentbranch
            // 
            uid_studentbranch.Location = new Point(38, 309);
            uid_studentbranch.Name = "uid_studentbranch";
            uid_studentbranch.Size = new Size(244, 27);
            uid_studentbranch.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 288);
            label5.Name = "label5";
            label5.Size = new Size(63, 18);
            label5.TabIndex = 6;
            label5.Text = "Branch :";
            // 
            // uid_studentyear
            // 
            uid_studentyear.Location = new Point(38, 238);
            uid_studentyear.Name = "uid_studentyear";
            uid_studentyear.Size = new Size(244, 27);
            uid_studentyear.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 217);
            label4.Name = "label4";
            label4.Size = new Size(118, 18);
            label4.TabIndex = 4;
            label4.Text = "Admission Year :";
            // 
            // uid_studentname
            // 
            uid_studentname.Location = new Point(38, 162);
            uid_studentname.Name = "uid_studentname";
            uid_studentname.Size = new Size(244, 27);
            uid_studentname.TabIndex = 3;
            uid_studentname.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 141);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 2;
            label3.Text = "Full Name :";
            // 
            // uid_studentID
            // 
            uid_studentID.Location = new Point(38, 87);
            uid_studentID.Name = "uid_studentID";
            uid_studentID.Size = new Size(244, 27);
            uid_studentID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 66);
            label2.Name = "label2";
            label2.Size = new Size(99, 18);
            label2.TabIndex = 0;
            label2.Text = "Student UID :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(352, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(840, 728);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(794, 638);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // UID
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UID";
            Size = new Size(1209, 761);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox uid_studentname;
        private Label label3;
        private TextBox uid_studentID;
        private Label label2;
        private TextBox uid_studentbranch;
        private Label label5;
        private TextBox uid_studentyear;
        private Label label4;
        private Button uid_clearbtn;
        private Button uid_updatebtn;
    }
}
