using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CRMS
{
    public partial class ChangePassword : Form
    {
        private Functions dbFunctions = new Functions();

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !showPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !showPassword.Checked;
            txtNewPassword.UseSystemPasswordChar = !showPassword.Checked;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string currentPassword = txtPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmPassword.Text;

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New Password and Confirm New Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assuming you have a method to get the current password of the logged-in user
            string query = "SELECT password FROM AdminLogin WHERE AdminName = :adminName";
            var parameters = new Dictionary<string, object>
            {
                { ":adminName", SessionManager.AdminName }
            };

            // Fetch the current password from the database
            DataTable result = dbFunctions.GetData(query, parameters);

            if (result.Rows.Count > 0)
            {
                string storedPassword = result.Rows[0]["password"].ToString();

                if (storedPassword == currentPassword)
                {
                    // Update the password
                    string updateQuery = "UPDATE AdminLogin SET password = :newPassword WHERE AdminName = :AdminName";
                    var updateParams = new Dictionary<string, object>
                    {
                        { ":newPassword", newPassword },
                        { ":AdminName", SessionManager.AdminName }
                    };

                    int updateSuccess = dbFunctions.setData(updateQuery, updateParams);
                    if (updateSuccess > 0) 
                    {
                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the password. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Admin not found. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
