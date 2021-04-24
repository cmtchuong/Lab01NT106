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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void CountChar_Click(object sender, EventArgs e)
        {

        }

        private void CountWord_Click(object sender, EventArgs e)
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

                int charCount = content.Length;
                textBoxChar.Text = charCount.ToString();

                content = content.Replace("\r\n", "\r");

                int lineCount = richTextBox1.Lines.Count();
                textBoxLine.Text = lineCount.ToString();

                content = content.Replace('\r', ' ');

                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                int wordCount = source.Count();
                textBoxWord.Text = wordCount.ToString();


                string name = ofd.SafeFileName.ToString();
                textBoxFileName.Text = name;

                string URL = fs.Name.ToString();
                textBoxURL.Text = URL;

                fs.Close();

            }

            catch(Exception) { }

        }
    }
}
