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
    public partial class AssignCourse : Form
    {
        private Functions dbFunctions = new Functions();
        public AssignCourse()
        {
            InitializeComponent();
            FetchFacultyID();
            FetchCourseID1();
            FetchCourseID2();
            FetchStudentID();
            ShowAssignedCourseForFaculty();
            ShowAssignedCourseForStudent();
            ConfigureDataGridView();   
        }
        /*----------------------------Helper Methods Start-------------------------------*/
        //UI Configuration for DataGridView
        private void ConfigureDataGridView()
        {

            facultyCourseAssnData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            facultyCourseAssnData.EnableHeadersVisualStyles = false;
            facultyCourseAssnData.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            facultyCourseAssnData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            facultyCourseAssnData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            facultyCourseAssnData.GridColor = Color.Black;
            facultyCourseAssnData.DefaultCellStyle.BackColor = Color.White;
            facultyCourseAssnData.DefaultCellStyle.ForeColor = Color.Black;
            facultyCourseAssnData.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            facultyCourseAssnData.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            facultyCourseAssnData.DefaultCellStyle.SelectionForeColor = Color.White;

            facultyCourseAssnData.AllowUserToResizeColumns = false;

            facultyCourseAssnData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            facultyCourseAssnData.ScrollBars = ScrollBars.Both;

            foreach (DataGridViewColumn column in facultyCourseAssnData.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Adjust width to fit content
            }


            facultyCourseAssnData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            facultyCourseAssnData.RowHeadersVisible = false;
            facultyCourseAssnData.ColumnHeadersVisible = true;

            studentCourseAssnData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            studentCourseAssnData.EnableHeadersVisualStyles = false;
            studentCourseAssnData.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            studentCourseAssnData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            studentCourseAssnData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            studentCourseAssnData.GridColor = Color.Black;
            studentCourseAssnData.DefaultCellStyle.BackColor = Color.White;
            studentCourseAssnData.DefaultCellStyle.ForeColor = Color.Black;
            studentCourseAssnData.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            studentCourseAssnData.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            studentCourseAssnData.DefaultCellStyle.SelectionForeColor = Color.White;

            studentCourseAssnData.AllowUserToResizeColumns = false;

            studentCourseAssnData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            studentCourseAssnData.ScrollBars = ScrollBars.Both;

            foreach (DataGridViewColumn column in studentCourseAssnData.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Adjust width to fit content
            }


            studentCourseAssnData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            studentCourseAssnData.RowHeadersVisible = false;
            studentCourseAssnData.ColumnHeadersVisible = true;

            studentCourseAssnData.RowTemplate.Height = 30;
        }
        //Fetch facultyID
        private void FetchFacultyID()
        {
            string query = "SELECT FacultyName, FacultyID FROM FacultyMember";
            DataTable dt = dbFunctions.GetData(query);

            if (dt.Rows.Count > 0)
            {
                cbFacultyID.DataSource = null;
                cbFacultyID.Items.Clear();
                cbFacultyID.DisplayMember = "facultyName";
                cbFacultyID.ValueMember = "facultyID";
                cbFacultyID.DataSource = dt;
            }

        }
        //Fetch CourseID
        private void FetchCourseID1()
        {
            string query = "SELECT CourseID, courseName FROM Course";
            DataTable dt = dbFunctions.GetData(query);
            if (dt.Rows.Count > 0)
            {
                cbCourseID1.DataSource = null;
                cbCourseID1.Items.Clear();
                cbCourseID1.DisplayMember = "courseName";
                cbCourseID1.ValueMember = "courseID";
                cbCourseID1.DataSource = dt;
            }
        }
        //Fetch StudentID
        private void FetchStudentID()
        {
            string query = "SELECT StudentID, StudentName FROM Student";
            DataTable dt = dbFunctions.GetData(query);
            if (dt.Rows.Count > 0)
            {
                cbStudentId.DataSource = null;
                cbStudentId.Items.Clear();
                cbStudentId.DisplayMember = "studentName";
                cbStudentId.ValueMember = "studentID";
                cbStudentId.DataSource = dt;
            }
        }
        //Fetch CourseID
        private void FetchCourseID2()
        {
            string query = "SELECT CourseID, courseName FROM Course";
            DataTable dt = dbFunctions.GetData(query);
            if (dt.Rows.Count > 0)
            {
                cbCourseID2.DataSource = null;
                cbCourseID2.Items.Clear();
                cbCourseID2.DisplayMember = "courseName";
                cbCourseID2.ValueMember = "courseID";
                cbCourseID2.DataSource = dt;
            }
        }
        //Show Assigned Course
        private void ShowAssignedCourseForFaculty()
        {
            string Query = "SELECT * FROM facultyCourseAssignment";
            facultyCourseAssnData.DataSource = dbFunctions.GetData(Query);
        }
        //Show Assigned Course
        private void ShowAssignedCourseForStudent()
        {
            string Query = "SELECT * FROM studentCourseRegistration";
            studentCourseAssnData.DataSource = dbFunctions.GetData(Query);
        }
        /*----------------------------Helper Methods End-------------------------------*/

        /*----------------------------Event Listeners Start-------------------------------*/
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }
        /*----------------------------Event Listeners End-------------------------------*/

        /*----------------------------CRUD Operations Start-------------------------------*/
        private void confirmscBtn_Click(object sender, EventArgs e)
        {
            string studentID = cbStudentId.SelectedValue.ToString();
            string courseID = cbCourseID2.SelectedValue.ToString();
            try
            {
                // Validate fields
                if (cbStudentId.SelectedIndex == -1 || cbCourseID2.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out all the fields before proceeding.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string Query = "INSERT INTO studentCourseRegistration (studentId, courseID) VALUES(:studentId, :courseID)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":studentId", studentID },
                    { ":courseID", courseID }
                };

                // Execute query
                dbFunctions.setData(Query, parameters);

                // Success message
                MessageBox.Show("Course is assigned for the Student", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAssignedCourseForStudent();
                studentID = "";
                courseID = "";
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

        private void confirmfcBtn_Click(object sender, EventArgs e)
        {
            string facultyID = cbFacultyID.SelectedValue.ToString();
            string courseID = cbCourseID1.SelectedValue.ToString();
            try
            {
                // Validate fields
                if (cbFacultyID.SelectedIndex == -1 || cbCourseID1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out all the fields before proceeding.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string Query = "INSERT INTO facultyCourseAssignment (facultyId, courseID) VALUES(:facultyId, :courseID)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":facultyId", facultyID },
                    { ":courseID", courseID }
                };

                // Execute query
                dbFunctions.setData(Query, parameters);

                // Success message
                MessageBox.Show("Course is assigned for the faculty", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAssignedCourseForFaculty();
                facultyID = "";
                courseID = "";
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
        /*----------------------------CRUD Operations End-------------------------------*/

        /*----------------------------Navigation Start-------------------------------*/
        private void AssignCourseLbl_Click(object sender, EventArgs e)
        {
            AssignCourse assignCourse = new AssignCourse();
            Home.stack.Push(this);
            this.Hide();
            assignCourse.ShowDialog();
            this.Show();
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
                Dashboard dashboard = new Dashboard(SessionManager.userName);
                Home.stack.Push(this);
                this.Hide();
                dashboard.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please log in to access the Dashboard.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /*----------------------------Navigation End-------------------------------*/


    }
}
