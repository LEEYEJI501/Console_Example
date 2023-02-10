using System;
using System.IO;
using System.Text;

namespace Console_Example
{
    public class SaveCSVFile
    {
        public const string path = @"D:\";

        public void SaveFile(string saveFileName, string[] result)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(path);
            stringBuilder.Append("/");
            stringBuilder.Append(saveFileName);

            try
            {
                File.WriteAllLines(stringBuilder.ToString(), result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            //string fileName = "test.csv";
            //FileStream fileStream = null;

            //try
            //{
            //    fileStream = new FileStream(fileName, FileMode.Create);
            //    using (StreamWriter writer = new StreamWriter(fileStream))
            //    {
            //        writer.Write("");
            //    }
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (fileStream != null)
            //    {
            //        fileStream.Dispose();
            //    }
            //}
        }
    }
}
