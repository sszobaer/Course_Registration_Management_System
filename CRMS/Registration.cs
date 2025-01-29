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
    public partial class Registration : Form
    {
        private Functions dbFunctions = new Functions();
        public Registration()
        {
            InitializeComponent();
            GetRegistration();
            ConfigureDataGridView();
            GetClassSchedule();
            GetStudentId();
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
        //Feetch Registration info
        private void GetRegistration()
        {
            string Query = "select * from Registration";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }
        //Fetch classId from ClassSchedule
        private void GetClassSchedule()
        {
            string query = "SELECT classId FROM  ClassSchedule";
            DataTable dt = dbFunctions.GetData(query);

            if (dt.Rows.Count > 0)
            {
                cbClassId.DataSource = null;
                cbClassId.Items.Clear();
                cbClassId.DisplayMember = "classID";
                cbClassId.ValueMember = "classID";
                cbClassId.DataSource = dt;
            }
        }
        //Fetch Studeents Id from Students
        private void GetStudentId()
        {
            string query = "SELECT studentId FROM  Student";
            DataTable dt = dbFunctions.GetData(query);

            if (dt.Rows.Count > 0)
            {
                cbStudentId.DataSource = null;
                cbStudentId.Items.Clear();
                cbStudentId.DisplayMember = "studentId";
                cbStudentId.ValueMember = "studentId";
                cbStudentId.DataSource = dt;
            }
        }
        //Clear Fields
        private void ClearFields()
        {
            txtRegId.Text = "";
            cbStudentId.SelectedIndex = -1;
            cbClassId.SelectedIndex = -1;
        }
        /*-------------------------------------Helper Methods End-----------------------------------------*/

        /*-------------------------------------CRUD Operations Start-----------------------------------------*/
        //Insert Logic for Registration
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string regId = txtRegId.Text;
            DateTime regDate = registrationDate.Value;
            int studentId = Convert.ToInt32(cbStudentId.SelectedValue.ToString());
            int classId = Convert.ToInt32(cbClassId.SelectedValue.ToString());
            try
            {
                // Validate fields
                if (string.IsNullOrWhiteSpace(regId) || cbClassId.SelectedIndex == -1 ||
                    cbClassId.SelectedIndex == -1 )

                {
                    MessageBox.Show("Please fill out all the fields before proceeding.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string Query = @"INSERT INTO Registration (regId, regDate, studentId, classId) 
                               VALUES (:regId, TO_DATE(:regDate, 'YYYY-MM-DD'), :studentId, :classId)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "regId", regId },
                    { "regDate", regDate.ToString("yyyy-MM-dd") },
                    { "studentId", studentId },
                    { "classId", classId }

                };

                // Execute query
                dbFunctions.setData(Query, parameters);

                // Success message
                MessageBox.Show("Registration record created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRegistration();
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

        //Update Logic for Registration
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string regId = txtRegId.Text;
            DateTime regDate = registrationDate.Value;
            int studentId = Convert.ToInt32(cbStudentId.SelectedValue.ToString());
            int classId = Convert.ToInt32(cbClassId.SelectedValue.ToString());

            try
            {
                if (string.IsNullOrWhiteSpace(regId) || cbClassId.SelectedIndex == -1 || cbStudentId.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out all the fields before updating.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this Registration record?",
                                            "Confirm Update",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    string query = @"UPDATE Registration SET regId = :regId, regDate = TO_DATE(:regDate, 'YYYY-MM-DD'), studentId = :studentId, classId = :classId 
                                    WHERE regId = :regId";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { ":regId", regId },
                        { ":regDate", regDate.ToString("yyyy-MM-dd") },
                        { ":studentId", studentId },
                        { ":classId", classId }
                    };

                    dbFunctions.setData(query, parameters);

                    MessageBox.Show("Registration record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetRegistration();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Delete Logic for Registration
        private void Delete_Click(object sender, EventArgs e)
        {
            string regId = txtDropRegistrationID.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(regId))
                {
                    MessageBox.Show("Please provide a valid Registration ID to delete.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this registration record?", 
                                                            "Confirm Deletion", 
                                                            MessageBoxButtons.YesNo, 
                                                            MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM Registration WHERE regId = :regId";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { ":regId", regId }
                    };

                    dbFunctions.setData(query, parameters);

                    MessageBox.Show("Registration record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetRegistration();  
                    ClearFields();      
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the registration: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Search Logic for Registration
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string regId = txtDropRegistrationID.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(regId))
                {
                    MessageBox.Show("Please provide a valid Registration ID to search.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "SELECT * FROM Registration WHERE regId = :regId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":regId", regId }
                };

                DataTable result = dbFunctions.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    txtRegId.Text = result.Rows[0]["regId"].ToString();
                    registrationDate.Value = Convert.ToDateTime(result.Rows[0]["regDate"]);
                    cbStudentId.SelectedValue = result.Rows[0]["studentId"];
                    cbClassId.SelectedValue = result.Rows[0]["classId"];
                }
                else
                {
                    MessageBox.Show("No registration found with the provided ID.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for the registration: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*-------------------------------------CRUD Operations End-----------------------------------------*/

        /*-------------------------------------Event Handlers Start-----------------------------------------*/
        //Data GrideView CLick Event
        private void ShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ShowData.Rows[e.RowIndex];

                txtRegId.Text = selectedRow.Cells["regId"].Value?.ToString();
                cbStudentId.SelectedValue = selectedRow.Cells["studentId"].Value != DBNull.Value ?
                                             Convert.ToInt32(selectedRow.Cells["studentId"].Value) : -1;
                cbClassId.SelectedValue = selectedRow.Cells["classId"].Value != DBNull.Value ?
                                          Convert.ToInt32(selectedRow.Cells["classId"].Value) : -1;

                if (selectedRow.Cells["regDate"].Value != DBNull.Value)
                {
                    registrationDate.Value = Convert.ToDateTime(selectedRow.Cells["regDate"].Value);
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

        /*-------------------------------------Navigation End-----------------------------------------*/
    }
}
