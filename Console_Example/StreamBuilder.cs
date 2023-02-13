using System;
using System.IO;
using System.Linq;

namespace Console_Example
{
    public class StreamBuilder
    {
        public string FileName = "";

        // 파일 읽어오기
        public string[] Read()
        {
            string[] arr = { };

            if (Validate())
            {
                arr = File.ReadAllLines(FileName);
                return arr;
            }
            else
            {
                return arr;
            }
        }

        // 파일 유무 체크
        public bool Validate()
        {
            try
            {
                if (!File.Exists(FileName))
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

        // 오름차순 정렬
        public T[] Sort<T>(T[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        // 내림차순 정렬
        public T[] Reverse<T>(T[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }

        // 숫자 캐스팅
        public int[] ParseInt(string[] arr)
        {
            int[] intArr = Array.ConvertAll(arr, str => int.Parse(str));
            return intArr;
        }

        // LINQ 정렬
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

        // 중복제거
        public T[] Distinct<T>(T[] arr)
        {
            return arr.Distinct().ToArray();
        }
    }
}