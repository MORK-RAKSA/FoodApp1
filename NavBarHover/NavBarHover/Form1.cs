using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavBarHover
{
    public partial class Form1 : Form
    {
        bool slideBarExpand;

        public Form1()
        {
            InitializeComponent();
        }

        private void slideBar_Tick(object sender, EventArgs e)
        {
            if(slideBarExpand)
            {
                bar.Height -= 10;
                if (bar.Height == bar.MinimumSize.Height)
                {
                    bar.BackColor = Color.White;
                    slideBarExpand = false;
                    slideBar.Stop();
                }
            }
            else
            {
                bar.Height += 10;
                if (bar.Height == bar.MaximumSize.Height)
                {
                    bar.BackColor = Color.DeepSkyBlue;
                    slideBarExpand = true;
                    slideBar.Stop();
                }
            }
        }

        private void bar_MouseHover(object sender, EventArgs e)
        {
            slideBar.Start();
        }

        private void bar_MouseLeave(object sender, EventArgs e)
        {
            slideBar.Start();
        }
    }
}
