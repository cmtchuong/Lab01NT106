using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2_19520430_ToDoanCaoChuong
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

            
        }
    

        private void ReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();
                richTextBox1.Text = content;

                fs.Close();

            }

            catch (Exception) {}

        }

        private void StreamFile_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                string path = ofd.FileName;

                string data = richTextBox1.Text;

                File.Create(path).Close();

                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine(data.ToUpper());
                    sw.Close();
                }
            }

            catch(Exception) {}

        }
    }
}
