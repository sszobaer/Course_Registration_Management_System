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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            // Add students
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
            cbDept.Text = "Department";
            cbDept.ForeColor = Color.Teal;

            //Delete Students
            txtDeleteID.Text = "ID";
            txtDeleteID.ForeColor = Color.Teal;

            //Search Students
            txtSearchID.Text = "ID";
            txtSearchID.ForeColor = Color.Teal;
        }
        private void ConfigureDataGridView()
        {
            // Set alternating row colors for readability
            StudentsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set header styles
            StudentsGridView.EnableHeadersVisualStyles = false;
            StudentsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
;
            StudentsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            StudentsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Set grid line color
            StudentsGridView.GridColor = Color.Black;

            // Set default row styles
            StudentsGridView.DefaultCellStyle.BackColor = Color.White;
            StudentsGridView.DefaultCellStyle.ForeColor = Color.Black;
            StudentsGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Set selection styles
            StudentsGridView.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            StudentsGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fit columns to the DataGridView
            StudentsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust row height to fit content
            StudentsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable column resize by the user for a consistent layout
            StudentsGridView.AllowUserToResizeColumns = false;

            // Set row and column headers visibility if needed
            StudentsGridView.RowHeadersVisible = false;
            StudentsGridView.ColumnHeadersVisible = true;
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
            if(txtSname.Text == string.Empty)
            {
                txtSname.Text = "Name";
                txtSname.ForeColor= Color.Teal;
            }
        }

        private void txtProgram_Enter(object sender, EventArgs e)
        {
            txtProgram.Text = string.Empty;
            txtProgram.ForeColor = Color.Black;
        }

        private void txtProgram_Leave(object sender, EventArgs e)
        {
            if(txtProgram.Text == string.Empty)
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
                txtStatus.Text= "Status";
                txtStatus.ForeColor= Color.Teal;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.Text = string.Empty;
            txtAddress.ForeColor = Color.Black;
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if(txtAddress.Text == string.Empty)
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
            if( txtPhoneNo.Text == string.Empty)
            {
                txtPhoneNo.Text = "Phone Number";
                txtPhoneNo.ForeColor= Color.Teal;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtEmail.ForeColor = Color.Black;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text == string.Empty)
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Teal;
            }
        }

        private void cbDept_Enter(object sender, EventArgs e)
        {
            cbDept.Text = string.Empty;
            cbDept.ForeColor = Color.Black;
        }

        private void cbDept_Leave(object sender, EventArgs e)
        {
            if( cbDept.Text == string.Empty)
            {
                cbDept.Text = "Department";
                cbDept.ForeColor = Color.Teal;
            }
        }

        private void txtDeleteID_Enter(object sender, EventArgs e)
        {
            txtDeleteID.Text = string.Empty;
            txtDeleteID.ForeColor = Color.Black;
        }

        private void txtDeleteID_Leave(object sender, EventArgs e)
        {
            if( txtDeleteID.Text == string.Empty)
            {
                txtDeleteID.Text = "ID";
                txtDeleteID.ForeColor = Color.Teal;
            }
        }

        private void txtSearchID_Enter(object sender, EventArgs e)
        {
            txtSearchID.Text = string.Empty;
            txtSearchID.ForeColor = Color.Black;
        }

        private void txtSearchID_Leave(object sender, EventArgs e)
        {
            if(txtSearchID.Text == string.Empty)
            {
                txtSearchID.Text = "ID";
                txtSearchID.ForeColor = Color.Teal;
            }
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
            Dashboard dashboard = new Dashboard();
            Home.stack.Push(this);
            this.Hide();
            dashboard.ShowDialog();
            this.Show();
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

        private void AdministratorLbl_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            Home.stack.Push(this);
            this.Hide();
            administrator.ShowDialog();
            this.Show();
        }
    }
}
