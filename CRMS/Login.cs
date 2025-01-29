using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CRMS
{
    public partial class Login : Form
    {
        private Functions dbFunctions = new Functions();

        public Login()
        {
            InitializeComponent();
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(txtID.Text);
            string userPassword = txtPassword.Text;
            //Verify that this is for Admin
            if (cbCredentialType.SelectedIndex == 0)
            {
                try
                {
                    string query = "SELECT AdminID, AdminName FROM AdminLogin WHERE AdminID = :AdminID AND AdminPassword = :AdminPassword";

                    var parameters = new Dictionary<string, object>
                    {
                        { ":AdminID", userId },
                        { ":AdminPassword", userPassword }
                    };
                    DataTable result = dbFunctions.GetData(query, parameters);

                    if (result.Rows.Count > 0)
                    {
                        string userName = result.Rows[0]["AdminName"].ToString();
                        MessageBox.Show($"Welcome, {userName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SessionManager.IsLoggedIn = true;
                        SessionManager.userName = userName;
                        SessionManager.UserId = userId;

                        // Navigate to Dashboard
                        Home.stack.Push(this);
                        this.Hide();
                        Dashboard dashboard = new Dashboard(userName);
                        dashboard.ShowDialog();
                    }
                    else
                    {
                        // Invalid credentials
                        MessageBox.Show("Invalid login credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Verify this is for Student
            else if (cbCredentialType.SelectedIndex == 1)
            {
                try
                {
                    string query = "SELECT studentID, studentName FROM StudentLogin WHERE studentID = :studentID AND studentPassword = :studentPassword";

                    var parameters = new Dictionary<string, object>
                    {
                        { ":studentID", userId },
                        { ":studentPassword", userPassword }
                    };
                    DataTable result = dbFunctions.GetData(query, parameters);

                    if (result.Rows.Count > 0)
                    {
                        string userName = result.Rows[0]["studentName"].ToString();
                        MessageBox.Show($"Welcome, {userName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SessionManager.IsLoggedIn = true;
                        SessionManager.userName = userName;
                        SessionManager.UserId = userId;

                        // Navigate to Dashboard
                        Home.stack.Push(this);
                        this.Hide();
                        Dashboard dashboard = new Dashboard(userName);
                        dashboard.ShowDialog();
                    }
                    else
                    {
                        // Invalid credentials
                        MessageBox.Show("Invalid login credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
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

        private void CreateAccBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            Home.stack.Push(this);
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !showPassword.Checked;
        }

        private void studentLbl_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            Home.stack.Push(this);
            this.Hide();
            students.ShowDialog();
            this.Show();
        }

        private void DashboardLbl_Click(object sender, EventArgs e)
        {
            if (SessionManager.IsLoggedIn)
            {
                Dashboard dashboard = new Dashboard(SessionManager.userName);
                Home.stack.Push(this);
                this.Hide();
                dashboard.ShowDialog();
                this.Show();
            }
        }

        private void CoursesLbl_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            Home.stack.Push(this);
            this.Hide();
            courses.ShowDialog();
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

        private void AssignCourseLbl_Click(object sender, EventArgs e)
        {
            AssignCourse assignCourse = new AssignCourse();
            Home.stack.Push(this);
            this.Hide();
            assignCourse.ShowDialog();
            this.Show();
        }
    }
}
