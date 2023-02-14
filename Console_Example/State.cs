using System;

namespace Console_Example
{
    static class State
    {
        public static SORT Sort = SORT.ASC;
        public static CODE Code = CODE.NUMBER;
        public static METHOD Method = METHOD.LINQ;
        public static DUPLICATION Duplication = DUPLICATION.DISTINCT;

        public static string[] ments = new string[] {
           "1.오름차순, 2.내림차순",
           "1.숫자정렬, 2.문자정렬",
           "1.ArraySort, 2.LinqOrderBy",
           "1.중복제거, 2.중복제거안함"
        };
    }

}
