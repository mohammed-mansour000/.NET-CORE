using System;
using System.Text;
using ClosedXML.Excel;

namespace week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a directory path to list it's files:");
            var folderPath = Console.ReadLine();
            string[] files = System.IO.Directory.GetFiles(folderPath);
            string finalResult = string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach (var file in files)
            {
                //stringBuilder is highly recommended to be used, it saves alot of memory
                sb.AppendLine(file);
            }
            finalResult = sb.ToString();
            Console.WriteLine(sb);
            System.IO.File.WriteAllText(@"C:\Users\Hamzi\Desktop\hamzi.txt", finalResult);

        
        //using (var workbook = new XLWorkbook())// --using-- it kills everything mentioned in the using !!! 
        //{
        //    var worksheet = workbook.Worksheets.Add("hamzi sheet");
        //    worksheet.Cell("A1").Value = "full stack training";
        //    //worksheet.Cell("A2").FormulaA1 = "=MID(A1, 7, 5)";
        //    workbook.SaveAs(@"C:\Users\Hamzi\Desktop\hamzi.xlsx");
        //}
    }
    }
}
