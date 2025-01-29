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
    public partial class Departments : Form
    {
        private Functions dbFunctions = new Functions();
        public Departments()
        {
            InitializeComponent();
            GetDeptHead();
            showDepartment();
            ConfigureDataGridView();
            ShowData.CellClick += ShowData_CellClick;
        }
        /*-------------------------------------Helper Methods Start-----------------------------------------*/
        //UI Configuration for DataGridView
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

        // Show all departments in the DataGridView
        private void showDepartment()
        {
            string Query = "SELECT * FROM Department";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }

        // Get all faculty members to populate the ComboBox
        private void GetDeptHead()
        {
            string query = "SELECT facultyName, facultyID FROM FacultyMember";
            DataTable dt = dbFunctions.GetData(query);

            if (dt.Rows.Count > 0)
            {
                cbDeptHead.DataSource = null;
                cbDeptHead.Items.Clear();
                cbDeptHead.DisplayMember = "facultyName";
                cbDeptHead.ValueMember = "facultyID";
                cbDeptHead.DataSource = dt;
            }
        }

        // Clear all input fields
        private void ClearFields()
        {
            txtDeptid.Text = "";
            txtDeptLocation.Text = "";
            txtDeptname.Text = "";
            txtDeptPhone1.Text = "";
            txtDeptPhone2.Text = "";
            cbDeptHead.SelectedIndex = -1;
        }

        /*-------------------------------------Helper Methods End-----------------------------------------*/

        /*-------------------------------------CRUD Operations Start-----------------------------------------*/
        //Insert new department
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate fields
                if (string.IsNullOrWhiteSpace(txtDeptid.Text) ||
                    string.IsNullOrWhiteSpace(txtDeptLocation.Text) ||
                    cbDeptHead.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtDeptname.Text) ||
                    string.IsNullOrWhiteSpace(txtDeptPhone1.Text) ||
                    string.IsNullOrWhiteSpace(txtDeptPhone2.Text))
                {
                    MessageBox.Show("Please fill out all the fields before proceeding.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                int deptId = Convert.ToInt32(txtDeptid.Text);
                string deptHead = cbDeptHead.Text;
                string location = txtDeptLocation.Text;
                string deptName = txtDeptname.Text;
                string deptPhone1 = txtDeptPhone1.Text;
                string deptPhone2 = txtDeptPhone2.Text;

                string Query = "INSERT INTO Department (deptId, deptName, deptHead, officeLocation, c, deptPhone2) VALUES (:deptId, :deptName, :deptHead, :officeLocation, :deptPhone1, :deptPhone2)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":deptId", deptId },
                    { ":deptName", deptName },
                    { ":deptHead", deptHead },
                    { ":officeLocation", location },
                    { ":deptPhone1", deptPhone1 },
                    { ":deptPhone2", deptPhone2 }
                };

                // Execute query
                dbFunctions.setData(Query, parameters);

                // Success message
                MessageBox.Show("New department added successfully! \n\n Great work! Your entry has been saved into the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showDepartment();
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
        //Update department
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int deptId = Convert.ToInt32(txtDeptid.Text);
                string deptHead = cbDeptHead.Text;
                string location = txtDeptLocation.Text;
                string deptName = txtDeptname.Text;
                string deptPhone1 = txtDeptPhone1.Text;
                string deptPhone2 = txtDeptPhone2.Text;
                // Validate fields
                if (string.IsNullOrWhiteSpace(txtDeptid.Text) ||
                    string.IsNullOrWhiteSpace(txtDeptLocation.Text) ||
                    cbDeptHead.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtDeptname.Text) ||
                    string.IsNullOrWhiteSpace(txtDeptPhone1.Text) ||
                    string.IsNullOrWhiteSpace(txtDeptPhone2.Text))
                {
                    MessageBox.Show("Please fill out all the fields before proceeding.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this department?",
                                                            "Confirm Update",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    string Query = "UPDATE Department SET deptId=:deptId, deptName = :deptName, deptHead = :deptHead, officeLocation = :officeLocation, deptPhone1 = :deptPhone1, deptPhone2 = :deptPhone2 WHERE deptId = :deptId";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { ":deptId", deptId },
                        { ":deptName", deptName },
                        { ":deptHead", deptHead },
                        { ":officeLocation", location },
                        { ":deptPhone1", deptPhone1 },
                        { ":deptPhone2", deptPhone2 }
                    };

                    dbFunctions.setData(Query, parameters);


                    MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showDepartment();
                    ClearFields();
                }
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
        //Search department
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string deptId = txtSDDeptID.Text.Trim(); // Assume you have a TextBox named txtSearchDeptId for searching the department ID
            try
            {
                if (string.IsNullOrWhiteSpace(deptId))
                {
                    MessageBox.Show("Please provide a valid Department ID to search.",
                                    "Data Missing",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string query = "SELECT * FROM Department WHERE deptId = :deptId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":deptId", deptId }
                };

                DataTable result = dbFunctions.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    txtDeptid.Text = result.Rows[0]["deptId"].ToString();
                    txtDeptname.Text = result.Rows[0]["deptName"].ToString();
                    cbDeptHead.Text = result.Rows[0]["deptHead"].ToString();
                    txtDeptLocation.Text = result.Rows[0]["officeLocation"].ToString();
                    txtDeptPhone1.Text = result.Rows[0]["deptPhone1"].ToString();
                    txtDeptPhone2.Text = result.Rows[0]["deptPhone2"].ToString();
                }
                else
                {
                    MessageBox.Show("No department found with the provided Department ID.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Ensure the clicked row is valid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ShowData.Rows[e.RowIndex];

                // Populate textboxes with the selected row's data
                txtDeptid.Text = selectedRow.Cells["deptId"].Value?.ToString();
                txtDeptname.Text = selectedRow.Cells["deptName"].Value?.ToString();
                txtDeptLocation.Text = selectedRow.Cells["officeLocation"].Value?.ToString();
                txtDeptPhone1.Text = selectedRow.Cells["deptPhone1"].Value?.ToString();
                txtDeptPhone2.Text = selectedRow.Cells["deptPhone2"].Value?.ToString();

                // Set the selected department in the ComboBox
                if (selectedRow.Cells["deptId"].Value != null)
                {
                    cbDeptHead.SelectedValue = Convert.ToInt32(selectedRow.Cells["deptId"].Value);
                }

            }
        }

        //Back button click event
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
