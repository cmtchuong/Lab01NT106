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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;

            try
            {
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
            }

            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }
    }
}
