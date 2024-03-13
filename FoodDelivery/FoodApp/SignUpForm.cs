using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            closeEye.Click += closeEye_Click;
            openEye.Click += openEye_Click;
        }

        private void openEye_Click(object sender, EventArgs e)
        {
            closeEye.Visible = true;
            openEye.Visible = false;
            txtNewPassword.UseSystemPasswordChar = true;
        }
        private void closeEye_Click(object sender, EventArgs e)
        {
            closeEye.Visible = false;
            openEye.Visible = true;
            txtNewPassword.UseSystemPasswordChar = false;
        }

        private void lbSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(); 
            loginForm.Show();
        }
    }
}
