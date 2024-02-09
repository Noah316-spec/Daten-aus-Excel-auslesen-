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
        // Konstruktor der Form1-Klasse
        public Form1()
        {
            InitializeComponent(); // Initialisiert die Komponenten der Form
        }

        // Diese Methode wird aufgerufen, wenn das Formular geladen wird
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Diese Methode wird aufgerufen, wenn der Benutzer auf den ersten Button klickt
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ""; // Setzt den Text des zweiten Textfelds zurück
            string path1 = @"ihrenPfad"; // Pfad zur Excel-Datei

            // Ruft die Methode zum Lesen und Vergleichen der Excel-Zeilen auf
            ReadExcelRowAndCompare(path1, textBox1.Text);
        }

        // Diese Methode liest eine Excel-Datei und vergleicht die Daten mit der Eingabe des Benutzers
        public void ReadExcelRowAndCompare(string filePath, string textBoxValue)
        {
            Excel.Application excelApp = new Excel.Application(); // Erstellt eine neue Excel-Anwendung
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath); // Öffnet das Workbook an dem angegebenen Pfad
            Excel._Worksheet worksheet = workbook.Sheets[1]; // Zugriff auf das erste Arbeitsblatt
            Excel.Range usedRange = worksheet.UsedRange; // Zugriff auf den benutzten Bereich des Arbeitsblatts

            object[,] values = usedRange.Value2; // Speichert die Werte des benutzten Bereichs in einem Array

            // Durchläuft die Zeilen des benutzten Bereichs
            for (int i = 19; i <= values.GetLength(0); i++)
            {
                // Überprüft, ob der Wert in der vierten Spalte der aktuellen Zeile nicht null ist
                if (values[i, 4] != null)
                {
                    string cellValue = values[i, 4].ToString(); // Konvertiert den Wert in einen String
                    // Überprüft, ob die Länge des Strings mindestens 4 ist
                    if (cellValue.Length >= 4)
                    {
                        // Extrahiert die letzten vier Ziffern des Strings
                        string lastFourNumbers = cellValue.Substring(cellValue.Length - 4);
                        // Überprüft, ob die letzten vier Ziffern dem Wert im Textfeld entsprechen
                        if (lastFourNumbers == textBoxValue)
                        {
                            // Definiert die Spalten, die angezeigt werden sollen
                            int[] columnsToShow = new int[] { 2, 3, 4, 5, 8, 9, 10 };
                            // Durchläuft die definierten Spalten
                            foreach (int j in columnsToShow)
                            {
                                // Überprüft, ob der Wert in der aktuellen Spalte und Zeile nicht null ist
                                if (values[i, j] != null)
                                {
                                    string cellToWriteValue = values[i, j].ToString(); // Konvertiert den Wert in einen String
                                    // Fügt den Wert zum Text des zweiten Textfelds hinzu
                                    textBox2.Text += cellToWriteValue + Environment.NewLine;
                                }
                            }
                            // Fügt eine leere Zeile zum Text des zweiten Textfelds hinzu
                            textBox2.Text += Environment.NewLine;
                        }
                    }
                }
            }

            // Schließt das Workbook und beendet die Excel-Anwendung
            workbook.Close();
            excelApp.Quit();
        }

        // Diese Methode wird aufgerufen, wenn der Benutzer auf den zweiten Button klickt
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Beendet die Anwendung
        }

        // Diese Methode wird aufgerufen, wenn der Benutzer eine Taste im ersten Textfeld drückt
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
