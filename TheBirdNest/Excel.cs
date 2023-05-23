using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel= Microsoft.Office.Interop.Excel;
using System.IO;

namespace TheBirdNest
{
    class Excel
    {
        _Application excel = new _Excel.Application();
        Workbook workbook;
        Worksheet worksheet;

        public Excel(int sheet)
        {
            string path = "BirdNessXl.xlsx";
            workbook = excel.Workbooks.Open(Directory.GetCurrentDirectory() + "\\" + path);
            worksheet = workbook.Worksheets[sheet];
        }
        //Read from Excel
        public string readCell(int i,int j)
        {
            i++;
            if (worksheet.Cells[i,j].Value2 !=null)
            {
                return worksheet.Cells[i, j].Value2.ToString();
            }
            else
                return "";
        }
        //Write to Excel
        public void writeToCell(int i, string user, string pass, string id)
        {
            i++;
            worksheet.Cells[i, 1].Value2 = user;
            worksheet.Cells[i, 2].Value2 = pass;
            worksheet.Cells[i, 3].Value2 = id;
        }

        public void Save()
        {
            workbook.Save();
        }
        public void Close()
        {
            var process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (var p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }
        public void closeExecl()
        {
            workbook.Close();
            excel.Quit();
            excel = null;
        }

        public void saveAs(string path)
        {
            workbook.SaveAs(path);
        }

    }
}
