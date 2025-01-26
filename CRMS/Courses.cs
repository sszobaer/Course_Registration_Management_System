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
    public partial class Courses : Form
    {
        private Functions dbFunctions = new Functions();
        public Courses()
        {
            InitializeComponent();
            ConfigureDataGridView();
            GetDept();
            showCourse();
            ShowData.CellClick += ShowData_CellClick;
        }
        /*-------------------------------------Helper Methods Start-----------------------------------------*/
        // UI configuration for the DataGridView
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

        // Get department names from the database into the comboBox
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

        // Show all courses in the DataGridView
        private void showCourse()
        {
            string Query = "SELECT * FROM Course";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }
        /*-------------------------------------Helper Methods End-----------------------------------------*/

        /*-------------------------------------CRUD Operations Start-----------------------------------------*/

        //Insert logic for adding a new course
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string courseID = txtCid.Text;
            string courseName = txtCname.Text;
            string courseDept = cbDeptName.Text;
            string courseCredit = cbCredits.Text;
            string courseSemester = txtSemester.Text;

            try
            {
                // Validate fields
                if (string.IsNullOrWhiteSpace(courseID) || string.IsNullOrWhiteSpace(courseName) || cbDeptName.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(courseSemester) || cbCredits.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out all the fields before proceeding.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string Query = "INSERT INTO Course (courseId, courseName, semesterOffered, credits, deptName) VALUES (:courseId, :courseName, :semesterOffered, :credits, :deptName)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":courseId", courseID },
                    { ":courseName", courseName },
                    { ":semesterOffered", courseSemester },
                    { ":credits", courseCredit },
                    { ":deptName", courseDept }

                };

                // Execute query
                dbFunctions.setData(Query, parameters);

                // Success message
                MessageBox.Show("New Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showCourse();
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

        //Update logic for updating an existing course
        private void updateBtn_Click(object sender, EventArgs e)
        {
            //pass
        }

        //Delete logic for deleting a course
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //pass
        }

        //Search logic for searching a course
        private void searchBtn_Click(object sender, EventArgs e)
        {
            //pass
        }
        /*-------------------------------------CRUD Operations End-----------------------------------------*/

        /*-------------------------------------Event Handlers Start-----------------------------------------*/
        //Handle cell click event
        private void ShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked row is valid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ShowData.Rows[e.RowIndex];

                // Populate textboxes with the selected row's data
                txtCid.Text = selectedRow.Cells["courseId"].Value?.ToString();
                txtCname.Text = selectedRow.Cells["courseName"].Value?.ToString();
                txtSemester.Text = selectedRow.Cells["semesterOffered"].Value?.ToString();


                // Set the selected department in the ComboBox

                if (selectedRow.Cells["deptName"].Value != null)
                {
                    // Get the deptID corresponding to the deptName
                    var deptName = selectedRow.Cells["deptName"].Value.ToString();
                    var deptID = cbDeptName.Items.Cast<DataRowView>()
                                                .Where(item => item["deptName"].ToString() == deptName)
                                                .Select(item => item["deptID"])
                                                .FirstOrDefault();

                    cbDeptName.SelectedValue = deptID;
                }

                if (selectedRow.Cells["credits"].Value != null)
                {
                    cbCredits.SelectedValue = Convert.ToInt32(selectedRow.Cells["credits"].Value);
                }

            }
        }
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

        private void AssignCourseLbl_Click(object sender, EventArgs e)
        {
            AssignCourse assignCourse = new AssignCourse();
            Home.stack.Push(this);
            this.Hide();
            assignCourse.ShowDialog();
            this.Show();
        }
        /*-------------------------------------Navigation End-----------------------------------------*/
    }
}
