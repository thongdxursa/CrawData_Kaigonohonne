using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace CrawData_Kaigonohonne.Controller
{

    public class ProcessExcels
    {
        public delegate bool ActionReadRowExcel(string sheetName, int totalRow, int rowIndex, Dictionary<int, string> col);
        private static string getCell(Microsoft.Office.Interop.Excel.Range xlRange, int rowIndex, int colIndex)
        {
            string col = (xlRange.Cells[rowIndex, colIndex] != null && xlRange.Cells[rowIndex, colIndex].Value2 != null) ? xlRange.Cells[rowIndex, colIndex].Value2.ToString().Trim() : "";
            return col;
        }
        public static List<Dictionary<string, object>> ReadExcel(string fileExcel, ActionReadRowExcel actionReadRowExcel)
        {
            List<Dictionary<string, object>> listLS = new List<Dictionary<string, object>>();
            if (!File.Exists(fileExcel))
            {
                return listLS;
            }
            //Create COM Objects. Create a COM object for everything that is referenced
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileExcel);
            Console.WriteLine("Total sheet:" + xlWorkbook.Sheets.Count);

            int totalSheet = xlWorkbook.Sheets.Count;
            for (int sheetIndex = 1; sheetIndex <= xlWorkbook.Sheets.Count; sheetIndex++)
            {
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[sheetIndex];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                string sheetName = "Sheet name:" + xlWorksheet.Name + " - sheet current: " + sheetIndex + "/" + totalSheet;
                bool isContinueAll = true;
                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                for (int indexRow = 1; indexRow <= rowCount; indexRow++)
                {
                    var dicCol = new Dictionary<int, string>();
                    for (int indexCol = 1; indexCol <= colCount; indexCol++)
                    {
                        string col1 = getCell(xlRange, indexRow, indexCol);
                        dicCol.Add(indexCol, col1);
                    }
                    bool isContinue = actionReadRowExcel(sheetName, rowCount, indexRow, dicCol);
                    if (isContinue == false)
                    {
                        isContinueAll = false;
                        break;
                    }

                }

                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);
                if (isContinueAll == false)
                {
                    break;
                }
            }
            Console.WriteLine("Reading success!");
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();



            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            return listLS;
        }
    }
}
