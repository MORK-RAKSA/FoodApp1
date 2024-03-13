using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace FoodApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            closeEye.Click += closeEye_Click;
            openEye.Click += openEye_Click;
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void closeEye_Click(object sender, EventArgs e)
        {
            closeEye.Visible = false;
            openEye.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void openEye_Click(object sender, EventArgs e)
        {
            closeEye.Visible = true;
            openEye.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Visible = true;
        }

        /*       static void setDoubleBuffer(Control ctr, bool doublebuffered)
               {
                   try
                   {
                       typeof(Control).InvokeMember("doublebuffered",
                       BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, ctr, new object[] {doublebuffered});
                   }catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message);
                   }
               }
        */
    }
}
