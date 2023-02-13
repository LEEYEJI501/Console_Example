using System;

namespace Console_Example
{
    class State
    {
        public SORT Sort = SORT.ASC;
        public CODE Code = CODE.NUMBER;
        public LINQ Linq = LINQ.ORDERBY;
        public DUPLICATION Duplication = DUPLICATION.DISTINCT;

        public string[] ments = new string[] {
           "1.오름차순, 2.내림차순",
           "1.숫자정렬, 2.문자정렬",
           "1.ArraySort, 2.LinqOrderBy",
           "1.중복제거, 2.중복제거안함"
        };
    }

}
