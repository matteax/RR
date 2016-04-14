﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using System.IO;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;


namespace ExcelData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            app.WindowState = XlWindowState.xlMaximized;

            APMONGO

            Workbook wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = wb.Worksheets[1];
            Excel.Range aRange;
            DateTime currentDate = DateTime.Now;

            // Set the range to fill.
            aRange = ws.get_Range("A1", "M100");



            int[] HB10sec = new int[] { 1, 2, 31, 6, 5, 3213, 7, 8 };
            int[] Knee10sec = new int[] { 1, 2, 31, 666, 5, 3213, 7, 8 };
            int[] Hip10sec = new int[] { 1, 2, 31, 3213123, 5, 3213, 7, 8 };

            for (int i = 1; i <= HB10sec.Length; i++)
            {
                ws.Range["A0" + (i + 2)].Value = "'" + (i * 10) + "-" + (i + 1) * 10;
                ws.Range["B0" + (i + 2)].Value = HB10sec[i - 1];
                ws.Range["C0" + (i + 2)].Value = Knee10sec[i - 1];
                ws.Range["D0" + (i + 2)].Value = Hip10sec[i - 1];

            }

            string time = DateTime.Now.ToString(@"MM\/dd\/yyyy HH:mm tt");
            string Namn = "Ano Nym";


            ws.Range["E1"].Value = "Namn: " + Namn;
            ws.Range["F1"].Value = "Date and Time: " + time;
            ws.Range["A2"].Value = "Intervall [sec]";
            ws.Range["B2"].Value = "HeartBeat";
            ws.Range["C2"].Value = "Angle Hip";
            ws.Range["D2"].Value = "Angle Knee";

            aRange.Columns.AutoFit();
            aRange.EntireColumn.AutoFit();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
                wb.SaveAs(saveFileDialog.FileName);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HEJasdfasdf");
        }
    } }
        
        
  