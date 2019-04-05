using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;


namespace MySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            Document doc = app.Documents.Add(Visible: true);
            Range r = doc.Range();
            //r.Text = "Привет Мир!!!";
            //r.Bold = 20;

            Table table = doc.Tables.Add(r, 5, 7);
            table.Borders.Enable = 1;
            foreach (Row row in table.Rows)
            {
                foreach (Cell cells in row.Cells)
                {
                    if (cells.RowIndex == 1)
                    {
                        cells.Range.Text = "Колонка" + cells.ColumnIndex.ToString();
                        cells.Range.Bold = 1;
                        cells.Range.Font.Name = "verdana";
                        cells.Range.Font.Size = 9;
                        cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cells.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else
                    {
                        cells.Range.Text = (cells.ColumnIndex + 1).ToString();
                    }
                }
            }

            doc.Save();
            app.Documents.Open(@"C:\Users\Adm\Downloads\Doc1.docx");
            Console.ReadKey();
            try
            {
                doc.Close();
                app.Quit();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
