using Microsoft.Office.Interop.Excel;
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
        Timer timer = new Timer();
        public static DateTime Now { get; }
        public string path2 = @"Dein Pfad";
        public string path1 = @"Dein Pfad";
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000; // Setzt das Intervall auf 1 Sekunde (1000 Millisekunden)
            timer.Tick += new EventHandler(timer_Tick); // Fügt das Event hinzu, das bei jedem Tick aufgerufen wird
            timer.Start(); // Startet den Time
            

        }
        void timer_Tick(object sender, EventArgs e)
        {
            timerwert.Text = DateTime.Now.ToString("HH:mm:ss"); // Aktualisiert den Text der TextBox bei jedem Tick
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            if(comboBox1.SelectedIndex == 0)
            {

                ReadExcelRowAndCompare(path1, eingabetlg.Text);
            }
            else
            {
                teabfrage(path2,eingabete.Text);
                subabfrage(path2, eingabete2.Text);
                eingabete.Text = "";
                eingabete2.Text = "";
            }

        }
        public void ReadExcelRowAndCompare(string filePath, string textBoxValue)
        {
            if (textBoxValue.Length == 4)
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
            else
            {
                MessageBox.Show("Eingabe überprüfen sollte nicht über/unter 4 sein !");


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                abfragete(true);


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                abfragete(false);

            }


        }
        public void abfragete(bool i)
        {
            if(i == true)
            {
                trente.Visible = false;
                eingabete.Visible = false;
                eingabete2.Visible = false;
                telbl1.Visible = false;
                textBox1.Visible = false;
                label6.Visible = i;
                label7.Visible = i;
                label8.Visible = i;
                label9.Visible = i;
                label10.Visible = i;
                tlg1.Visible = i;
                eingabetlg.Visible = i;
                btn1.Location = new System.Drawing.Point(343, 156);
                lblbezsub.Visible = false;
                lblbezte.Visible = false;

                label4.Visible = true;
            }
            else if(i == false) 
            {
                trente.Visible = true;
                eingabete.Visible = true;
                eingabete2.Visible = true;
                textBox1.Visible = true;
                telbl1.Visible = true;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                tlg1.Visible = false;
                eingabetlg.Visible = false;
                btn1.Location = new System.Drawing.Point(356, 110);
                lblbezsub.Visible = true;
                lblbezte.Visible = true;   
                label4.Visible = false;
            }
            
        }
        public void teabfrage(string path, string wert)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(path);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.get_Range("A2", "A20");
            Excel.Range usedRange2 = worksheet.get_Range("B2", "B20");
           
            
            for (int i = 1; i <= usedRange.Rows.Count; i++)
            {
                string cellValue = usedRange.Cells[i, 1].Value.ToString();
                if (cellValue.Substring(cellValue.Length - 2) == wert)
                {
                    textBox2.Text = usedRange2.Cells[i, 1].Value.ToString();
                }
            }
            workbook.Close(false);
            excelApp.Quit();

           

        }
        public void subabfrage(string path, string wert)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(path);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.get_Range("A22", "A37");
            Excel.Range usedRange1 = worksheet.get_Range("B22", "B37");

            for (int i1 = 1; i1 <= usedRange.Rows.Count; i1++)
            {
                string cellValue = usedRange.Cells[i1, 1].Value.ToString();
                if (cellValue.Substring(cellValue.Length - 2) == wert)
                {
                    textBox1.Text = usedRange1.Cells[i1, 1].Value.ToString();
                }
            }
            workbook.Close(false);
            excelApp.Quit();




        }

        private void eingabete_TextChanged(object sender, EventArgs e)
        {
            // Ändert den Text in Großbuchstaben
            eingabete.Text = eingabete.Text.ToUpper();

            // Setzt den Cursor wieder an das Ende des Texts
            eingabete.SelectionStart = eingabete.Text.Length;
        }

        private void eingabete2_TextChanged(object sender, EventArgs e)
        {
            // Ändert den Text in Großbuchstaben
            eingabete2.Text = eingabete2.Text.ToUpper();

            // Setzt den Cursor wieder an das Ende des Texts
            eingabete2.SelectionStart = eingabete2.Text.Length;
        }

        private void eingabete_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Erlaubt nur die Eingabe von maximal 2 Zeichen
            if (eingabete.Text.Length >= 2)
            {
                e.Handled = true; // Ignoriert weitere Tastenanschläge
            }
        }

        private void eingabete2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Erlaubt nur die Eingabe von maximal 2 Zeichen
            if (eingabete2.Text.Length >= 2)
            {
                e.Handled = true; // Ignoriert weitere Tastenanschläge
            }
        }
    }
}
