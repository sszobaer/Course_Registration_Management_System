namespace CRMS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AssignCourseLbl = new System.Windows.Forms.Label();
            this.DepartmentsLbl = new System.Windows.Forms.Label();
            this.ClassscheduleLbl = new System.Windows.Forms.Label();
            this.HeroLbl = new System.Windows.Forms.Label();
            this.FacultyLbl = new System.Windows.Forms.Label();
            this.PaymentsLbl = new System.Windows.Forms.Label();
            this.RegistrationLbl = new System.Windows.Forms.Label();
            this.CoursesLbl = new System.Windows.Forms.Label();
            this.studentLbl = new System.Windows.Forms.Label();
            this.DashboardLbl = new System.Windows.Forms.Label();
            this.HomeLbl = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.Location = new System.Drawing.Point(222, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(64, 66);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBtn.TabIndex = 9;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.AssignCourseLbl);
            this.panel1.Controls.Add(this.DepartmentsLbl);
            this.panel1.Controls.Add(this.ClassscheduleLbl);
            this.panel1.Controls.Add(this.HeroLbl);
            this.panel1.Controls.Add(this.FacultyLbl);
            this.panel1.Controls.Add(this.PaymentsLbl);
            this.panel1.Controls.Add(this.RegistrationLbl);
            this.panel1.Controls.Add(this.CoursesLbl);
            this.panel1.Controls.Add(this.studentLbl);
            this.panel1.Controls.Add(this.DashboardLbl);
            this.panel1.Controls.Add(this.HomeLbl);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 712);
            this.panel1.TabIndex = 8;
            // 
            // AssignCourseLbl
            // 
            this.AssignCourseLbl.AutoSize = true;
            this.AssignCourseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignCourseLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AssignCourseLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignCourseLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AssignCourseLbl.Location = new System.Drawing.Point(14, 615);
            this.AssignCourseLbl.Name = "AssignCourseLbl";
            this.AssignCourseLbl.Size = new System.Drawing.Size(199, 33);
            this.AssignCourseLbl.TabIndex = 12;
            this.AssignCourseLbl.Text = "Assign Course";
            this.AssignCourseLbl.Click += new System.EventHandler(this.AssignCourseLbl_Click);
            // 
            // DepartmentsLbl
            // 
            this.DepartmentsLbl.AutoSize = true;
            this.DepartmentsLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepartmentsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepartmentsLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentsLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DepartmentsLbl.Location = new System.Drawing.Point(14, 559);
            this.DepartmentsLbl.Name = "DepartmentsLbl";
            this.DepartmentsLbl.Size = new System.Drawing.Size(185, 33);
            this.DepartmentsLbl.TabIndex = 11;
            this.DepartmentsLbl.Text = "Departments";
            this.DepartmentsLbl.Click += new System.EventHandler(this.DepartmentsLbl_Click);
            // 
            // ClassscheduleLbl
            // 
            this.ClassscheduleLbl.AutoSize = true;
            this.ClassscheduleLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassscheduleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClassscheduleLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassscheduleLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassscheduleLbl.Location = new System.Drawing.Point(14, 501);
            this.ClassscheduleLbl.Name = "ClassscheduleLbl";
            this.ClassscheduleLbl.Size = new System.Drawing.Size(208, 33);
            this.ClassscheduleLbl.TabIndex = 10;
            this.ClassscheduleLbl.Text = "Class Schedule";
            this.ClassscheduleLbl.Click += new System.EventHandler(this.ClassscheduleLbl_Click);
            // 
            // HeroLbl
            // 
            this.HeroLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeroLbl.AutoSize = true;
            this.HeroLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeroLbl.Font = new System.Drawing.Font("Luckiest Guy", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeroLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeroLbl.Location = new System.Drawing.Point(31, 10);
            this.HeroLbl.Name = "HeroLbl";
            this.HeroLbl.Size = new System.Drawing.Size(158, 98);
            this.HeroLbl.TabIndex = 3;
            this.HeroLbl.Text = "CRMS\r\nPORTAL\r\n";
            this.HeroLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FacultyLbl
            // 
            this.FacultyLbl.AutoSize = true;
            this.FacultyLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FacultyLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FacultyLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FacultyLbl.Location = new System.Drawing.Point(14, 447);
            this.FacultyLbl.Name = "FacultyLbl";
            this.FacultyLbl.Size = new System.Drawing.Size(111, 33);
            this.FacultyLbl.TabIndex = 9;
            this.FacultyLbl.Text = "Faculty";
            this.FacultyLbl.Click += new System.EventHandler(this.FacultyLbl_Click);
            // 
            // PaymentsLbl
            // 
            this.PaymentsLbl.AutoSize = true;
            this.PaymentsLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PaymentsLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PaymentsLbl.Location = new System.Drawing.Point(14, 393);
            this.PaymentsLbl.Name = "PaymentsLbl";
            this.PaymentsLbl.Size = new System.Drawing.Size(144, 33);
            this.PaymentsLbl.TabIndex = 8;
            this.PaymentsLbl.Text = "Payments";
            this.PaymentsLbl.Click += new System.EventHandler(this.PaymentsLbl_Click);
            // 
            // RegistrationLbl
            // 
            this.RegistrationLbl.AutoSize = true;
            this.RegistrationLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrationLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistrationLbl.Location = new System.Drawing.Point(14, 343);
            this.RegistrationLbl.Name = "RegistrationLbl";
            this.RegistrationLbl.Size = new System.Drawing.Size(175, 33);
            this.RegistrationLbl.TabIndex = 7;
            this.RegistrationLbl.Text = "Registration";
            this.RegistrationLbl.Click += new System.EventHandler(this.RegistrationLbl_Click);
            // 
            // CoursesLbl
            // 
            this.CoursesLbl.AutoSize = true;
            this.CoursesLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CoursesLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CoursesLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CoursesLbl.Location = new System.Drawing.Point(14, 290);
            this.CoursesLbl.Name = "CoursesLbl";
            this.CoursesLbl.Size = new System.Drawing.Size(118, 33);
            this.CoursesLbl.TabIndex = 6;
            this.CoursesLbl.Text = "Courses";
            this.CoursesLbl.Click += new System.EventHandler(this.CoursesLbl_Click);
            // 
            // studentLbl
            // 
            this.studentLbl.AutoSize = true;
            this.studentLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentLbl.Location = new System.Drawing.Point(14, 236);
            this.studentLbl.Name = "studentLbl";
            this.studentLbl.Size = new System.Drawing.Size(132, 33);
            this.studentLbl.TabIndex = 5;
            this.studentLbl.Text = "Students";
            this.studentLbl.Click += new System.EventHandler(this.studentLbl_Click);
            // 
            // DashboardLbl
            // 
            this.DashboardLbl.AutoSize = true;
            this.DashboardLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DashboardLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DashboardLbl.Location = new System.Drawing.Point(14, 186);
            this.DashboardLbl.Name = "DashboardLbl";
            this.DashboardLbl.Size = new System.Drawing.Size(156, 33);
            this.DashboardLbl.TabIndex = 4;
            this.DashboardLbl.Text = "Dashboard";
            this.DashboardLbl.Click += new System.EventHandler(this.DashboardLbl_Click);
            // 
            // HomeLbl
            // 
            this.HomeLbl.AutoSize = true;
            this.HomeLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeLbl.Location = new System.Drawing.Point(14, 135);
            this.HomeLbl.Name = "HomeLbl";
            this.HomeLbl.Size = new System.Drawing.Size(90, 33);
            this.HomeLbl.TabIndex = 2;
            this.HomeLbl.Text = "Home";
            this.HomeLbl.Click += new System.EventHandler(this.HomeLbl_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1204, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(871, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 42);
            this.textBox1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(289, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 131);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(618, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 131);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(944, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 131);
            this.panel4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Departments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(37, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total Faculty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Students";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 55);
            this.label4.TabIndex = 15;
            this.label4.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(86, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 55);
            this.label5.TabIndex = 15;
            this.label5.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 55);
            this.label6.TabIndex = 15;
            this.label6.Text = "00";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(289, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(913, 138);
            this.panel5.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(18, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 39);
            this.label7.TabIndex = 16;
            this.label7.Text = "welcome Back,";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(18, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 39);
            this.label8.TabIndex = 17;
            this.label8.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(745, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Teal;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBtn.Location = new System.Drawing.Point(289, 382);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(258, 53);
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "Show Departments";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(618, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Show Faculty";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(944, 382);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 53);
            this.button2.TabIndex = 19;
            this.button2.Text = "Show Students";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 446);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(913, 201);
            this.dataGridView1.TabIndex = 20;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AssignCourseLbl;
        private System.Windows.Forms.Label DepartmentsLbl;
        private System.Windows.Forms.Label ClassscheduleLbl;
        private System.Windows.Forms.Label HeroLbl;
        private System.Windows.Forms.Label FacultyLbl;
        private System.Windows.Forms.Label PaymentsLbl;
        private System.Windows.Forms.Label RegistrationLbl;
        private System.Windows.Forms.Label CoursesLbl;
        private System.Windows.Forms.Label studentLbl;
        private System.Windows.Forms.Label DashboardLbl;
        private System.Windows.Forms.Label HomeLbl;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}