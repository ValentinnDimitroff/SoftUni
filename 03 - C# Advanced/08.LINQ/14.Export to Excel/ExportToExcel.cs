using System;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

public class ExportToExcel
{
    public static void Main()
    {
        //var newFile = new FileInfo(@"../../sample.xlsx");
        
        var xlsPackage = new ExcelPackage();
        var workSheet = CreateSheet(xlsPackage, "Student Results");
        workSheet.Cells[1, 1, 1, 11].Merge = true;
        workSheet.Cells[1, 1].Value = "SoftUni Exam Results";
        workSheet.Cells[1, 1].Style.Font.Size = 18;
        workSheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
        workSheet.Protection.IsProtected = false;

        var row = 2;
        using (var reader = new StreamReader("../../StudentData.txt"))
        {
            var line = reader.ReadLine();
            while (line != null)
            {
                var readCells = line.Split('\t');
                for (int i = 1; i <= readCells.Length; i++)
                {
                    workSheet.Cells[row, i].Value = readCells[i - 1];
                }
                row++;
                line = reader.ReadLine();
            }
        }

        var output = new FileStream("../../sample.xlsx", FileMode.Create);
        xlsPackage.SaveAs(output);
    }

    private static ExcelWorksheet CreateSheet(ExcelPackage p, string sheetName)
    {
        p.Workbook.Worksheets.Add(sheetName);
        ExcelWorksheet ws = p.Workbook.Worksheets[1];
        ws.Name = sheetName; //Setting Sheet's name
        ws.Cells.Style.Font.Size = 11; //Default font size for whole sheet
        ws.Cells.Style.Font.Name = "Calibri"; //Default Font name for whole sheet

        return ws;
    }
}