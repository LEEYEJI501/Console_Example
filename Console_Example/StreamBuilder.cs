﻿using System;
using System.IO;
using System.Linq;

namespace Exam_Stream
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
                    throw new NullReferenceException("해당 파일이 존재하지 않습니다.");

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
        public string[] Sort(string[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        // 내림차순 정렬
        public Array Reverse<T>(T[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }

        // 숫자 캐스팅
        public int[] ParseInt(string[] arr)
        {
            int[] intArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                intArr[i] = Int32.Parse(arr[i]);
            }
            return intArr;
        }

        // LINQ 정렬
        public Array LinqOrderBy(string[] arr)
        {
            //arr.OrderBy(s => s).ToArray();
            return arr.OrderBy(s => s).ToArray();
        }

        public Array LinqOrderByDescending(string[] arr)
        {
            arr.OrderByDescending(s => s).ToArray();
            return arr;
        }

        // 중복제거
        public string[] Distinct(string[] arr)
        {
            return arr.Distinct().ToArray();
        }
    }
}