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
    public partial class Payments : Form
    {
        private Functions dbFunctions = new Functions();
        public Payments()
        {
            InitializeComponent();
            ConfigureDataGridView();
            GetStudent();
            GetPayments();
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

        //Fetch Students info
        private void GetStudent()
        {
            string Query = "SELECT studentId FROM Student";
            DataTable dt = dbFunctions.GetData(Query);
            if (dt.Rows.Count > 0)
            {
                cbStudentId.DataSource = null;
                cbStudentId.Items.Clear();
                cbStudentId.DisplayMember = "studentId";
                cbStudentId.ValueMember = "studentId";
                cbStudentId.DataSource = dt;
            }
        }
        //Fetch Payments info
        private void GetPayments()
        {
            string Query = "SELECT * FROM Payment";
            ShowData.DataSource = dbFunctions.GetData(Query);
        }
        //Clear Fields
        private void ClearFields()
        {
            txtPid.Text = "";
            txtPMethod.Text = "";
            txtAmount.Text = "";
            txtStatus.Text = "";
            cbStudentId.SelectedIndex = -1;
            dtPDate.Value = DateTime.Now;
        }
        /*-------------------------------------Helper Methods End-----------------------------------------*/

        /*-------------------------------------CRUD Operations Start-----------------------------------------*/
        //Insert logic for Payments
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string paymentId = txtPid.Text;
            string paymentMethod = txtPMethod.Text;
            string paymentAmount = txtAmount.Text;
            string status = txtStatus.Text;
            int studentId = Convert.ToInt32(cbStudentId.SelectedValue);
            DateTime paymentDate = dtPDate.Value;
            try
            {
                if(string.IsNullOrEmpty(paymentId) || string.IsNullOrEmpty(paymentMethod) || string.IsNullOrEmpty(paymentAmount) || string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Please fill all the fields", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string Query = @"INSERT INTO Payment (paymentId, paymentDate, paymentMethod, status, amount, studentId) 
                                VALUES (:paymentId, TO_DATE(:paymentDate, 'YYYY-MM-DD'), :paymentMethod, :status, :paymentAmount, :studentId)";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "paymentId", paymentId },
                    { "paymentDate", paymentDate.ToString("yyyy-MM-dd")},
                    { "paymentMethod", paymentMethod },
                    { "status", status },
                    { "paymentAmount", paymentAmount },
                    { "studentId", studentId }
                };
                dbFunctions.setData(Query, parameters);
                MessageBox.Show("You Payment is done successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetPayments();
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
        //Search logic for Payments
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string paymentId = txtSearchPId.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(paymentId))
                {
                    MessageBox.Show("Please provide a valid Payment ID to search.", "🔍 Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "SELECT * FROM Payment WHERE paymentId = :paymentId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { ":paymentId", paymentId }
                };

                DataTable result = dbFunctions.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    txtPid.Text = result.Rows[0]["paymentId"].ToString();
                    dtPDate.Value = Convert.ToDateTime(result.Rows[0]["paymentDate"]);
                    txtPMethod.Text = result.Rows[0]["paymentMethod"].ToString();
                    txtStatus.Text = result.Rows[0]["status"].ToString();
                    txtAmount.Text = result.Rows[0]["amount"].ToString();
                    cbStudentId.SelectedValue = result.Rows[0]["studentId"];
                }
                else
                {
                    MessageBox.Show("No payment found with the provided ID.", "❌ No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for the payment: {ex.Message}", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*-------------------------------------CRUD Operations End-----------------------------------------*/

        /*-------------------------------------Event Handlers Start-----------------------------------------*/
        //Show Data Click event
        private void ShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ShowData.Rows[e.RowIndex];

                txtPid.Text = selectedRow.Cells["paymentId"].Value?.ToString();
                txtPMethod.Text = selectedRow.Cells["paymentMethod"].Value?.ToString();
                txtAmount.Text = selectedRow.Cells["amount"].Value?.ToString();
                txtStatus.Text = selectedRow.Cells["status"].Value?.ToString();

                if (selectedRow.Cells["studentId"].Value != null)
                {
                    cbStudentId.SelectedValue = Convert.ToInt32(selectedRow.Cells["studentId"].Value);
                }

                dtPDate.Value = Convert.ToDateTime(selectedRow.Cells["paymentDate"].Value);
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
