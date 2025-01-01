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
    public partial class Home : Form
    {
        public static Stack<Form> stack = new Stack<Form>();
        public Home()
        {
            InitializeComponent();
        }

        private void registerNowBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            Home.stack.Push(this);
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Home.stack.Push(this);
            this.Hide();
            login.ShowDialog();
            this.Show();
        }
    }
}
