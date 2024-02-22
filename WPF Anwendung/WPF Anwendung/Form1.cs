using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
        public string path2 = @"L:\\DOKU-LVS\\03_Anleitungen & Infos\\TESUB1.xlsx";
        public string path1 = @"L:\\DOKU-LVS\\03_Anleitungen & Infos\\TLG_202301301.xlsx";
        public string path3 = @"L:\\programme64\\Abfrage Telegramme\\Excel\\test.xlsx";


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
            comboBox1.SelectedIndex = 0; // standard auswahl

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ""; // zurücksetzen
            textBox1.Text = "";
            if (comboBox1.SelectedIndex == 0) // auswahl combobox
            {

                ReadExcelRowAndCompare(path1, eingabetlg.Text);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                teabfrage(path2, eingabete.Text);
                subabfrage(path2, eingabete2.Text);
                eingabete.Text = "";
                eingabete2.Text = "";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                winkelcode(eingabete2.Text);
            }
            else
            {
                abfrageAuft(path3, eingabete.Text);
                abfrageSub(path3, eingabete2.Text);
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
                telbl1.Text = "TE Status:";
                lblbezte.Text = "Te Bezeichnung:";

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                abfragete(false);
                telbl1.Text = "AUFT:";
                lblbezte.Text = "AUFT Bezeichnung:";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                abfragete(false);
                telbl1.Text = "Winkelcode:";
                eingabete.Visible = false;
                trente.Visible = false;
                lblbezsub.Visible = false;
                textBox1 .Visible = false;
                lblbezte.Text = "Winkelcode:";
            }
            else if(comboBox1.SelectedIndex == 4)
            {
                // noch in bearbeitung
                abfragete(false);
                telbl1.Text = "Nummernkreis LVS:";
                eingabete.Visible = false;
                trente.Visible = false;
                lblbezsub.Visible = false;
                textBox1.Visible = false;
                lblbezte.Text = "Ausgabe:";
                eingabete2.Size = new System.Drawing.Size(100, 20);
            }


        }
        public void kreis(int s)
        {
            for (int i = 0; i < 319999999; i++)
            {
                if ((i >= 899) && (s == i))
                {
                    textBox2.Text = "Zielsteuerung";
                }
                else if ((i <= 900 && i >= 999) && (s == i))
                {
                    textBox2.Text = "Behälter K11/K15";
                }
                else if ((i <= 1000 && i >= 1999) && (s == i))
                {
                    textBox2.Text = "LateFit-Behälter";
                }
                else if ((i <= 2000 && i >= 2999) && (s == i))
                {
                    textBox2.Text = "Regalpaletten (LateFit)";
                }
                else if ((i <= 3000 && i >= 9999) && (s == i))
                {
                    textBox2.Text = "Packstücke Exportpackerei";
                }
                else if ((i <= 10000 && i >= 99999) && (s == i))
                {
                    textBox2.Text = "Versand-TE Exportpackerei";
                }
                else if((i <=100000 && i>= 479999)&&(s == i))
                {
                    textBox2.Text = "";
                }
                else if ((i <= 480000 && i >= 499999) && (s == i))
                {
                    textBox2.Text = "KTL Behälter";
                }
                else if ((i <= 500000 && i >= 989999) && (s == i))
                {
                    textBox2.Text = "KFE (Kommissioniereinheit)Pal / TOF-Gestell";
                }
                else if ((i <= 990000 && i >= 999990) && (s == i))
                {
                    textBox2.Text = "";
                }
                else if ((i <= 9999991 && i >= 999998) && (s == i))
                {
                    textBox2.Text = "TE Wareneingang";
                }
                else if ((i == 999999 ) && (s == i))
                {
                    textBox2.Text = "TE Wareneingang";
                }
            }

        }
        public void winkelcode(string ws)
        {
            if( ws.Length >= 2)
            {
                MessageBox.Show("Fehler bitte nur einen Buchstabe eingeben bzw. eine Zahl");
                eingabete2.Text = "";
                
            }
            else
            {
                textBox2.Text = "";
                switch (ws)
                {
                    case "J":
                    case "j":
                        textBox2.Text = "TEHT ist gestretcht";
                        break;
                    case "N":
                    case "n":
                        textBox2.Text = "TEHT ist nicht gestretcht; bei einer Ganzauslagerung muss dies  noch gemacht werden";
                        break;
                    case "2":
                        textBox2.Text = "Vollwicklung mit Deckblatt (Wickelcode 2). Nur für BBMD, SPEZ und SPER mit Versandart 62.";
                        break;
                    case "5":
                        textBox2.Text = "TEHT ist nicht gestretcht; bei einer Ganzauslagerung muss dies  noch gemacht werden";
                        break;
                    case "O":
                    case "o":
                        textBox2.Text = "Ohne Wicklung (Wickelcode 6). Nur für BBMD, SPEZ und SPER mit Versandart 60. ";
                        break;
                    case "F":
                    case "f":
                        textBox2.Text = "Fuss Wicklung bei Ganzauslagerung (Wickelcode 4)";
                        break;
                    default:
                        textBox2.Text = "Hinweis: Auf Wunsch von BBM heißt dieses Feld tatsächlich GESTRECHT und nicht GESTRETCHT, wie dies eigentlich korrekt wäre!";
                        break;
                }

            }
        }
        public void abfragete(bool i)
        {
            if (i == true)
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
            else if (i == false)
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
        private void teabfrage(string path, string wert)
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
        private void subabfrage(string path, string wert)
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

        private void abfrageAuft(string path, string wert)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.get_Range("A2", "A10");
            Excel.Range usedRange1 = worksheet.get_Range("B2", "B10");
            for (int i1 = 1;i1 <= usedRange.Rows.Count;i1++)
            {
                string cellValue = usedRange.Cells[i1, 1].Value.ToString();
                if(cellValue.Substring(cellValue.Length -2)== wert)
                {
                    textBox2.Text = usedRange1.Cells[i1,1].Value.ToString();
                }
            }
            workbook.Close(false);
            excelApp.Quit();
        }
        private void abfrageSub(string path, string wert)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.get_Range("A12", "A15");
            Excel.Range usedRange1 = worksheet.get_Range("B12", "B15");
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
            if (comboBox1.SelectedIndex != 4)
            {
                // Erlaubt nur die Eingabe von maximal 2 Zeichen
                if (eingabete2.Text.Length >= 2)
                {
                    e.Handled = true; // Ignoriert weitere Tastenanschläge
                }
            }
        }
        

       
    }
}
