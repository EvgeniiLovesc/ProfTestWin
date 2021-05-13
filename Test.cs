using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;




namespace NK_TEST
{
    class Test
    {

        public void Print(int testID)
        {
            //string fileName = @"C:\Server\data\htdocs\Repositories\NKTest\NK_TEST\WinApp\NK_TEST\Reports\Doc\Test.docx";
            string fileName = "Test.docx";
            var doc = DocX.Create(fileName);
            doc.InsertParagraph("Распечатанный тест");

            try
            {

                doc.Save();
                //doc.SaveAs();
                try
                {
                    Process.Start("WINWORD.EXE", fileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Не найдено приложение Word. Ошибка: " + e.ToString());
                    Process.Start("WORDPAD.EXE", fileName);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Не найден файл формата .docx. Ошибка: " + e.ToString());
            }
        }
    }
}
