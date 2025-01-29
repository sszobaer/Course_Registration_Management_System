using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.IO;

namespace CRMS
{
    public partial class ViewProfile : Form
    {
        private Functions dbFunctions = new Functions();
        private int adminId;

        public ViewProfile(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            LoadUserData();
        }

        //Showing user data
        private void LoadUserData()
        {
            try
            {
                // Update the query to fetch data from the Admin table
                string query = @"SELECT * FROM Admin WHERE adminId = :adminId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "adminId", adminId }
                };

                DataTable result = dbFunctions.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    // Set the TextBox values with fetched data
                    txtID.Text = row["AdminId"].ToString();
                    txtName.Text = row["AdminName"].ToString();
                    txtPhoneNo.Text = row["Admin_Phone1"].ToString();
                    txtEmail.Text = row["Admin_Email1"].ToString();
                    txtRole.Text = row["Role"].ToString();
                    txtDept.Text = row["DeptId"].ToString();
                    lblName.Text = row["AdminName"].ToString();
                    lblPhoneNo.Text = row["Admin_Phone1"].ToString();
                    lblEmail.Text = row["Admin_Email1"].ToString();
                }
                else
                {
                    MessageBox.Show("No data found for the current admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BackBtn_Click(object sender, EventArgs e)
        {
            if(Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int adminId = Convert.ToInt32(txtID.Text);
            string adminName = txtName.Text;
            string adminPhone = txtPhoneNo.Text;
            string adminEmail = txtEmail.Text;
            string role = txtRole.Text;
            int deptId = Convert.ToInt32(txtDept.Text);

            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update?",
                                                           "Confirm Update",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = @"UPDATE Admin SET AdminName = :adminName, Admin_Phone1 = :adminPhone, Admin_Email1 = :adminEmail, Role = :role, DeptId = :deptId WHERE AdminId = :adminId";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "adminName", adminName },
                        { "adminPhone", adminPhone },
                        { "adminEmail", adminEmail },
                        { "role", role },
                        { "deptId", deptId },
                        { "adminId", adminId }
                    };

                    int rowsAffected = dbFunctions.setData(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUserData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            Home.stack.Push(this);
            this.Hide();
            changePassword.ShowDialog();
            this.Show();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            // Set the file filter to allow only images (optional)
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file path of the selected image
                string filePath = openFileDialog.FileName;

                // Load the image into the PictureBox
                profilePic.Image = System.Drawing.Image.FromFile(filePath);

                // Define the folder to save the image (change the path as needed)
                string folderPath = @"C:\Users\ZA SEYAM\OneDrive - American International University-Bangladesh\ADBMS\Iplementation\CRMS\ProfilePictures";

                // Check if the folder exists, if not, create it
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Save the image as 'profile.jpg' (the same name for all users)
                string savePath = Path.Combine(folderPath, "profile.jpg");

                // Save the image to the folder
                profilePic.Image.Save(savePath);

                // Optionally, save the file path to a local variable or settings
                string imagePath = savePath;
            }
        }
    }
}
