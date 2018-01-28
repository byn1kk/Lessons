using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        static int _clickCount;
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            // Обработчик события кнопки
            _clickCount++;
            label1.Text = _clickCount.ToString();
            if (_clickCount % 2 == 0)
                BackColor = Color.Yellow;
            else
                BackColor = Color.HotPink;

        }
    }
}
