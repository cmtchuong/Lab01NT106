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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void StreamReader_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();
                richTextBoxInput.Text = content;

                fs.Close();

            }

            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;

            string output = "";
            string[] subs;

            char[] operators = { '+', '-', '*', '/' };

            if (richTextBoxInput.Text != "")
            {
                string content = richTextBoxInput.Text;
                subs = content.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);


                for (int i = 0; i < subs.Length; i++)
                {
                    subs[i] = subs[i].Replace("\n", "");
                    int pos = subs[i].IndexOfAny(operators);


                    if (pos != -1)
                    {
                        double num1 = 0;
                        double num2 = 0;

                        string[] operands = subs[i].Split(new char[] { subs[i][pos] }, 2, StringSplitOptions.RemoveEmptyEntries);
                        bool is_IntNum1 = double.TryParse(operands[0], out num1);
                        bool is_IntNum2 = double.TryParse(operands[1], out num2);

                        if (is_IntNum1 && is_IntNum2)
                        {
                            switch (subs[i][pos])
                            {
                                case '+':
                                    result = num1 + num2;
                                    break;
                                case '-':
                                    result = num1 - num2;
                                    break;
                                case '*':
                                    result = num1 * num2;
                                    break;
                                case '/':
                                    result = num1 / num2;
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong format!", "Error");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong format!", "Error");
                        return;
                    }

                    output += subs[i] + " = " + result.ToString() + '\n';
                }

                richTextBoxOutput.Text = output;
            }
            else
            {
                MessageBox.Show("Empty text file!", "Error");
                return;
            }


        }


        private void StreamWriter_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                string path = ofd.FileName;

                string data = richTextBoxOutput.Text;

                File.Create(path).Close();

                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine(data);
                    sw.Close();
                }
            }

            catch (Exception) { }


        }

    }
}


            



        
