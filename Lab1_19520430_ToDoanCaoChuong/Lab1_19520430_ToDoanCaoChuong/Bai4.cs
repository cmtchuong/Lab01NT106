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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            int fromBase = Int32.Parse(comboBox1.Text.Trim());   //đổi từ hệ...
            int toBase = Int32.Parse(comboBox3.Text.Trim());     //sang hệ

          
           
            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);


            textBox2.Text = result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
