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
            this.lblDepartmentCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFacultyCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnshowStudents = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnShowFaculty = new System.Windows.Forms.Button();
            this.btnShowCourses = new System.Windows.Forms.Button();
            this.btnShowDept = new System.Windows.Forms.Button();
            this.ShowData = new System.Windows.Forms.DataGridView();
            this.btnViewProfile = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.Location = new System.Drawing.Point(148, 1);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(43, 43);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 463);
            this.panel1.TabIndex = 8;
            // 
            // AssignCourseLbl
            // 
            this.AssignCourseLbl.AutoSize = true;
            this.AssignCourseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignCourseLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AssignCourseLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignCourseLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AssignCourseLbl.Location = new System.Drawing.Point(9, 400);
            this.AssignCourseLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignCourseLbl.Name = "AssignCourseLbl";
            this.AssignCourseLbl.Size = new System.Drawing.Size(133, 22);
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
            this.DepartmentsLbl.Location = new System.Drawing.Point(9, 363);
            this.DepartmentsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DepartmentsLbl.Name = "DepartmentsLbl";
            this.DepartmentsLbl.Size = new System.Drawing.Size(122, 22);
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
            this.ClassscheduleLbl.Location = new System.Drawing.Point(9, 326);
            this.ClassscheduleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassscheduleLbl.Name = "ClassscheduleLbl";
            this.ClassscheduleLbl.Size = new System.Drawing.Size(138, 22);
            this.ClassscheduleLbl.TabIndex = 10;
            this.ClassscheduleLbl.Text = "Class Schedule";
            this.ClassscheduleLbl.Click += new System.EventHandler(this.ClassscheduleLbl_Click);
            // 
            // HeroLbl
            // 
            this.HeroLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeroLbl.AutoSize = true;
            this.HeroLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeroLbl.Font = new System.Drawing.Font("Luckiest Guy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeroLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeroLbl.Location = new System.Drawing.Point(21, 6);
            this.HeroLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeroLbl.Name = "HeroLbl";
            this.HeroLbl.Size = new System.Drawing.Size(106, 66);
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
            this.FacultyLbl.Location = new System.Drawing.Point(9, 291);
            this.FacultyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacultyLbl.Name = "FacultyLbl";
            this.FacultyLbl.Size = new System.Drawing.Size(74, 22);
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
            this.PaymentsLbl.Location = new System.Drawing.Point(9, 255);
            this.PaymentsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PaymentsLbl.Name = "PaymentsLbl";
            this.PaymentsLbl.Size = new System.Drawing.Size(96, 22);
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
            this.RegistrationLbl.Location = new System.Drawing.Point(9, 223);
            this.RegistrationLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationLbl.Name = "RegistrationLbl";
            this.RegistrationLbl.Size = new System.Drawing.Size(115, 22);
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
            this.CoursesLbl.Location = new System.Drawing.Point(9, 188);
            this.CoursesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoursesLbl.Name = "CoursesLbl";
            this.CoursesLbl.Size = new System.Drawing.Size(79, 22);
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
            this.studentLbl.Location = new System.Drawing.Point(9, 153);
            this.studentLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentLbl.Name = "studentLbl";
            this.studentLbl.Size = new System.Drawing.Size(86, 22);
            this.studentLbl.TabIndex = 5;
            this.studentLbl.Text = "Students";
            this.studentLbl.Click += new System.EventHandler(this.studentLbl_Click);
            // 
            // DashboardLbl
            // 
            this.DashboardLbl.AutoSize = true;
            this.DashboardLbl.BackColor = System.Drawing.Color.Teal;
            this.DashboardLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DashboardLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DashboardLbl.Location = new System.Drawing.Point(9, 121);
            this.DashboardLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DashboardLbl.Name = "DashboardLbl";
            this.DashboardLbl.Size = new System.Drawing.Size(103, 22);
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
            this.HomeLbl.Location = new System.Drawing.Point(9, 88);
            this.HomeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HomeLbl.Name = "HomeLbl";
            this.HomeLbl.Size = new System.Drawing.Size(61, 22);
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
            this.pictureBox1.Location = new System.Drawing.Point(803, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(581, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 30);
            this.textBox1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDepartmentCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(193, 141);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 86);
            this.panel2.TabIndex = 13;
            // 
            // lblDepartmentCount
            // 
            this.lblDepartmentCount.AutoSize = true;
            this.lblDepartmentCount.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentCount.Location = new System.Drawing.Point(56, 36);
            this.lblDepartmentCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartmentCount.Name = "lblDepartmentCount";
            this.lblDepartmentCount.Size = new System.Drawing.Size(53, 37);
            this.lblDepartmentCount.TabIndex = 15;
            this.lblDepartmentCount.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Departments";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblFacultyCount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(412, 141);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 86);
            this.panel3.TabIndex = 14;
            // 
            // lblFacultyCount
            // 
            this.lblFacultyCount.AutoSize = true;
            this.lblFacultyCount.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFacultyCount.Location = new System.Drawing.Point(57, 36);
            this.lblFacultyCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacultyCount.Name = "lblFacultyCount";
            this.lblFacultyCount.Size = new System.Drawing.Size(53, 37);
            this.lblFacultyCount.TabIndex = 15;
            this.lblFacultyCount.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total Faculty";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblStudentCount);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(629, 141);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 86);
            this.panel4.TabIndex = 14;
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCount.Location = new System.Drawing.Point(61, 36);
            this.lblStudentCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(53, 37);
            this.lblStudentCount.TabIndex = 15;
            this.lblStudentCount.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Students";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.lblName);
            this.panel5.Controls.Add(this.label7);
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(196, 41);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(609, 90);
            this.panel5.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(497, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(12, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 26);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "welcome Back,";
            // 
            // BtnshowStudents
            // 
            this.BtnshowStudents.BackColor = System.Drawing.Color.Teal;
            this.BtnshowStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnshowStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnshowStudents.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnshowStudents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnshowStudents.Location = new System.Drawing.Point(2, 3);
            this.BtnshowStudents.Name = "BtnshowStudents";
            this.BtnshowStudents.Size = new System.Drawing.Size(167, 31);
            this.BtnshowStudents.TabIndex = 19;
            this.BtnshowStudents.Text = "Show Students";
            this.BtnshowStudents.UseVisualStyleBackColor = false;
            this.BtnshowStudents.Click += new System.EventHandler(this.BtnshowStudents_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnShowFaculty);
            this.panel6.Controls.Add(this.btnShowCourses);
            this.panel6.Controls.Add(this.btnShowDept);
            this.panel6.Controls.Add(this.BtnshowStudents);
            this.panel6.Location = new System.Drawing.Point(193, 246);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(173, 150);
            this.panel6.TabIndex = 20;
            // 
            // btnShowFaculty
            // 
            this.btnShowFaculty.BackColor = System.Drawing.Color.Teal;
            this.btnShowFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFaculty.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFaculty.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowFaculty.Location = new System.Drawing.Point(1, 114);
            this.btnShowFaculty.Name = "btnShowFaculty";
            this.btnShowFaculty.Size = new System.Drawing.Size(167, 31);
            this.btnShowFaculty.TabIndex = 20;
            this.btnShowFaculty.Text = "Show Faculty";
            this.btnShowFaculty.UseVisualStyleBackColor = false;
            this.btnShowFaculty.Click += new System.EventHandler(this.btnShowFaculty_Click);
            // 
            // btnShowCourses
            // 
            this.btnShowCourses.BackColor = System.Drawing.Color.Teal;
            this.btnShowCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCourses.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCourses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowCourses.Location = new System.Drawing.Point(2, 77);
            this.btnShowCourses.Name = "btnShowCourses";
            this.btnShowCourses.Size = new System.Drawing.Size(167, 31);
            this.btnShowCourses.TabIndex = 20;
            this.btnShowCourses.Text = "Show Courses";
            this.btnShowCourses.UseVisualStyleBackColor = false;
            this.btnShowCourses.Click += new System.EventHandler(this.btnShowCourses_Click);
            // 
            // btnShowDept
            // 
            this.btnShowDept.BackColor = System.Drawing.Color.Teal;
            this.btnShowDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDept.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowDept.Location = new System.Drawing.Point(2, 40);
            this.btnShowDept.Name = "btnShowDept";
            this.btnShowDept.Size = new System.Drawing.Size(167, 31);
            this.btnShowDept.TabIndex = 20;
            this.btnShowDept.Text = "Show Departments";
            this.btnShowDept.UseVisualStyleBackColor = false;
            this.btnShowDept.Click += new System.EventHandler(this.btnShowDept_Click);
            // 
            // ShowData
            // 
            this.ShowData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowData.Location = new System.Drawing.Point(412, 238);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(390, 172);
            this.ShowData.TabIndex = 21;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.AutoSize = true;
            this.btnViewProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewProfile.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewProfile.Location = new System.Drawing.Point(369, 11);
            this.btnViewProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(98, 22);
            this.btnViewProfile.TabIndex = 13;
            this.btnViewProfile.Text = "My Profile";
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogOut.Location = new System.Drawing.Point(488, 11);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(79, 22);
            this.btnLogOut.TabIndex = 22;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.AutoSize = true;
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBtn.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refreshBtn.Location = new System.Drawing.Point(285, 11);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(77, 22);
            this.refreshBtn.TabIndex = 23;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 432);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
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
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).EndInit();
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
        private System.Windows.Forms.Label lblDepartmentCount;
        private System.Windows.Forms.Label lblFacultyCount;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button BtnshowStudents;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnShowDept;
        private System.Windows.Forms.DataGridView ShowData;
        private System.Windows.Forms.Button btnShowFaculty;
        private System.Windows.Forms.Button btnShowCourses;
        private System.Windows.Forms.Label btnViewProfile;
        private System.Windows.Forms.Label btnLogOut;
        private System.Windows.Forms.Label refreshBtn;
    }
}