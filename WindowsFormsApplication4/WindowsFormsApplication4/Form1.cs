using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int clickCount;
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text = clickCount++.ToString();
            if (clickCount % 2 == 0)
                BackColor = Color.Yellow;
            else
                BackColor = Color.Red;

        }
    }
}
