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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ErrorInput()
        {
            MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> Grade = new List<double>();
            try
            {
                if (textBox1.Text.EndsWith(","))
                {
                    ErrorInput();
                    return;
                }

                string[] seperator = { ", " };
                Grade = textBox1.Text.Split(seperator, StringSplitOptions.None).Select(double.Parse).ToList();
                for(int i = 0; i < Grade.Count; ++i)
                {
                    if (Grade[i] < 0 || Grade[i] > 10)
                    {
                        ErrorInput();
                        return;
                    }
                }

                MessageBox.Show("Xuất thành công!", "Thông báo");

            }

            catch(Exception)
            {
                ErrorInput();
                return;
            }

            //Xuat diem tung mon
            string Result = "";

            for (int i = 0; i < Grade.Count; ++i)
            {
                int j = i + 1;

                if (j % 3 == 0) Result += "Điểm môn " + j + ": " + Grade[i] + "đ" + "\r\n";  //In đủ 3 môn thì xuống dòng
                else Result += "Điểm môn " + j + ": " + Grade[i] + "đ" + "\t";
            }

            textBox2.Text = Result;



            //Diem trung binh
            double sum = 0;
            double TB = 0;

            for (int i = 0; i < Grade.Count; ++i)
                sum += Grade[i];

            TB = sum / Grade.Count;
            double TBR = Math.Round(TB, 2);
            textBoxDTB.Text = "Điểm trung bình: " + TBR.ToString() + " đ";



            //Hoc luc
            bool Gioi = true;
            bool Kha = true;
            bool TrB = true;
            bool Yeu = true;
            string HocLuc = "";

            for (int i = 0; i < Grade.Count; i++)
            {
                if (Grade[i] < 6.5) Gioi = false;
                if (Grade[i] < 5) Kha = false;
                if (Grade[i] < 3.5) TrB = false;
                if (Grade[i] < 2) Yeu = false;
            }

            if (TB >= 8 && Gioi == true) HocLuc = "Giỏi";
            else if (TB >= 6.5 && Kha == true) HocLuc = "Khá";
            else if (TB >= 5 && TrB == true) HocLuc = "Trung bình";
            else if (TB >= 3.5 && Yeu == true) HocLuc = "Yếu";
            else  HocLuc = "Kém";


            textBoxHocluc.Text = "Xếp loại học lực: " + HocLuc;


            //Diem cao nhat, thap nhat
            if (Grade.Count > 0)
            {
                double min = Grade[0];
                double max = Grade[0];

                for(int i = 1; i < Grade.Count; ++i)
                {
                    if (Grade[i] > max) max = Grade[i];
                    if (Grade[i] < min) min = Grade[i];
                }

                textBoxMax.Text = "Môn có điểm cao nhất: " + max.ToString() + " đ";
                textBoxMin.Text = "Môn có điểm thấp nhất: " + min.ToString() + " đ";



               

                //So mon dau, khong dau
                int Dau = 0;

                for(int i = 0; i < Grade.Count; ++i)
                {
                    if (Grade[i] >= 5) Dau++;
                }

                int Rot = Grade.Count - Dau;

                textBoxDau.Text = "Số môn đâu: " + Dau.ToString();
                textBoxRot.Text = "Số môn không đậu: " + Rot.ToString();



            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
