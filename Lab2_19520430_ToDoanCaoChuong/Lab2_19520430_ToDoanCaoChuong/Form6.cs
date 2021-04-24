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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }


        private void GetFilesAndDirectories(string Path, ref ListView lv, ref TextBox tb)
        {
            textBoxPath.Text = Path;

            DirectoryInfo di = new DirectoryInfo(Path);
            if (!di.Exists)
            {
                MessageBox.Show("Check your path!", "Error");
                return;
            }
            else
            {
                lv.Clear();

                lv.Columns.Add("Tên file");
                lv.Columns.Add("Kích thước");
                lv.Columns.Add("Đuôi mở rộng");
                lv.Columns.Add("Ngày tạo");
                lv.Columns.Add("Là thư mục");

                FileInfo[] FileArray = di.GetFiles();
                DirectoryInfo[] DirArray = di.GetDirectories();

                for (int i = 0; i < FileArray.Length; i++)
                {
                    string[] FileItems = { FileArray[i].Name, FileArray[i].Length.ToString(), FileArray[i].Extension, FileArray[i].CreationTime.ToString(), "Không" };
                    ListViewItem lvFiles = new ListViewItem(FileItems);

                    lv.Items.Add(lvFiles);
                }

                for (int i = 0; i < DirArray.Length; i++)
                {
                    string[] DirItems = { DirArray[i].Name, string.Empty, string.Empty, DirArray[i].CreationTime.ToString(), "Có" };
                    ListViewItem lvDirs = new ListViewItem(DirItems);

                    lv.Items.Add(lvDirs);
                }
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            GetFilesAndDirectories(textBoxPath.Text, ref listView, ref textBoxPath);
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] PathParts = textBoxPath.Text.Split(new char[] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries);

            string Path = string.Empty;
            for (int i = 0; i < PathParts.Length; i++)
            {
                Path += PathParts[i] + '\\';
            }

            GetFilesAndDirectories(Path + listView.SelectedItems[0].Text, ref listView, ref textBoxPath);
        }
    }
}
