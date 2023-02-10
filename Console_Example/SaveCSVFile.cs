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

            if (ValidateParams(result))
            {
                File.WriteAllLines(stringBuilder.ToString(), result);
            }
        }

        public bool ValidateParams(string[] arr)
        {
            try
            {
                if (arr.Length > 0)
                    return true;
                else
                    Console.WriteLine("결과값이 빈 배열입니다.");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
