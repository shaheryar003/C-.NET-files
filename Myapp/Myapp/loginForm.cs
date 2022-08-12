using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myapp
{
    public partial class LoginForm : Form
    {
       

        public LoginForm()
        {
            InitializeComponent();
        }

        string UserName = "fast";
        string Password = "admin";
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == UserName && textBoxPassword.Text == Password)

            {
                MessageBox.Show("LOGIN SUCCESSFULL");
                HomePage homepage = new HomePage();
                this.Hide();
                homepage.ShowDialog();

            }
            else
                MessageBox.Show("Please enter correct UserName or Password", "Invalid Credentials", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
