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
    public partial class ClassSchedule : Form
    {
        private Functions dbFunctions = new Functions();
        public ClassSchedule()
        {
            InitializeComponent();
            ConfigureDataGridView();
            GetClassSchedule();
            GetCourses();
            ShowData.CellClick += ShowData_CellClick;
        }
        /*-------------------------------------Helper Methods Start-----------------------------------------*/
        //UI Configuration for DataGridView
        private void ConfigureDataGridView()
        {

            ShowData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            ShowData.EnableHeadersVisualStyles = false;
            ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            ShowData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            ShowData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            ShowData.GridColor = Color.Black;
            ShowData.DefaultCellStyle.BackColor = Color.White;
            ShowData.DefaultCellStyle.ForeColor = Color.Black;
            ShowData.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            ShowData.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            ShowData.DefaultCellStyle.SelectionForeColor = Color.White;

            ShowData.AllowUserToResizeColumns = false;

            ShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            ShowData.ScrollBars = ScrollBars.Both;

            foreach (DataGridViewColumn column in ShowData.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Adjust width to fit content
            }


            ShowData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ShowData.RowHeadersVisible = false;
            ShowData.ColumnHeadersVisible = true;
        }
        //Fetch ClassSchedule info
        private void GetClassSchedule()
        {
            string Query = "select * from ClassSchedule";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }
        //Fetch Courses info
        private void GetCourses()
        {
            string query = "SELECT courseName,courseID FROM  Course";
            DataTable dt = dbFunctions.GetData(query);

            if (dt.Rows.Count > 0)
            {
                cbCourseName.DataSource = null;
                cbCourseName.Items.Clear();
                cbCourseName.DisplayMember = "courseName";
                cbCourseName.ValueMember = "courseID";
                cbCourseName.DataSource = dt;
            }
        }
        //Clear Fields
        private void ClearFields()
        {
            txtCLid.Text = "";
            txtCLDay.Text = "";
            txtCLTime.Text = "";
            txtCLRoomNo.Text = "";
            txtCLSemster.Text = "";
            cbCourseName.SelectedIndex = -1;
        }
        /*-------------------------------------Helper Methods End-----------------------------------------*/

        /*-------------------------------------CRUD Operations Start-----------------------------------------*/
        //Insert logic for insert classSchedule
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string classId = txtCLid.Text;
            string classDay = txtCLDay.Text;
            string classTime = txtCLTime.Text;
            string classRoom = txtCLRoomNo.Text;
            string semester = txtCLSemster.Text;
            string courseId = cbCourseName.SelectedValue.ToString();
            try
            {
                if (String.IsNullOrEmpty(classId) || String.IsNullOrEmpty(classDay)||
                    String.IsNullOrEmpty(classTime)|| String.IsNullOrEmpty(classRoom) ||
                    String.IsNullOrEmpty(semester) )
                {
                    MessageBox.Show("Please fill out all fields before inserting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                


                string query = @"INSERT INTO classSchedule (classId, classDay, classTime, roomNo, semester, courseId) 
                                VALUES (:classId, :classDay, :classTime, :roomNo, :semester, :courseId)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "classId", classId },
                    { "classDay", classDay },
                    { "classTime", classTime },
                    { "roomNo", classRoom },
                    { "semester", semester },
                    { "courseId", courseId }
                };

                dbFunctions.setData(query, parameters);
                MessageBox.Show("New schedule added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetClassSchedule();
                ClearFields();
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
        //Update logic for update classSchedule
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string classId = txtCLid.Text;
            string classDay = txtCLDay.Text;
            string classTime = txtCLTime.Text;
            string classRoom = txtCLRoomNo.Text;
            string semester = txtCLSemster.Text;
            string courseId = cbCourseName.SelectedValue.ToString();
            try
            {
                if (String.IsNullOrEmpty(classId) || String.IsNullOrEmpty(classDay) ||
                    String.IsNullOrEmpty(classTime) || String.IsNullOrEmpty(classRoom) ||
                    String.IsNullOrEmpty(semester) || cbCourseName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out all fields before inserting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                string query = @"UPDATE classSchedule 
                                SET classId = :classId, classDay = :classDay, classTime = :classTime, roomNo = :roomNo, semester = :semester, courseId = :courseId 
                                WHERE classId = :classId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "classId", classId },
                    { "classDay", classDay },
                    { "classTime", classTime },
                    { "roomNo", classRoom },
                    { "semester", semester },
                    { "courseId", courseId }
                };

                dbFunctions.setData(query, parameters);
                MessageBox.Show("New schedule Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetClassSchedule();
                ClearFields();
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
        //Search logic for search classSchedule
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string classId = txtSDCLId.Text.Trim(); 
            try
            {
                if (string.IsNullOrWhiteSpace(classId))
                {
                    MessageBox.Show("Please provide a valid Class ID to search.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string query = "SELECT * FROM classSchedule WHERE classId = :classId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":classId", classId }
                };

                DataTable result = dbFunctions.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    txtCLid.Text = result.Rows[0]["classId"].ToString();
                    txtCLDay.Text = result.Rows[0]["classDay"].ToString();
                    txtCLTime.Text = result.Rows[0]["classTime"].ToString();
                    txtCLRoomNo.Text = result.Rows[0]["roomNo"].ToString();
                    txtCLSemster.Text = result.Rows[0]["semester"].ToString();
                    cbCourseName.Text = result.Rows[0]["courseId"].ToString();  
                }
                else
                {
                    MessageBox.Show("No class schedule found with the provided Class ID.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Delete logic for delete classSchedule
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string classId = txtSDCLId.Text.Trim(); 
            try
            {
                if (string.IsNullOrWhiteSpace(classId))
                {
                    MessageBox.Show("Please provide a valid Class ID to delete.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this class schedule?",
                                                            "Confirm Deletion",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM classSchedule WHERE classId = :classId";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { ":classId", classId }
                    };

                    dbFunctions.setData(query, parameters);
                    MessageBox.Show("Class schedule deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetClassSchedule();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*-------------------------------------CRUD Operations End-----------------------------------------*/

        /*-------------------------------------Event Handlers Start-----------------------------------------*/
        //Handle cell click event
        private void ShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ShowData.Rows[e.RowIndex];
                txtCLid.Text = row.Cells[0].Value.ToString();
                txtCLDay.Text = row.Cells[1].Value.ToString();
                txtCLTime.Text = row.Cells[2].Value.ToString();
                txtCLRoomNo.Text = row.Cells[3].Value.ToString();
                txtCLSemster.Text = row.Cells[4].Value.ToString();
                cbCourseName.Text = row.Cells[5].Value.ToString();
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
