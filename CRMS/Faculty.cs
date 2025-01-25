﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMS
{
    public partial class Faculty : Form
    {
        private Functions dbFunctions = new Functions();
        public Faculty()
        {
            InitializeComponent();
            ConfigureDataGridView();
            GetDept();
            GetFacultyMembers();
        }
        private void GetDept()
        {
            string query = "SELECT deptName, deptID FROM  Department";
            DataTable dt = dbFunctions.GetData(query);

            if (dt.Rows.Count > 0)
            {
                cbDeptName.DataSource = null;
                cbDeptName.Items.Clear();
                cbDeptName.DisplayMember = "deptName";
                cbDeptName.ValueMember = "deptID";
                cbDeptName.DataSource = dt;
            }
        }
        private void GetFacultyMembers()
        {
            string Query = "SELECT * FROM Facultymember";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string facultyId=txtFid.Text;
            string facultyName = txtFname.Text;
            string facultyEmail = txtemail.Text;
            string facultyPhone = txtPhone.Text;
            int facultyDept = Convert.ToInt32(cbDeptName.SelectedValue.ToString());
            string facultyPosition = cbPosition.Text;

            try
            {
                // Validate fields
                if (string.IsNullOrWhiteSpace(facultyId) || string.IsNullOrWhiteSpace(facultyName) || cbDeptName.SelectedIndex == -1 || 
                    string.IsNullOrWhiteSpace(facultyEmail) || string.IsNullOrWhiteSpace(facultyPhone) || cbPosition.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out all the fields before proceeding.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string Query = "INSERT INTO Facultymember (facultyId, facultyName, position, deptId, faculty_phone1,faculty_phone2, faculty_email1, faculty_email2) VALUES (:facultyId, :facultyName, :position, :deptId, :faculty_phone1, :faculty_phone2, :faculty_email1, :faculty_email2)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "facultyId", facultyId },
                    { "facultyName", facultyName },
                    { "position", facultyPosition },
                    { "deptId", facultyDept},
                    { "faculty_phone1", facultyPhone },
                    { "faculty_phone2", DBNull.Value },
                    { "faculty_email1", facultyEmail },
                    { "faculty_email2", DBNull.Value }

                };

                // Execute query
                dbFunctions.setData(Query, parameters);

                // Success message
                MessageBox.Show("New faculty member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetFacultyMembers();
                facultyId = "";
                facultyName = "";
                facultyEmail = "";
                facultyPhone = "";
                facultyDept = 0;
                facultyPosition = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid data format. Please check your inputs and try again.", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void HomeLbl_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Home.stack.Push(this);
            this.Hide();
            home.ShowDialog();
            this.Show();
        }

        private void DashboardLbl_Click(object sender, EventArgs e)
        {
            if (SessionManager.IsLoggedIn)
            {
                Dashboard dashboard = new Dashboard(SessionManager.AdminName);
                Home.stack.Push(this);
                this.Hide();
                dashboard.ShowDialog();
                this.Show();
            }
        }

        private void studentLbl_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            Home.stack.Push(this);
            this.Hide();
            students.ShowDialog();
            this.Show();
        }

        private void CoursesLbl_Click(object sender, EventArgs e)
        {
            Courses course = new Courses();
            Home.stack.Push(this);
            this.Hide();
            course.ShowDialog();
            this.Show();
        }

        private void RegistrationLbl_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            Home.stack.Push(this);
            this.Hide();
            registration.ShowDialog();
            this.Show();
        }

        private void PaymentsLbl_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            Home.stack.Push(this);
            this.Hide();
            payments.ShowDialog();
            this.Show();
        }

        private void FacultyLbl_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();
            Home.stack.Push(this);
            this.Hide();
            faculty.ShowDialog();
            this.Show();
        }

        private void ClassscheduleLbl_Click(object sender, EventArgs e)
        {
            ClassSchedule classSchedule = new ClassSchedule();
            Home.stack.Push(this);
            this.Hide();
            classSchedule.ShowDialog();
            this.Show();
        }

        private void DepartmentsLbl_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            Home.stack.Push(this);
            this.Hide();
            departments.ShowDialog();
            this.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void AssignCourseLbl_Click(object sender, EventArgs e)
        {
            AssignCourse assignCourse = new AssignCourse();
            Home.stack.Push(this);
            this.Hide();
            assignCourse.ShowDialog();
            this.Show();
        }
        private void ConfigureDataGridView()
        {
            // Set alternating row colors for readability
            ShowData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set header styles
            ShowData.EnableHeadersVisualStyles = false;
            ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            ShowData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            ShowData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Set grid line color
            ShowData.GridColor = Color.Black;

            // Set default row styles
            ShowData.DefaultCellStyle.BackColor = Color.White;
            ShowData.DefaultCellStyle.ForeColor = Color.Black;
            ShowData.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Set selection styles
            ShowData.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            ShowData.DefaultCellStyle.SelectionForeColor = Color.White;

            // Disable column resizing by users
            ShowData.AllowUserToResizeColumns = false;

            // Enable horizontal scrolling
            ShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            ShowData.ScrollBars = ScrollBars.Both;

            // Adjust column width to content
            foreach (DataGridViewColumn column in ShowData.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Adjust width to fit content
            }

            // Adjust row height to fit content
            ShowData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable row headers to remove the extra column at index 0
            ShowData.RowHeadersVisible = false;

            // Ensure column headers are visible
            ShowData.ColumnHeadersVisible = true;
        }
    }
}
