using System.Text;

namespace Console_Example
{
    public class SaveCSVFile
    {
        public const string path = @"D:\";

        public void SaveFile(string saveFileName, string[] result)
        {
            if (Validate(result))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(path);
                stringBuilder.Append("/");
                stringBuilder.Append(saveFileName);

                File.WriteAllLines(stringBuilder.ToString(), result);
            }
        }

        public bool Validate(string[] arr)
        {
            try
            {
                if (arr.Length > 0)
                    return true;


                throw new Exception("빈 배열 들어옴");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }

        }
    }
}
