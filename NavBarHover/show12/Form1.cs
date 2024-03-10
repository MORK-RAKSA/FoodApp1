using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Iperson p = new person();
            p.show();
            ((IpersonA)p).show();
            ((IpersonB)p).show();
        }
    }

    interface Iperson:IpersonA,IpersonB {
        //int id;
         void show();
    }
    interface IpersonA {
        void show();
    }
    interface IpersonB {
        void show();
    }
    class person :Iperson  { 
        public void show()
        {
            MessageBox.Show("Welcome to interface person show");
        }
        void IpersonA.show() {
            MessageBox.Show("Welcome to interface personA show");
        }
        void IpersonB.show() {
            MessageBox.Show("Welcome to interface personB show");
        }
    }

}
