using System;
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
        //Fetch department names from database
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
        //Fetch faculty members from database
        private void GetFacultyMembers()
        {
            string Query = "SELECT * FROM Facultymember";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }
        //Reset fields after insert
        private void ResetFields()
        {
            txtFid.Text = "";
            txtFname.Text = "";
            txtemail.Text = "";
            txtPhone.Text = "";
            cbDeptName.SelectedIndex = -1;
            cbPosition.SelectedIndex = -1;
        }
        /*-------------------------------------Helper Methods End-----------------------------------------*/

        /*-------------------------------------CRUD Operations Start-----------------------------------------*/
        //Insert logic for faculty members
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string facultyId = txtFid.Text;
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
                ResetFields();

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

        //Update logic for faculty members
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string facultyId = txtFid.Text;
            string facultyName = txtFname.Text;
            string facultyEmail = txtemail.Text;
            string facultyPhone = txtPhone.Text;
            int facultyDept = Convert.ToInt32(cbDeptName.SelectedValue.ToString());
            string facultyPosition = cbPosition.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(facultyId) || string.IsNullOrWhiteSpace(facultyName) || cbDeptName.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(facultyEmail) || string.IsNullOrWhiteSpace(facultyPhone) || cbPosition.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out all the fields before proceeding.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string query = @"UPDATE Facultymember 
                                SET facultyId = :facultyId, facultyName = :facultyName, position = :position, deptId = :deptId, faculty_phone1 = :faculty_phone1, faculty_phone2 = :faculty_phone2, faculty_email1 = :faculty_email1, faculty_email2 = :faculty_email2 WHERE facultyId = :facultyId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":facultyId", facultyId },
                    { ":facultyName", facultyName },
                    { ":position", facultyPosition },
                    { ":deptId", facultyDept },
                    { ":faculty_phone1", facultyPhone },
                    { ":faculty_phone2", DBNull.Value },
                    { ":faculty_email1", facultyEmail },
                    { ":faculty_email2", DBNull.Value }
                };

                dbFunctions.setData(query, parameters);

                MessageBox.Show("Faculty member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetFacultyMembers(); 
                ResetFields();  
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

        //Delete logic for faculty members
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string facultyId = txtDeleteFID.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(facultyId))
                {
                    MessageBox.Show("Please provide a valid Faculty ID to delete.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this faculty member?",
                                                            "Confirm Deletion",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM Facultymember WHERE facultyId = :facultyId";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { ":facultyId", facultyId }
                    };

                    dbFunctions.setData(query, parameters);

                    MessageBox.Show("Faculty member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetFacultyMembers();  
                    ResetFields();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the faculty member: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Search logic for faculty members

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string facultyId = txtDeleteFID.Text;

            try
            {
                // Validate that the faculty ID is provided
                if (string.IsNullOrWhiteSpace(facultyId))
                {
                    MessageBox.Show("Please provide a Faculty ID to search.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string query = "SELECT * FROM Facultymember WHERE facultyId = :facultyId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":facultyId", facultyId }
                };

                DataTable result = dbFunctions.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    txtFid.Text = result.Rows[0]["facultyId"].ToString();
                    txtFname.Text = result.Rows[0]["facultyName"].ToString();
                    txtemail.Text = result.Rows[0]["faculty_email1"].ToString();
                    txtPhone.Text = result.Rows[0]["faculty_phone1"].ToString();
                    cbDeptName.SelectedValue = result.Rows[0]["deptId"];
                    cbPosition.SelectedItem = result.Rows[0]["position"].ToString();
                }
                else
                {
                    MessageBox.Show("No faculty member found with the provided Faculty ID.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*-------------------------------------CRUD Operations End-----------------------------------------*/

        /*-------------------------------------Event Handlers Start-----------------------------------------*/
        //Handle cell click event
        private void ShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ShowData.Rows[e.RowIndex];

                txtFid.Text = selectedRow.Cells["facultyId"].Value?.ToString();
                txtFname.Text = selectedRow.Cells["facultyName"].Value?.ToString();
                txtemail.Text = selectedRow.Cells["faculty_email1"].Value?.ToString();
                txtPhone.Text = selectedRow.Cells["faculty_phone1"].Value?.ToString();

                if (selectedRow.Cells["deptId"].Value != null)
                {
                    cbDeptName.SelectedValue = Convert.ToInt32(selectedRow.Cells["deptId"].Value);
                }

                if (selectedRow.Cells["position"].Value != null)
                {
                    cbPosition.Text = selectedRow.Cells["position"].Value.ToString();
                }
            }
        }

        //Handle back button click
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
