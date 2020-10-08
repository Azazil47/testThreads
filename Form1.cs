using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ThreadTest2
{
    public partial class Form1 : Form
    {
        private Worker _worker;
        public void getText() {
            for (int i = 0; i < 10; i++)
            {
                textBox1.Text += "1 ";
                Thread.Sleep(2000);
            }
            
        }
        public Form1()
        {
            InitializeComponent();
            buttonProgressStart.Click += buttonProgressStart_Click;
            buttonProgresStop.Click += buttonProgresStop_Click;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(getText);
            
        }

        private void buttonProgressStart_Click(object sender, EventArgs e)
        {

        }

        private void buttonProgresStop_Click(object sender, EventArgs e)
        {

        }
    }
}
