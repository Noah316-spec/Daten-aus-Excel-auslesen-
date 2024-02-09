using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WPF_Anwendung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string path1 = @"L:\\DOKU-LVS\\03_Anleitungen & Infos\\TLG_20230130.xlsx";


            ReadExcelRowAndCompare(path1, textBox1.Text);

        }
        public void ReadExcelRowAndCompare(string filePath, string textBoxValue)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.UsedRange;

            object[,] values = usedRange.Value2;

            for (int i = 19; i <= values.GetLength(0); i++)
            {
                if (values[i, 4] != null)
                {
                    string cellValue = values[i, 4].ToString();
                    if (cellValue.Length >= 4)
                    {
                        string lastFourNumbers = cellValue.Substring(cellValue.Length - 4);
                        if (lastFourNumbers == textBoxValue)
                        {
                            // Spalten B, C, D, E, H, I und J entsprechen den Indizes 2, 3, 4, 5, 8, 9 und 10
                            int[] columnsToShow = new int[] { 2, 3, 4, 5, 8, 9, 10 };
                            foreach (int j in columnsToShow)
                            {
                                if (values[i, j] != null)
                                {
                                    string cellToWriteValue = values[i, j].ToString();
                                    textBox2.Text += cellToWriteValue + Environment.NewLine;
                                }
                            }
                            textBox2.Text += Environment.NewLine;
                        }

                    }
                }
            }


            workbook.Close();
            excelApp.Quit();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

       
    }
}
