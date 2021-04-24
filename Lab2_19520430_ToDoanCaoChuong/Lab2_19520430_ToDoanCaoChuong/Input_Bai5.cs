using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Lab2_19520430_ToDoanCaoChuong
{
    public partial class Input_Bai5 : Form
    {
        public Input_Bai5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                //Lưu dữ liệu vào trong Lab2_19520430_ToDoanCaoChuong\Lab2_19520430_ToDoanCaoChuong\bin\Debug\textz.txt
                //để thuận tiện cho việc lưu vào Excel :3

                string path = ofd.FileName;

                using (StreamWriter sw = File.AppendText(path))
                {

                    
                    sw.Write(textBoxMSSV.Text + ";");
                    sw.Write(textBoxName.Text + ";");
                    sw.Write(textBoxPhone.Text + ";");
                    sw.Write(textBoxToan.Text + ";");
                    sw.WriteLine(textBoxVan.Text);
                    

                    MessageBox.Show("Nhập thành công!", "Thông báo");

                    sw.Close();
                }


                
            }

            catch (Exception) { }

        }
    }
}
