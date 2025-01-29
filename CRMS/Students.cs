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
    public partial class Students : Form
    {
        private Functions dbFunctions = new Functions();
        public Students()
        {
            InitializeComponent();
            ConfigureTextBoxes();
            ConfigureDataGridView();
            GetDept();
            showStudents();
            ShowData.CellClick += ShowData_CellClick;
        }
        /*-------------------------------------Helper Methods Start-----------------------------------------*/
        //UI Configurartion for textBoxes
        private void ConfigureTextBoxes()
        {
            txtSid.Text = "ID";
            txtSid.ForeColor = Color.Teal;
            txtSname.Text = "Name";
            txtSname.ForeColor = Color.Teal;
            txtStatus.Text = "Status";
            txtStatus.ForeColor = Color.Teal;
            txtAddress.Text = "Address";
            txtAddress.ForeColor = Color.Teal;
            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Teal;
            txtPhoneNo.Text = "Phone Number";
            txtPhoneNo.ForeColor = Color.Teal;
            txtProgram.Text = "Program";
            txtProgram.ForeColor = Color.Teal;
            cbDeptName.Text = "Department";
            cbDeptName.ForeColor = Color.Teal;

            txtDeleteID.Text = "ID";
            txtDeleteID.ForeColor = Color.Teal;
        }

        //Fetch Department Names
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
        //Fetch Students
        private void showStudents()
        {
            string Query = "SELECT * FROM Student";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }

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
        private void txtSid_Enter(object sender, EventArgs e)
        {
            txtSid.Text = string.Empty;
            txtSid.ForeColor = Color.Black;
        }
        private void txtSid_Leave(object sender, EventArgs e)
        {
            if (txtSid.Text == string.Empty)
            {
                txtSid.Text = "ID";
                txtSid.ForeColor = Color.Teal;
            }
        }

        private void txtSname_Enter(object sender, EventArgs e)
        {
            txtSname.Text = string.Empty;
            txtSname.ForeColor = Color.Black;
        }

        private void txtSname_Leave(object sender, EventArgs e)
        {
            if (txtSname.Text == string.Empty)
            {
                txtSname.Text = "Name";
                txtSname.ForeColor = Color.Teal;
            }
        }

        private void txtProgram_Enter(object sender, EventArgs e)
        {
            txtProgram.Text = string.Empty;
            txtProgram.ForeColor = Color.Black;
        }

        private void txtProgram_Leave(object sender, EventArgs e)
        {
            if (txtProgram.Text == string.Empty)
            {
                txtProgram.Text = "Program";
                txtProgram.ForeColor = Color.Teal;
            }
        }

        private void txtStatus_Enter(object sender, EventArgs e)
        {
            txtStatus.Text = string.Empty;
            txtStatus.ForeColor = Color.Black;
        }

        private void txtStatus_Leave(object sender, EventArgs e)
        {
            if (txtStatus.Text == string.Empty)
            {
                txtStatus.Text = "Status";
                txtStatus.ForeColor = Color.Teal;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.Text = string.Empty;
            txtAddress.ForeColor = Color.Black;
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == string.Empty)
            {
                txtAddress.Text = "Address";
                txtAddress.ForeColor = Color.Teal;
            }
        }

        private void txtPhoneNo_Enter(object sender, EventArgs e)
        {
            txtPhoneNo.Text = string.Empty;
            txtPhoneNo.ForeColor = Color.Black;
        }

        private void txtPhoneNo_Leave(object sender, EventArgs e)
        {
            if (txtPhoneNo.Text == string.Empty)
            {
                txtPhoneNo.Text = "Phone Number";
                txtPhoneNo.ForeColor = Color.Teal;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtEmail.ForeColor = Color.Black;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Teal;
            }
        }

        private void cbDept_Enter(object sender, EventArgs e)
        {
            cbDeptName.Text = string.Empty;
            cbDeptName.ForeColor = Color.Black;
        }

        private void cbDept_Leave(object sender, EventArgs e)
        {
            if (cbDeptName.Text == string.Empty)
            {
                cbDeptName.Text = "Department";
                cbDeptName.ForeColor = Color.Teal;
            }
        }

        private void txtDeleteID_Enter(object sender, EventArgs e)
        {
            txtDeleteID.Text = string.Empty;
            txtDeleteID.ForeColor = Color.Black;
        }

        private void txtDeleteID_Leave(object sender, EventArgs e)
        {
            if (txtDeleteID.Text == string.Empty)
            {
                txtDeleteID.Text = "ID";
                txtDeleteID.ForeColor = Color.Teal;
            }
        }
        //Clear Fields
        private void ClearFields()
        {
            txtSid.Text = "ID";
            txtSid.ForeColor = Color.Teal;
            txtSname.Text = "Name";
            txtSname.ForeColor = Color.Teal;
            txtStatus.Text = "Status";
            txtStatus.ForeColor = Color.Teal;
            txtAddress.Text = "Address";
            txtAddress.ForeColor = Color.Teal;
            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Teal;
            txtPhoneNo.Text = "Phone Number";
            txtPhoneNo.ForeColor = Color.Teal;
            txtProgram.Text = "Program";
            txtProgram.ForeColor = Color.Teal;
            cbDeptName.Text = "Department";
            cbDeptName.ForeColor = Color.Teal;
        }
        /*-------------------------------------Helper Methods End-----------------------------------------*/

        /*-------------------------------------CRUD Operations Start-----------------------------------------*/

        //Insert Logic for Students
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSid.Text == "ID" || txtSname.Text == "Name" || txtStatus.Text == "Status" ||
                    txtAddress.Text == "Address" || txtEmail.Text == "Email" || txtPhoneNo.Text == "Phone Number" ||
                    txtProgram.Text == "Program" || cbDeptName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out all fields before inserting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string studentId = txtSid.Text;
                string studentName = txtSname.Text;
                string studentStatus = txtStatus.Text;
                string studentAddress = txtAddress.Text;
                string studentEmail = txtEmail.Text;
                string studentPhoneNo = txtPhoneNo.Text;
                string studentProgram = txtProgram.Text;
                int deptId = Convert.ToInt32(cbDeptName.SelectedValue);
                DateTime EnrollmentDate = enrollmentDate.Value;
                

                string query = @"INSERT INTO Student (studentId, studentName, program, enrollmentDate, status, address, deptId, student_phone1, student_phone2, student_email1, student_email2) 
                                VALUES (:studentId, :studentName, :studentProgram, TO_DATE(:enrollmentDate, 'YYYY-MM-DD'), :studentStatus, :studentAddress, :deptId, :student_phone1, :student_phone2, :student_email1, :student_email2)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "studentId", studentId },
                    { "studentName", studentName },
                    { "studentProgram", studentProgram },
                    { "enrollmentDate", EnrollmentDate.ToString("yyyy-MM-dd")},
                    { "studentStatus", studentStatus },
                    { "studentAddress", studentAddress },
                    { "deptId", deptId },
                    { "student_phone1", studentPhoneNo },
                    { "student_phone2", DBNull.Value },
                    { "student_email1", studentEmail },
                    { "student_email2", DBNull.Value }
                };

                dbFunctions.setData(query, parameters);
                MessageBox.Show("New student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showStudents();
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


        //Update Logic for Students
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string studentId = txtSid.Text;
            string studentName = txtSname.Text;
            string studentStatus = txtStatus.Text;
            string studentAddress = txtAddress.Text;
            string studentEmail = txtEmail.Text;
            string studentPhoneNo = txtPhoneNo.Text;
            string studentProgram = txtProgram.Text;
            int deptId = Convert.ToInt32(cbDeptName.SelectedValue);
            DateTime EnrollmentDate = enrollmentDate.Value;

            try
            {
                if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(studentName) ||
                    string.IsNullOrWhiteSpace(studentStatus) || string.IsNullOrWhiteSpace(studentAddress) ||
                    string.IsNullOrWhiteSpace(studentEmail) || string.IsNullOrWhiteSpace(studentPhoneNo) ||
                    string.IsNullOrWhiteSpace(studentProgram) || cbDeptName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out all fields before updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this Student's information?",
                                                            "Confirm Update",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) 
                { 
                    string query = @"UPDATE Student SET studentId = :studentId, studentName = :studentName, program = :studentProgram, enrollmentDate = TO_DATE(:enrollmentDate, 'YYYY-MM-DD'), 
                             status = :studentStatus, address = :studentAddress, deptId = :deptId, student_phone1 = :student_phone1, 
                             student_phone2 = :student_phone2, student_email1 = :student_email1, student_email2 = :student_email2 
                             WHERE studentId = :studentId";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { ":studentId", studentId },
                        { ":studentName", studentName },
                        { ":studentProgram", studentProgram },
                        { ":enrollmentDate", EnrollmentDate.ToString("yyyy-MM-dd") },
                        { ":studentStatus", studentStatus },
                        { ":studentAddress", studentAddress },
                        { ":deptId", deptId },
                        { ":student_phone1", studentPhoneNo },
                        { ":student_phone2", DBNull.Value },
                        { ":student_email1", studentEmail },
                        { ":student_email2", DBNull.Value }
                    };

                    dbFunctions.setData(query, parameters);
                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showStudents();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Delete Logic for Students

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string studentId = txtDeleteID.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(studentId))
                {
                    MessageBox.Show("Please provide a valid Student ID to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", 
                                                            "Confirm Deletion", 
                                                            MessageBoxButtons.YesNo, 
                                                            MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM Student WHERE studentId = :studentId";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { ":studentId", studentId }
                    };

                    dbFunctions.setData(query, parameters);
                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showStudents();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the student: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Search Logic for Students
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string studentId = txtDeleteID.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(studentId))
                {
                    MessageBox.Show("Please provide a Student ID to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "SELECT * FROM Student WHERE studentId = :studentId";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":studentId", studentId }
                };

                DataTable result = dbFunctions.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    txtSid.Text = result.Rows[0]["studentId"].ToString();
                    txtSname.Text = result.Rows[0]["studentName"].ToString();
                    txtStatus.Text = result.Rows[0]["status"].ToString();
                    txtAddress.Text = result.Rows[0]["address"].ToString();
                    txtEmail.Text = result.Rows[0]["student_email1"].ToString();
                    txtPhoneNo.Text = result.Rows[0]["student_phone1"].ToString();
                    txtProgram.Text = result.Rows[0]["program"].ToString();
                    cbDeptName.SelectedValue = result.Rows[0]["deptId"];
                }
                else
                {
                    MessageBox.Show("No student found with the provided ID.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for the student: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*-------------------------------------CRUD Operations End-----------------------------------------*/

        /*-------------------------------------Event Handlers Start-----------------------------------------*/
        //Cell Click Event
        //Cell Click Event
        private void ShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = ShowData.Rows[e.RowIndex];

                // Populate the textboxes with the selected row's data
                txtSid.Text = selectedRow.Cells["studentId"].Value.ToString();
                txtSname.Text = selectedRow.Cells["studentName"].Value.ToString();
                txtStatus.Text = selectedRow.Cells["status"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["address"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["student_email1"].Value.ToString();
                txtPhoneNo.Text = selectedRow.Cells["student_phone1"].Value.ToString();
                txtProgram.Text = selectedRow.Cells["program"].Value.ToString();

                // Set the department
                cbDeptName.SelectedValue = selectedRow.Cells["deptId"].Value;

                // Set the enrollment date
                DateTime EnrollmentDate = Convert.ToDateTime(selectedRow.Cells["enrollmentDate"].Value);
                enrollmentDate.Value = EnrollmentDate; 
            }
        }

        //BAck Button
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
