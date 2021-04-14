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
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4 f4 = new Bai4();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 f1 = new Bai1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 f2 = new Bai2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 f3 = new Bai3();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5 f5 = new Bai5();
            f5.Show();
        }

        private void Lab1_Load(object sender, EventArgs e)
        {

        }
    }
}
