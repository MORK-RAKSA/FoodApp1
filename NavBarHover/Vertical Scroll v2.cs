using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vertical_Scoll
{

    public partial class Form1 : Form
    {
        CB_color obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //listBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            obj.RED = vScrollBar1.Value;
            obj.setcolor();
            
            labelRed.Text = vScrollBar1.Value.ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            //listBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            obj.GREEN = vScrollBar2.Value;
            obj.setcolor();
            labelBlue.Text = vScrollBar2.Value.ToString();
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            //listBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            obj.BLUE = vScrollBar3.Value;
            obj.setcolor();
            labelBlue.Text = vScrollBar3.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new CB_color(255,1,1, listBox1);
            obj.setcolor();
        }
    }
    class CB_color {
        public int RED, GREEN, BLUE;
        ListBox L;

        public CB_color(ListBox L1) { L = L1;
            RED = 1; GREEN = 1; BLUE = 1;
        }
        public CB_color(int rED, int gREEN, int bLUE, ListBox l)
        {
            RED = rED;
            GREEN = gREEN;
            BLUE = bLUE;
            L = l;
        }
        public void setcolor() {
            L.BackColor = Color.FromArgb(RED, GREEN,BLUE);
        }
        public void setcolor(int r, int g, int b)
        {
            L.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
