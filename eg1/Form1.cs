using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox3.Clear();
            btnAdd.Enabled = (textBox1.Text.Length > 0 && textBox2.Text.Length > 0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            btnAdd.Enabled = (textBox1.Text.Length > 0 && textBox2.Text.Length > 0);
        }

        float c;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            a = Convert.ToSingle(textBox1.Text);
            b = Convert.ToSingle(textBox2.Text);

            c = (a + b) * 1.2F;

            textBox3.Text = c.ToString("C");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.ToString());
        }
    }
}
