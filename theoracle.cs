using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static Random g = new Random(27);    // negative seven
        private static string[] g1 = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001" };
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            label1.Text = Calk(g.Next(0, 10), g1);
            label2.Text = Calk(g.Next(0, 10), g1);
            label3.Text = Calk(g.Next(0, 10), g1);
            label4.Text = Calk(g.Next(0, 10), g1);
            label5.Text = Calk(g.Next(0, 10), g1);
            label6.Text = Calk(g.Next(0, 10), g1);
            label7.Text = Calk(g.Next(0, 10), g1);
            label8.Text = Calk(g.Next(0, 10), g1);
            label9.Text = Calk(g.Next(0, 10), g1);
            label10.Text = Calk(g.Next(0, 10), g1);
            /* theta */
        }

        public string Calk(int g, string[] g3)
        {
            return g3[g];
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = (999) * (7);   // seven
            timer.Enabled = true;
            timer.Start();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("May 02, 2016");
        }
    }
}
