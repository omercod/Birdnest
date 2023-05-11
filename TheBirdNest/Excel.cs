using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel= Microsoft.Office.Interop.Excel;

namespace TheBirdNest
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }
        //Read from Excel
        public string readCell(int i,int j)
        {
            i++;
            if (ws.Cells[i,j].Value2 !=null)
            {
                return ws.Cells[i, j].Value2.ToString();
            }
            else
                return "";
        }
        //Write to Excel
        public void writeToCell(int i, string user, string pass, string id)
        {
            i++;
            ws.Cells[i, 1].Value2 = user;
            ws.Cells[i, 2].Value2 = pass;
            ws.Cells[i, 3].Value2 = id;
        }

        public void Save()
        {
            wb.Save();
        }
        public void Close()
        {
            wb.Close();
            excel.Quit();
            excel = null;
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

        public void saveAs(string path)
        {
            wb.SaveAs(path);
        }

    }
}
