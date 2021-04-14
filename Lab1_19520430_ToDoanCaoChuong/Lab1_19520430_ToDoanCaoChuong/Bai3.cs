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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] DonVi = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] Chuc = { "Mười", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };

            int num = int.Parse(textBox1.Text);
            string strWords = "";


            if (num > 999 && num < 10000)
            {
                int i = num / 1000;
                strWords = strWords + DonVi[i - 1] + " Nghìn ";
                num = num % 1000;
            }


            if (num > 99 && num < 1000)
            {
                int i = num / 100;
                strWords = strWords + DonVi[i - 1] + " Trăm ";
                num = num % 100;
            }

            if (num > 19 && num < 100)
            {
                int i = num / 10;
                strWords = strWords + Chuc[i - 1] + " ";
                num = num % 10;
            }

            if (num > 0 && num < 20)
            {
                strWords = strWords + DonVi[num - 1];
            }

            textBox2.Text = strWords;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }
    }
}
