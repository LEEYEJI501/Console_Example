using System;
using System.IO;
using System.Linq;

namespace Console_Example
{
    public class StreamBuilder : StreamBuilderInterface
    {
        public string readFileName = "";

        public string[] Read()
        {
            string[] arr = { };

            if (Validate())
            {
                arr = File.ReadAllLines(readFileName);
                return arr;
            }
            else
            {
                return arr;
            }
        }

        public bool Validate()
        {
            try
            {
                if (!File.Exists(readFileName))
                {
                    throw new NullReferenceException("파일이 존재하지 않습니다.");

                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public T[] Sort<T>(T[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        public T[] Reverse<T>(T[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }

        public int[] ParseInt(string[] arr)
        {
            int[] intArr = Array.ConvertAll(arr, str => int.Parse(str));
            return intArr;
        }

        public T[] LinqOrderBy<T>(T[] arr)
        {
            arr = arr.OrderBy(s => s).ToArray();
            return arr;
        }

        public T[] LinqOrderByDescending<T>(T[] arr)
        {
            arr = arr.OrderByDescending(s => s).ToArray();
            return arr;
        }

        public T[] Distinct<T>(T[] arr)
        {
            return arr.Distinct().ToArray();
        }
    }
}