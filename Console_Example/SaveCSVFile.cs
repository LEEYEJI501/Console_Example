﻿using System.Text;

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

        // 파일 중복
        public string FileUploadName(string dirPath, string fileName)
        {
            if (fileName.Length> 0)
            {
                int indexOfDot = fileName.LastIndexOf('.');
                string strName = fileName.Substring(0, indexOfDot);
                string strExt = fileName.Substring(indexOfDot);

                bool exist = true;
                int fileCount = 0;

                string dirMapPath = string.Empty;

                while (exist)
                {
                    dirMapPath = dirPath;
                    string pathCombine = Path.Combine(dirMapPath, fileName);

                    if(File.Exists(pathCombine))
                    {
                        fileCount++;
                        fileName = strName + "(" + fileCount + ")" + strExt;
                    }
                    else
                    {
                        exist= false;
                    }
                }
                
            }
            return fileName;
        }
    }
}
