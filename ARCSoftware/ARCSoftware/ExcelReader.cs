using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace ARCSoftware
{
    static class ExcelReader
    {
       static  List<Student> Students = new List<Student>();
        static _Application excel = new _Excel.Application();
        static string path;
        static Workbook wb;
        static Worksheet ws;
       public static List<Student> Read(string path)
        {
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[2];
            int walker = 2;
            while (ws.Cells[walker,1].Value2 != null)
            {
                Student st = new Student();
                st.EMPID = Convert.ToString(ws.Cells[walker, 1].Value2);
                st.ID = (string)ws.Cells[walker, 2].Value2;
                st.Name = (string)ws.Cells[walker, 3].Value2;
                st.Gender = (string)ws.Cells[walker, 4].Value2;
                st.Year = Convert.ToString(ws.Cells[walker, 5].Value2); 
                st.Semester = Convert.ToInt32(ws.Cells[walker, 6].Value2); 
                st.CGPA = Convert.ToDecimal(ws.Cells[walker, 7].Value2); 
                walker++;
                Students.Add(st);
            }
            return Students;

        }
     


    }
}
