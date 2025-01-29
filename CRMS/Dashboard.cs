using Oracle.ManagedDataAccess.Client;
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
    public partial class Dashboard : Form
    {
        private Functions dbFunctions = new Functions();
        public Dashboard(string AdminName)
        {
            InitializeComponent();
            ConfigureDataGridView();
            GetTotalDepartments();
            GetTotalFaculty();
            GetTotalStudents();
            this.Name = AdminName;
        }
        /*-------------------------------------Helper Methods Start-----------------------------------------*/

        // Configure the DataGridView
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
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblName.Text = Name;
        }
        //Fetch total number of departments
        public void GetTotalDepartments()
        {
            string query = "SELECT COUNT(*) AS TotalDepartmentNumber FROM Department";
            DataTable result = dbFunctions.GetData(query);

            if (result.Rows.Count > 0)
            {
                int totalDepartments = Convert.ToInt32(result.Rows[0]["TotalDepartmentNumber"]);
                lblDepartmentCount.Text = totalDepartments.ToString();
            }
            else
            {
                lblDepartmentCount.Text = "0";
            }
        }

        //Fetch total number of faculty members
        public void GetTotalFaculty()
        {
            string query = "SELECT COUNT(*) AS TotalFacultyNumber FROM Facultymember";
            DataTable result = dbFunctions.GetData(query);

            if (result.Rows.Count > 0)
            {
                int totalFacultyMember = Convert.ToInt32(result.Rows[0]["TotalFacultyNumber"]);
                lblFacultyCount.Text = totalFacultyMember.ToString();
            }
            else
            {
                lblFacultyCount.Text = "0";
            }
        }

        //Fetch total number of students
        public void GetTotalStudents()
        {
            string query = "SELECT COUNT(*) AS TotalStudents FROM Student";
            DataTable result = dbFunctions.GetData(query);

            if (result.Rows.Count > 0)
            {
                int totalStudent = Convert.ToInt32(result.Rows[0]["TotalStudents"]);
                lblStudentCount.Text = totalStudent.ToString();
            }
            else
            {
                lblFacultyCount.Text = "0";
            }
        }
        //Fetch all students
        private void showStudents()
        {
            string Query = "SELECT * FROM Student";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }

        //Fetch all departments
        private void showDepartments()
        {
            string Query = "SELECT * FROM Department";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }

        //Fetch all courses
        private void showCourses()
        {
            string Query = "SELECT * FROM Course";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }

        //Fetch all faculty members
        private void showFaculty()
        {
            string Query = "SELECT * FROM Facultymember";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }
        /*-------------------------------------Helper Methods End-----------------------------------------*/

        /*-------------------------------------Event Handlers Start-----------------------------------------*/
        //Back Button
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }
        private void BtnshowStudents_Click(object sender, EventArgs e)
        {
            showStudents();
        }

        private void btnShowDept_Click(object sender, EventArgs e)
        {
            showDepartments();
        }

        private void btnShowCourses_Click(object sender, EventArgs e)
        {
            showCourses();
        }

        private void btnShowFaculty_Click(object sender, EventArgs e)
        {
            showFaculty();
        }
        /*-------------------------------------Event Handlers End-----------------------------------------*/

        /*-------------------------------------Navigation Start-----------------------------------------*/
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

        private void AssignCourseLbl_Click(object sender, EventArgs e)
        {
            AssignCourse assignCourse = new AssignCourse();
            Home.stack.Push(this);
            this.Hide();
            assignCourse.ShowDialog();
            this.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile(SessionManager.UserId);
            Home.stack.Push(this);
            this.Hide();
            viewProfile.ShowDialog();
            this.Show();
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            GetTotalDepartments();
            GetTotalFaculty();
            GetTotalStudents();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SessionManager.IsLoggedIn = false;
            Home.stack.Push(this);
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
        /*-------------------------------------Navigation End-----------------------------------------*/

    }
}
