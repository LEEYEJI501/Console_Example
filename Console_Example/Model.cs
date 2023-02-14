using System;

namespace Console_Example
{
    public interface StreamBuilderInterface
    {
        // 파일 읽어오기
        public string[] Read();
        // 파일 유무 체크
        public bool Validate();
        // 오름차순 정렬
        public T[] Sort<T>(T[] arr);
        // 내림차순 정렬
        public T[] Reverse<T>(T[] arr);
        // 숫자 캐스팅
        public int[] ParseInt(string[] arr);
        // LINQ 정렬
        public T[] LinqOrderBy<T>(T[] arr);
        public T[] LinqOrderByDescending<T>(T[] arr);
        // 중복제거
        public T[] Distinct<T>(T[] arr);
    }
}

