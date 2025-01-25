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
        }
        private void showDepartment()
        {
            string Query = "SELECT * FROM Department";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }
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

        private void ClearFields()
        {
            txtDeptid.Text = "";
            txtDeptLocation.Text = "";
            txtDeptname.Text = "";
            txtDeptPhone1.Text = "";
            txtDeptPhone2.Text = "";
            cbDeptHead.SelectedIndex = -1;
        }
      
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

                // Collect input data
                int deptId = Convert.ToInt32(txtDeptid.Text);
                string deptHead = cbDeptHead.Text;
                string location = txtDeptLocation.Text;
                string deptName = txtDeptname.Text;
                string deptPhone1 = txtDeptPhone1.Text;
                string deptPhone2 = txtDeptPhone2.Text;

                string Query = "INSERT INTO Department (deptId, deptName, deptHead, officeLocation, deptPhone1, deptPhone2) VALUES (:deptId, :deptName, :deptHead, :officeLocation, :deptPhone1, :deptPhone2)";

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
                MessageBox.Show("New department added successfully! \n\n Great work! Your entry has been saved into the database.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showDepartment();
                ClearFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid data format. Please check your inputs and try again.","❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}","❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDeleteDeptID.Text == "")
                {
                    MessageBox.Show("No Department selected!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string deptId = txtDeleteDeptID.Text;
                string Query = "DELETE FROM Department WHERE deptId = :deptID";
                Dictionary<string, object> Params = new Dictionary<string, object>
                {
                    { ":deptID", deptId}
                };
                dbFunctions.setData(Query, Params);
                MessageBox.Show("Department deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showDepartment();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void AssignCourseLbl_Click(object sender, EventArgs e)
        {
            AssignCourse assignCourse = new AssignCourse();
            Home.stack.Push(this);
            this.Hide();
            assignCourse.ShowDialog();
            this.Show();
        }
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
    }
}
