using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CRMS
{
    public partial class Register : Form
    {
        private Functions dbFunctions = new Functions();
        public Register()
        {
            InitializeComponent();
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

        private void loginBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            Home.stack.Push(this);
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !showPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !showPassword.Checked;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(txtID.Text);
            string userName = txtName.Text;
            string userPassword = txtPassword.Text;
            //Verify that this is for Admin
            if (cbCredentialType.SelectedIndex == 0)
            {
                try
                {
                    string query = @"INSERT INTO AdminLogin (AdminID, AdminName, AdminPassword) 
                                    VALUES (:AdminID, :AdminName, :AdminPassword)";

                    var parameters = new Dictionary<string, object>
                    {
                        { ":AdminID", userId },
                        { ":AdminName", userName },
                        { ":AdminPassword", userPassword }
                    };
                    DataTable result = dbFunctions.GetData(query, parameters);
                    MessageBox.Show("Sign Up Successful!" , 
                                    "Success", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                    Home home = new Home();
                    Home.stack.Push(this);
                    this.Hide();
                    home.ShowDialog();
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Verify this is for Student
            else if (cbCredentialType.SelectedIndex == 1)
            {
                try
                {
                    string query = @"INSERT INTO studentLogin (studentID, studentName, studentPassword)
                                     VALUES (:studentID, :studentName, :studentPassword)";

                    var parameters = new Dictionary<string, object>
                    {
                        { ":studentID", userId },
                        { ":studentName", userName },
                        { ":studentPassword", userPassword }
                    };
                    DataTable result = dbFunctions.GetData(query, parameters);
                    MessageBox.Show("Sign Up Successful!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Home home = new Home();
                    Home.stack.Push(this);
                    this.Hide();
                    home.ShowDialog();

                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
