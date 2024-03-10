using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int x;
            myclass obj = new myclass(1);
            obj.info();
        }
    }
    class myclass {
        int x;
        public myclass() { }   
        public myclass(int x) { this.x = x; }

        public void info() {
            MessageBox.Show("value x is " + x);
        }

        ~myclass()
        {
            MessageBox.Show("bye bye myclass");
        }
    }
}
