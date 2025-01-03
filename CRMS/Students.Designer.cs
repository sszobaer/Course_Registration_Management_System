﻿namespace CRMS
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.enrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDeleteID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StudentsGridView = new System.Windows.Forms.DataGridView();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.Location = new System.Drawing.Point(223, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(64, 66);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBtn.TabIndex = 15;
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
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 712);
            this.panel1.TabIndex = 14;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(105, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Students";
            // 
            // txtSid
            // 
            this.txtSid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSid.Location = new System.Drawing.Point(39, 70);
            this.txtSid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(378, 35);
            this.txtSid.TabIndex = 27;
            this.txtSid.Enter += new System.EventHandler(this.txtSid_Enter);
            this.txtSid.Leave += new System.EventHandler(this.txtSid_Leave);
            // 
            // txtSname
            // 
            this.txtSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(39, 115);
            this.txtSname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(378, 35);
            this.txtSname.TabIndex = 27;
            this.txtSname.Enter += new System.EventHandler(this.txtSname_Enter);
            this.txtSname.Leave += new System.EventHandler(this.txtSname_Leave);
            // 
            // txtProgram
            // 
            this.txtProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgram.Location = new System.Drawing.Point(39, 160);
            this.txtProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(378, 35);
            this.txtProgram.TabIndex = 27;
            this.txtProgram.Enter += new System.EventHandler(this.txtProgram_Enter);
            this.txtProgram.Leave += new System.EventHandler(this.txtProgram_Leave);
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(39, 248);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(378, 35);
            this.txtStatus.TabIndex = 27;
            this.txtStatus.Enter += new System.EventHandler(this.txtStatus_Enter);
            this.txtStatus.Leave += new System.EventHandler(this.txtStatus_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(39, 293);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(378, 35);
            this.txtAddress.TabIndex = 27;
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(39, 338);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(378, 35);
            this.txtPhoneNo.TabIndex = 27;
            this.txtPhoneNo.Enter += new System.EventHandler(this.txtPhoneNo_Enter);
            this.txtPhoneNo.Leave += new System.EventHandler(this.txtPhoneNo_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(39, 383);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(378, 35);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // cbDept
            // 
            this.cbDept.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(39, 426);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(378, 38);
            this.cbDept.TabIndex = 28;
            this.cbDept.Enter += new System.EventHandler(this.cbDept_Enter);
            this.cbDept.Leave += new System.EventHandler(this.cbDept_Leave);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.Teal;
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InsertBtn.Location = new System.Drawing.Point(76, 482);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(149, 53);
            this.InsertBtn.TabIndex = 16;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Teal;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateBtn.Location = new System.Drawing.Point(233, 482);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(149, 53);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // enrollmentDate
            // 
            this.enrollmentDate.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentDate.Location = new System.Drawing.Point(39, 203);
            this.enrollmentDate.Name = "enrollmentDate";
            this.enrollmentDate.Size = new System.Drawing.Size(378, 37);
            this.enrollmentDate.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.enrollmentDate);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.InsertBtn);
            this.panel2.Controls.Add(this.cbDept);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtPhoneNo);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.txtProgram);
            this.panel2.Controls.Add(this.txtSname);
            this.panel2.Controls.Add(this.txtSid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(259, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 561);
            this.panel2.TabIndex = 10;
            // 
            // txtDeleteID
            // 
            this.txtDeleteID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeleteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteID.Location = new System.Drawing.Point(36, 57);
            this.txtDeleteID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeleteID.Name = "txtDeleteID";
            this.txtDeleteID.Size = new System.Drawing.Size(378, 35);
            this.txtDeleteID.TabIndex = 27;
            this.txtDeleteID.Enter += new System.EventHandler(this.txtDeleteID_Enter);
            this.txtDeleteID.Leave += new System.EventHandler(this.txtDeleteID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(130, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 33);
            this.label2.TabIndex = 29;
            this.label2.Text = "Delete Student";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Teal;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBtn.Location = new System.Drawing.Point(149, 102);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(149, 53);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DeleteBtn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtDeleteID);
            this.panel3.Location = new System.Drawing.Point(759, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 169);
            this.panel3.TabIndex = 11;
            // 
            // StudentsGridView
            // 
            this.StudentsGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.StudentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGridView.Location = new System.Drawing.Point(759, 446);
            this.StudentsGridView.Name = "StudentsGridView";
            this.StudentsGridView.RowHeadersWidth = 62;
            this.StudentsGridView.RowTemplate.Height = 28;
            this.StudentsGridView.Size = new System.Drawing.Size(456, 190);
            this.StudentsGridView.TabIndex = 13;
            // 
            // txtSearchID
            // 
            this.txtSearchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchID.Location = new System.Drawing.Point(36, 57);
            this.txtSearchID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(378, 35);
            this.txtSearchID.TabIndex = 27;
            this.txtSearchID.Enter += new System.EventHandler(this.txtSearchID_Enter);
            this.txtSearchID.Leave += new System.EventHandler(this.txtSearchID_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(130, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "Search Student";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Teal;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchBtn.Location = new System.Drawing.Point(149, 102);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(149, 53);
            this.SearchBtn.TabIndex = 16;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.SearchBtn);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtSearchID);
            this.panel4.Location = new System.Drawing.Point(759, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 169);
            this.panel4.TabIndex = 16;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentsGridView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DateTimePicker enrollmentDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDeleteID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView StudentsGridView;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Panel panel4;
    }
}