using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_19520430_ToDoanCaoChuong
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;

            try
            {
                num1 = double.Parse(textBox1.Text.Trim());
                num2 = double.Parse(textBox2.Text.Trim());
                num3 = double.Parse(textBox3.Text.Trim());
            }

            catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double max = num1;
            double min = num1;

            if (num2 > max) max = num2;
            if (num3 > max) max = num3;

            textBox4.Text = max.ToString();

            if (num2 < min) min = num2;
            if (num3 < min) min = num3;

            textBox5.Text = min.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
