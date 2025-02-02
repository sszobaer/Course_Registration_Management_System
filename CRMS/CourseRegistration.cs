using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMS
{
    public partial class CourseRegistration : Form
    {
        private Functions dbFunctions = new Functions();
        private int studentID;

        public CourseRegistration(int studentId)
        {
            InitializeComponent();
            this.studentID = studentId;
            ConfigureselectCoursesDataGridView();
            ConfigureRegisteredCoursesDataGridView();
            LoadClassSchedule();
            getRegisteredCourses();
        }

        /*-----------------------------Helper Method Start------------------------------------*/
        // Fetch ClassSchedule based on whether the student is a fresher or not
        private void LoadClassSchedule()
        {
            // Query to check if the student is a fresher or has already registered for courses
            string checkFresherQuery = "SELECT COUNT(*) FROM REGISTEREDCOURSE WHERE STUDENTID = " + studentID;
            int count = Convert.ToInt32(dbFunctions.GetScalarData(checkFresherQuery));

            string query = string.Empty;

            if (count == 0)
            {
                // Fresher: No previous courses registered
                query = "SELECT CS.CLASSID, CS.CLASSDAY, CS.CLASSTIME, CS.ROOMNO, CS.SEMESTER, CS.COURSEID, CS.CAPACITY " +
                        "FROM CLASSSCHEDULE CS " +
                        "LEFT JOIN PREREQUISITECOURSE PC ON CS.COURSEID = PC.COURSEID " +
                        "WHERE (PC.PREREQUISITECOURSEID = 'NILL') " +
                        "AND CS.COURSEID NOT IN (SELECT COURSEID FROM REGISTEREDCOURSE WHERE STUDENTID = " + studentID + ")";
            }
            else
            {
                // Non-Fresher: Check for prerequisite courses
                query = "SELECT CS.CLASSID, CS.CLASSDAY, CS.CLASSTIME, CS.ROOMNO, CS.SEMESTER, CS.COURSEID, CS.CAPACITY " +
                        "FROM CLASSSCHEDULE CS " +
                        "JOIN PREREQUISITECOURSE PC ON CS.COURSEID = PC.COURSEID " +
                        "WHERE (PC.PREREQUISITECOURSEID IN ( " +
                            "SELECT COURSEID FROM REGISTEREDCOURSE WHERE STUDENTID = " + studentID + ") " +
                        "OR PC.PREREQUISITECOURSEID = 'NILL') " +
                        "AND CS.COURSEID NOT IN (SELECT COURSEID FROM REGISTEREDCOURSE WHERE STUDENTID = " + studentID + ")";
            }

            DataTable dt = dbFunctions.GetData(query);

            // Preserve checkbox column after reloading data
            if (selectCoursesData.Columns.Contains("Select"))
            {
                selectCoursesData.DataSource = dt;
            }
            else
            {
                selectCoursesData.DataSource = dt;
                ConfigureselectCoursesDataGridView();
            }
        }


        // Fetch Registered Courses
        private void getRegisteredCourses()
        {
            string query = "SELECT * FROM REGISTEREDCOURSE WHERE STUDENTID = " + studentID;
            registeredCoursesData.DataSource = dbFunctions.GetData(query);
        }

        private void ConfigureselectCoursesDataGridView()
        {
            // Add Checkbox Column (if not already added)
            if (!selectCoursesData.Columns.Contains("Select"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "Select";
                chk.Name = "Select";
                chk.Width = 50;
                selectCoursesData.Columns.Insert(0, chk);
            }

            // Existing Formatting for selectCoursesData
            selectCoursesData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            selectCoursesData.EnableHeadersVisualStyles = false;
            selectCoursesData.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            selectCoursesData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            selectCoursesData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            selectCoursesData.GridColor = Color.Black;
            selectCoursesData.DefaultCellStyle.BackColor = Color.White;
            selectCoursesData.DefaultCellStyle.ForeColor = Color.Black;
            selectCoursesData.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            selectCoursesData.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            selectCoursesData.DefaultCellStyle.SelectionForeColor = Color.White;
            selectCoursesData.AllowUserToResizeColumns = false;
            selectCoursesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            selectCoursesData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            selectCoursesData.RowHeadersVisible = false;
            selectCoursesData.ColumnHeadersVisible = true;
            selectCoursesData.ScrollBars = ScrollBars.Both;
            selectCoursesData.RowTemplate.Height = 30;

            // Set the row height to a max value if necessary (optional)
            selectCoursesData.RowTemplate.Height = 30;
        }
        private void ConfigureRegisteredCoursesDataGridView()
        {
            // Add Checkbox Column (if not already added)
            if (!registeredCoursesData.Columns.Contains("Select"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "Select";
                chk.Name = "Select";
                chk.Width = 50;
                registeredCoursesData.Columns.Insert(0, chk);
            }

            // Existing Formatting for registeredCoursesData
            registeredCoursesData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            registeredCoursesData.EnableHeadersVisualStyles = false;
            registeredCoursesData.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            registeredCoursesData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            registeredCoursesData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            registeredCoursesData.GridColor = Color.Black;
            registeredCoursesData.DefaultCellStyle.BackColor = Color.White;
            registeredCoursesData.DefaultCellStyle.ForeColor = Color.Black;
            registeredCoursesData.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            registeredCoursesData.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            registeredCoursesData.DefaultCellStyle.SelectionForeColor = Color.White;
            registeredCoursesData.AllowUserToResizeColumns = false;
            registeredCoursesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            registeredCoursesData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            registeredCoursesData.RowHeadersVisible = false;
            registeredCoursesData.ColumnHeadersVisible = true;
            registeredCoursesData.ScrollBars = ScrollBars.Both;
            registeredCoursesData.RowTemplate.Height = 30;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            List<string> selectedCourses = new List<string>();

            foreach (DataGridViewRow row in selectCoursesData.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["Select"] as DataGridViewCheckBoxCell;

                if (chk != null && chk.Value != null && (bool)chk.Value == true)
                {
                    string courseId = row.Cells["COURSEID"].Value.ToString();
                    string semester = row.Cells["SEMESTER"].Value.ToString();
                    string classDay = row.Cells["CLASSDAY"].Value.ToString();
                    string classTime = row.Cells["CLASSTIME"].Value.ToString();
                    int classId = Convert.ToInt32(row.Cells["CLASSID"].Value);  // Getting CLASSID from the DataGridView

                    // Check if the student is already registered for this course
                    string checkCourseQuery = $"SELECT COUNT(*) FROM REGISTEREDCOURSE WHERE STUDENTID = {studentID} AND COURSEID = '{courseId}'";
                    int alreadyRegistered = Convert.ToInt32(dbFunctions.GetScalarData(checkCourseQuery));

                    if (alreadyRegistered > 0)
                    {
                        MessageBox.Show($"You are already registered for the course {courseId}. You cannot register for it again.");
                        return;
                    }

                    // Check if there is a time clash with already registered courses
                    string checkTimeClashQuery = $@"
                    SELECT COUNT(*) 
                    FROM CLASSSCHEDULE CS
                    JOIN REGISTEREDCOURSE RC ON RC.COURSEID = CS.COURSEID
                    WHERE RC.STUDENTID = {studentID}
                    AND CS.CLASSDAY = '{classDay}' 
                    AND CS.CLASSTIME = '{classTime}'";
                        int timeClashCount = Convert.ToInt32(dbFunctions.GetScalarData(checkTimeClashQuery));

                    if (timeClashCount > 0)
                    {
                        MessageBox.Show("There is a time clash with your already registered courses. Please choose a different time.");
                        return;
                    }

                    string enrollmentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    selectedCourses.Add($"({studentID}, '{courseId}', '{semester}', {DateTime.Now.Year}, TO_DATE('{enrollmentDate}', 'YYYY-MM-DD'), {classId})");

                    // Decrease the capacity of the course by 1
                    string updateCapacityQuery = $"UPDATE CLASSSCHEDULE SET CAPACITY = CAPACITY - 1 WHERE CLASSID = {classId}";
                    dbFunctions.ExecuteQuery(updateCapacityQuery);
                }
            }

            if (selectedCourses.Count == 0)
            {
                MessageBox.Show("Please select at least one course.");
                return;
            }

            // Properly format the query string for multiple courses
            string insertQuery = "INSERT INTO REGISTEREDCOURSE (STUDENTID, COURSEID, SEMESTER, YEAR, ENROLLMENTDATE, CLASSID) VALUES "
                                 + string.Join(", ", selectedCourses);

            // Ensure the final query is correctly formatted and output for debugging
            Console.WriteLine(insertQuery);

            int rowsAffected = dbFunctions.ExecuteQuery(insertQuery);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Courses successfully registered!");
                LoadClassSchedule();  // Refresh available courses
                getRegisteredCourses();  // Refresh registered courses
            }
            else
            {
                MessageBox.Show("Error while registering courses.");
            }
        }





        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            List<string> coursesToRemove = new List<string>();

            foreach (DataGridViewRow row in registeredCoursesData.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["Select"] as DataGridViewCheckBoxCell;

                if (chk != null && chk.Value != null && (bool)chk.Value == true)
                {
                    string courseId = row.Cells["COURSEID"].Value.ToString();
                    int classId = Convert.ToInt32(row.Cells["CLASSID"].Value);  // Get the CLASSID for capacity restoration
                    coursesToRemove.Add($"({studentID}, '{courseId}')");

                    // Restore capacity for the course when it's removed
                    string updateCapacityQuery = $"UPDATE CLASSSCHEDULE SET CAPACITY = CAPACITY + 1 WHERE CLASSID = {classId}";
                    dbFunctions.ExecuteQuery(updateCapacityQuery);
                }
            }

            if (coursesToRemove.Count == 0)
            {
                MessageBox.Show("Please select at least one course to remove.");
                return;
            }

            string deleteQuery = "DELETE FROM REGISTEREDCOURSE WHERE (STUDENTID, COURSEID) IN (" + string.Join(", ", coursesToRemove) + ")";
            int rowsAffected = dbFunctions.ExecuteQuery(deleteQuery);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Courses successfully removed!");
                LoadClassSchedule();  // Refresh available courses
                getRegisteredCourses();  // Refresh registered courses
            }
            else
            {
                MessageBox.Show("Error while removing courses.");
            }
        }


        /*-----------------------------Helper Method END------------------------------------*/
        /*----------------------------Event Handeler Start---------------------------------------*/
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }
        /*----------------------------Event Handeler End---------------------------------------*/
    }
}
//Finallyy