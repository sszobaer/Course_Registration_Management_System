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
    public partial class OfferedCourse : Form
    {
        private Functions dbFunctions = new Functions();
        public OfferedCourse()
        {
            InitializeComponent();
            getOfferedCourses();
            ConfigureDataGridView();
        }
        //Fetch Offered Courses
        private void getOfferedCourses()
        {
            string query = "SELECT * FROM COURSE";
            ShowData.DataSource = dbFunctions.GetData(query);
        }

        //Configure DataGridView
        private void ConfigureDataGridView()
        {
            // Grid View for Select Courses
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

            ShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Fit columns to grid
            ShowData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ShowData.RowHeadersVisible = false;
            ShowData.ColumnHeadersVisible = true;
            ShowData.ScrollBars = ScrollBars.Both;

            // Set the row height to a max value if necessary (optional)
            ShowData.RowTemplate.Height = 30;
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
    }
}
