namespace CRMS
{
    partial class studentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentDashboard));
            this.registrationBtn = new System.Windows.Forms.Button();
            this.offeredCoursesBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.AiAdvisorBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationBtn
            // 
            this.registrationBtn.BackColor = System.Drawing.Color.Teal;
            this.registrationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registrationBtn.Location = new System.Drawing.Point(8, 6);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(178, 31);
            this.registrationBtn.TabIndex = 23;
            this.registrationBtn.Text = "Registration";
            this.registrationBtn.UseVisualStyleBackColor = false;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // offeredCoursesBtn
            // 
            this.offeredCoursesBtn.BackColor = System.Drawing.Color.Teal;
            this.offeredCoursesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offeredCoursesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offeredCoursesBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offeredCoursesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.offeredCoursesBtn.Location = new System.Drawing.Point(8, 43);
            this.offeredCoursesBtn.Name = "offeredCoursesBtn";
            this.offeredCoursesBtn.Size = new System.Drawing.Size(178, 31);
            this.offeredCoursesBtn.TabIndex = 23;
            this.offeredCoursesBtn.Text = "Offered Courses";
            this.offeredCoursesBtn.UseVisualStyleBackColor = false;
            this.offeredCoursesBtn.Click += new System.EventHandler(this.offeredCoursesBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Edit your personal information and address";
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.Location = new System.Drawing.Point(17, 16);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(43, 43);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBtn.TabIndex = 27;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Teal;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateBtn.Location = new System.Drawing.Point(25, 325);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(157, 34);
            this.updateBtn.TabIndex = 36;
            this.updateBtn.Text = "Update Profile";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(274, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 26);
            this.label8.TabIndex = 35;
            this.label8.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 26);
            this.label7.TabIndex = 35;
            this.label7.Text = "Program";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 26);
            this.label5.TabIndex = 35;
            this.label5.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(143, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 37);
            this.label4.TabIndex = 34;
            this.label4.Text = "Personal Details";
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(279, 276);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(233, 26);
            this.txtStatus.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(279, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 26);
            this.txtEmail.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(279, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 26);
            this.txtName.TabIndex = 33;
            // 
            // txtProgram
            // 
            this.txtProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgram.Location = new System.Drawing.Point(25, 276);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ReadOnly = true;
            this.txtProgram.Size = new System.Drawing.Size(233, 26);
            this.txtProgram.TabIndex = 33;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(25, 193);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(233, 26);
            this.txtPhoneNo.TabIndex = 33;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(25, 108);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(233, 26);
            this.txtID.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtProgram);
            this.panel2.Controls.Add(this.txtPhoneNo);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Location = new System.Drawing.Point(243, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 373);
            this.panel2.TabIndex = 26;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(9, 175);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(99, 22);
            this.lblPhoneNo.TabIndex = 4;
            this.lblPhoneNo.Text = "Phone No";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 22);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // profilePic
            // 
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePic.Location = new System.Drawing.Point(46, 14);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(100, 92);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 2;
            this.profilePic.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.registrationBtn);
            this.panel3.Controls.Add(this.changePasswordBtn);
            this.panel3.Controls.Add(this.AiAdvisorBtn);
            this.panel3.Controls.Add(this.offeredCoursesBtn);
            this.panel3.Location = new System.Drawing.Point(17, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 153);
            this.panel3.TabIndex = 28;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.Teal;
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changePasswordBtn.Location = new System.Drawing.Point(8, 115);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(178, 31);
            this.changePasswordBtn.TabIndex = 23;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // AiAdvisorBtn
            // 
            this.AiAdvisorBtn.BackColor = System.Drawing.Color.Teal;
            this.AiAdvisorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AiAdvisorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiAdvisorBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AiAdvisorBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AiAdvisorBtn.Location = new System.Drawing.Point(8, 80);
            this.AiAdvisorBtn.Name = "AiAdvisorBtn";
            this.AiAdvisorBtn.Size = new System.Drawing.Size(178, 31);
            this.AiAdvisorBtn.TabIndex = 23;
            this.AiAdvisorBtn.Text = "Artificial Advisor";
            this.AiAdvisorBtn.UseVisualStyleBackColor = false;
            this.AiAdvisorBtn.Click += new System.EventHandler(this.AiAdvisorBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPhoneNo);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.profilePic);
            this.panel1.Location = new System.Drawing.Point(17, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 214);
            this.panel1.TabIndex = 25;
            // 
            // studentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "studentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentDashboard";
            this.Load += new System.EventHandler(this.studentDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registrationBtn;
        private System.Windows.Forms.Button offeredCoursesBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Button AiAdvisorBtn;
    }
}