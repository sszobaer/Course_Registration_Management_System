namespace CRMS
{
    partial class CourseRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseRegistration));
            this.selectCoursesData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registeredCoursesData = new System.Windows.Forms.DataGridView();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectCoursesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredCoursesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCoursesData
            // 
            this.selectCoursesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectCoursesData.Location = new System.Drawing.Point(12, 56);
            this.selectCoursesData.Name = "selectCoursesData";
            this.selectCoursesData.Size = new System.Drawing.Size(776, 130);
            this.selectCoursesData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(331, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(311, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registered Courses";
            // 
            // registeredCoursesData
            // 
            this.registeredCoursesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registeredCoursesData.Location = new System.Drawing.Point(12, 275);
            this.registeredCoursesData.Name = "registeredCoursesData";
            this.registeredCoursesData.Size = new System.Drawing.Size(776, 130);
            this.registeredCoursesData.TabIndex = 2;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Teal;
            this.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCourse.Location = new System.Drawing.Point(12, 192);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(776, 34);
            this.btnAddCourse.TabIndex = 36;
            this.btnAddCourse.Text = "Add the course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.BackColor = System.Drawing.Color.Teal;
            this.btnRemoveCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCourse.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveCourse.Location = new System.Drawing.Point(12, 411);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(776, 34);
            this.btnRemoveCourse.TabIndex = 37;
            this.btnRemoveCourse.Text = "Remove the  course";
            this.btnRemoveCourse.UseVisualStyleBackColor = false;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.Location = new System.Drawing.Point(12, 5);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(43, 43);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBtn.TabIndex = 38;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registeredCoursesData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectCoursesData);
            this.Name = "CourseRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.selectCoursesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredCoursesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView selectCoursesData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView registeredCoursesData;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.PictureBox BackBtn;
    }
}