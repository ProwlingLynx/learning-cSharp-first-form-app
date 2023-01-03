using System;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Welcome to my program!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
