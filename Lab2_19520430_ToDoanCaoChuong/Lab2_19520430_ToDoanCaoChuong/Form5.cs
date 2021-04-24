using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Lab2_19520430_ToDoanCaoChuong
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }


        Microsoft.Office.Interop.Excel.Application objApp;
        Microsoft.Office.Interop.Excel._Workbook objBook;
        private void InputButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello :)");


            Input_Bai5 Ib5 = new Input_Bai5();
            Ib5.Show();
        }

        private void SaveInExcel_Click(object sender, EventArgs e) 
        {
            try
            {
                int row = 1;

                //Create an array.
                string[,] saRet = new string[7, 1000];

                saRet[0, 0] = "MSSV";
                saRet[0, 1] = "Họ tên";
                saRet[0, 2] = "Điện thoại";
                saRet[0, 3] = "Điểm Toán";
                saRet[0, 4] = "Điểm Văn";
                saRet[0, 5] = "ĐTB";

                

                string path = "";
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }

                using (var sr = new StreamReader(path)) 
                {

                   
                    string temp = "";
                    string[] tempAr = new string[3];



                    while (sr.Peek() != -1)
                    {
                        temp = sr.ReadLine();

                        tempAr = temp.Split(';');

                        saRet[row, 0] = tempAr[0];
                        saRet[row, 1] = tempAr[1];
                        saRet[row, 2] = tempAr[2];
                        saRet[row, 3] = tempAr[3];
                        saRet[row, 4] = tempAr[4];
                        saRet[row, 5] = (((Double.Parse(tempAr[3]) + Double.Parse(tempAr[4])) / 2)).ToString();
                        row++;
                    }
                    sr.Close();
                }




                Microsoft.Office.Interop.Excel.Workbooks objBooks;
                Microsoft.Office.Interop.Excel.Sheets objSheets;
                Microsoft.Office.Interop.Excel._Worksheet objSheet;
                Microsoft.Office.Interop.Excel.Range range;


                
                objApp = new Microsoft.Office.Interop.Excel.Application();
                objBooks = objApp.Workbooks;
                objBook = objBooks.Add(Missing.Value);
                objSheets = objBook.Worksheets;
                objSheet = (Microsoft.Office.Interop.Excel._Worksheet)objSheets.get_Item(1);

               
                range = objSheet.get_Range("A1", Missing.Value);
                range = range.get_Resize(row, 6);


                
                range.set_Value(Missing.Value, saRet);

              
                objApp.Visible = true;
                objApp.UserControl = true;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }







        }

        private void ShowInExcel_Click(object sender, EventArgs e)
        {
            string name = "";
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Excel File";
            ofd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                name = ofd.FileName;
            }

            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(name);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                dataGridView1.ColumnCount = colCount;
                dataGridView1.RowCount = rowCount;

                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {

                        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        {

                            dataGridView1.Rows[i - 1].Cells[j - 1].Value = xlRange.Cells[i, j].Value2.ToString();

                        }

                    }
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();


                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }

            catch(Exception) { }

        }


        }


    }
    



    

