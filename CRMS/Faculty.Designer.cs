namespace CRMS
{
    partial class Faculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faculty));
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
            this.ShowData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDeptName = new System.Windows.Forms.ComboBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtFid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDeleteFID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.Location = new System.Drawing.Point(146, 2);
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
            this.panel1.Location = new System.Drawing.Point(-2, 0);
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
            this.FacultyLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.DashboardLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DashboardLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // ShowData
            // 
            this.ShowData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowData.Location = new System.Drawing.Point(506, 186);
            this.ShowData.Margin = new System.Windows.Forms.Padding(2);
            this.ShowData.Name = "ShowData";
            this.ShowData.RowHeadersWidth = 62;
            this.ShowData.RowTemplate.Height = 28;
            this.ShowData.Size = new System.Drawing.Size(304, 227);
            this.ShowData.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbDeptName);
            this.panel2.Controls.Add(this.cbPosition);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtFname);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.InsertBtn);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.txtFid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(173, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 365);
            this.panel2.TabIndex = 20;
            // 
            // cbDeptName
            // 
            this.cbDeptName.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeptName.FormattingEnabled = true;
            this.cbDeptName.Location = new System.Drawing.Point(26, 196);
            this.cbDeptName.Margin = new System.Windows.Forms.Padding(2);
            this.cbDeptName.Name = "cbDeptName";
            this.cbDeptName.Size = new System.Drawing.Size(253, 30);
            this.cbDeptName.TabIndex = 29;
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer",
            "Instructor",
            "Senior Lecturer",
            "Adjunct Faculty",
            "Visiting Professor",
            "Teaching Assistant (TA)",
            "Research Professor",
            "Research Assistant (RA)"});
            this.cbPosition.Location = new System.Drawing.Point(27, 149);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(253, 30);
            this.cbPosition.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(26, 245);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(253, 26);
            this.txtPhone.TabIndex = 27;
            // 
            // txtFname
            // 
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(26, 101);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(253, 26);
            this.txtFname.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 269);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Department Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Faculty Member Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Faculty Member Id";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Teal;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateBtn.Location = new System.Drawing.Point(157, 322);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(99, 34);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.Teal;
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InsertBtn.Location = new System.Drawing.Point(53, 322);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(99, 34);
            this.InsertBtn.TabIndex = 16;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(26, 290);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(253, 26);
            this.txtemail.TabIndex = 27;
            // 
            // txtFid
            // 
            this.txtFid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFid.Location = new System.Drawing.Point(26, 53);
            this.txtFid.Name = "txtFid";
            this.txtFid.Size = new System.Drawing.Size(253, 26);
            this.txtFid.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(59, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(38, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Search or Delete Faculty";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Teal;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBtn.Location = new System.Drawing.Point(157, 81);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(99, 34);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Faculty Id";
            // 
            // txtDeleteFID
            // 
            this.txtDeleteFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeleteFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteFID.Location = new System.Drawing.Point(24, 52);
            this.txtDeleteFID.Name = "txtDeleteFID";
            this.txtDeleteFID.Size = new System.Drawing.Size(253, 26);
            this.txtDeleteFID.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.txtDeleteFID);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.DeleteBtn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(506, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 125);
            this.panel3.TabIndex = 21;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Teal;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.Location = new System.Drawing.Point(45, 81);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 34);
            this.searchBtn.TabIndex = 30;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 432);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Faculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty";
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView ShowData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtFid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDeptName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDeleteFID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button searchBtn;
    }
}