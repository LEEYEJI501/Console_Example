namespace Console_Example
{
    class SaveCSVFile
    {
        public void SaveFile()
        {
            string fileName = "test.csv";
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.Write("");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }
    }
}
