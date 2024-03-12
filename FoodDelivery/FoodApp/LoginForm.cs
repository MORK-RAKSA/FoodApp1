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
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
            MessageBox.Show("Hello World Mork Raksa");
            MessageBox.Show("Hello World Phorn Phanny");
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
