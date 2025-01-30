using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CRMS
{
    public partial class ChangePassword : Form
    {
        private Functions dbFunctions = new Functions();

        public ChangePassword()
        {
            InitializeComponent();
        }
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !showPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !showPassword.Checked;
            txtNewPassword.UseSystemPasswordChar = !showPassword.Checked;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string currentPassword = txtPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmNewPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(SessionManager.userName))
            {
                MessageBox.Show("User session expired. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "SELECT password FROM AdminLogin WHERE AdminName = :adminName";
                var parameters = new Dictionary<string, object> { { ":adminName", SessionManager.userName } };

                DataTable result = dbFunctions.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    string storedPassword = result.Rows[0]["password"].ToString();

                    if (HashPassword(currentPassword) == storedPassword)
                    {
                        string updateQuery = "UPDATE AdminLogin SET password = :newPassword WHERE AdminName = :AdminName";
                        var updateParams = new Dictionary<string, object>
                        {
                            { ":newPassword", HashPassword(newPassword) },
                            { ":AdminName", SessionManager. userName }
                        };

                        int rowsAffected = dbFunctions.setData(updateQuery, updateParams);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Admin not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hashing function for passwords
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
