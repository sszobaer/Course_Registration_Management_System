using System;
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
    public partial class studentDashboard : Form
    {
        private Functions dbFunctions = new Functions();
        private int studentId;
        public studentDashboard(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }
        /*----------------------------------------------Helper Method Start-----------------------------------*/
        //Load User Data
        private void LoadUserData()
        {
            try
            {
                // Update the query to fetch data from the Admin table
                string query = @"SELECT * FROM Student WHERE studentId = :studentId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "studentId", studentId }
                };

                DataTable result = dbFunctions.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    // Set the TextBox values with fetched data
                    txtID.Text = row["StudentId"].ToString();
                    txtName.Text = row["studentName"].ToString();
                    txtPhoneNo.Text = row["Student_Phone1"].ToString();
                    txtEmail.Text = row["Student_Email1"].ToString();
                    txtProgram.Text = row["Program"].ToString();
                    txtStatus.Text = row["status"].ToString();
                    lblName.Text = row["studentName"].ToString();
                    lblPhoneNo.Text = row["student_Phone1"].ToString();
                    lblEmail.Text = row["student_Email1"].ToString();
                }
                else
                {
                    MessageBox.Show("No data found for the current admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentDashboard_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        /*----------------------------------------------Helper Method END-----------------------------------*/
        /*----------------------------------------------CRUD Method Start-----------------------------------*/
        //Update Students Information
        private void updateBtn_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(txtID.Text);
            string studentName = txtName.Text;
            string studentPhone = txtPhoneNo.Text;
            string studentEmail = txtEmail.Text;
            string program = txtProgram.Text;
            string status = txtStatus.Text;

            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update?",
                                                            "Confirm Update",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = @"UPDATE Student 
                             SET studentName = :studentName, 
                                 program = :program, 
                                 status = :status, 
                                 student_phone1 = :studentPhone, 
                                 student_Email1 = :studentEmail
                             WHERE studentId = :studentId";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "studentName", studentName },
                        { "program", program },
                        { "status", status },
                        { "studentPhone", studentPhone },
                        { "studentEmail", studentEmail },
                        { "studentId", studentId }
                    };

                    int rowsAffected = dbFunctions.setData(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully.", "✅ Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUserData();
                    }
                    else
                    {
                        MessageBox.Show("❌ Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*----------------------------------------------CRUD Method Start-----------------------------------*/
        /*-----------------------------Event handle start----------------------------------*/
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }
        /*-----------------------------Event handle end----------------------------------*/

        /*-----------------------------Navigation Start-----------------------------------*/
        private void registrationBtn_Click(object sender, EventArgs e)
        {
            CourseRegistration courseRegistration = new CourseRegistration(SessionManager.UserId);
            Home.stack.Push(this);
            this.Hide();
            courseRegistration.ShowDialog();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            Home.stack.Push(this);
            this.Hide();
            changePassword.ShowDialog();
        }

        private void offeredCoursesBtn_Click(object sender, EventArgs e)
        {
            OfferedCourse offeredCourse = new OfferedCourse();
            Home.stack.Push(this);
            this.Hide();
            offeredCourse.ShowDialog();
        }

        private void AiAdvisorBtn_Click(object sender, EventArgs e)
        {
            AIAdvisor aiAdvisor = new AIAdvisor(SessionManager.UserId);
            Home.stack.Push(this);
            this.Hide();
            aiAdvisor.ShowDialog();
        }
        /*-----------------------------Navigation End-----------------------------------*/
    }
}
