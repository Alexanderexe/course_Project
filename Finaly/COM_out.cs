using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel =  Microsoft.Office.Interop.Excel;

namespace Finaly
{
    class COM_out
    {
        
        excel.Application Eapp;
        excel.Worksheet sheet;
        
        excel.Workbook book;





        public COM_out()
        {
            Eapp = new excel.Application();
            sheet = new excel.Worksheet();




        }
     
        public void reporttoexcel_turnover(List<string> station_name_list, List<int> station_turnover_list, List<int> station_avg_list)
        {


            
            Eapp.Visible = true;

            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            book = Eapp.Workbooks.Open(path + @"\отчет_станций_шаблон.xlsx");

            excel.Worksheet sheet = (excel.Worksheet)book.Worksheets.get_Item(1);
           
            excel.Range range_sheet = sheet.UsedRange;

            for (int i = 2; i < station_name_list.Count + 2; i++)
            {

                excel.Range range_cur = range_sheet.Cells[i, 1];
                
                range_cur.Value2 = station_name_list[i - 2];

                range_cur = range_sheet.Cells[i, 2];
                range_cur.Value2 = station_turnover_list[i - 2];

                range_cur = range_sheet.Cells[i, 3];
                range_cur.Value2 = station_avg_list[i - 2];
               

            }
            
            book.SaveAs(path + @"\reports\отчет_станций.xlsx");
            Eapp.Quit();

        }


        public void reporttoexcel_clients(List<string> station_name_list, List<int> station_turnover_list, List<int> station_avg_list)
        {



            Eapp.Visible = true;

            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            book = Eapp.Workbooks.Open(path + @"\отчет_клиента_шаблон.xlsx");

            excel.Worksheet sheet = (excel.Worksheet)book.Worksheets.get_Item(1);

            excel.Range range_sheet = sheet.UsedRange;

            for (int i = 2; i < station_name_list.Count + 2; i++)
            {

                excel.Range range_cur = range_sheet.Cells[i, 1];

                range_cur.Value2 = station_name_list[i - 2];

                range_cur = range_sheet.Cells[i, 2];
                range_cur.Value2 = station_turnover_list[i - 2];

                range_cur = range_sheet.Cells[i, 3];
                range_cur.Value2 = station_avg_list[i - 2];


            }

            book.SaveAs(path + @"\reports\отчет_клиента.xlsx");
            Eapp.Quit();

        }

    }
}
