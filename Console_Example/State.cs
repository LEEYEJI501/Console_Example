using System;

namespace Exam_State
{
    public enum SORT
    {
        ASC = 1,
        DECS = 2
    }

    public enum CODE
    {
        NUMBER = 1,
        STRING = 2
    }

    public enum LINQ
    {
        ORDERBY = 1,
        DESENDING = 2
    }

    public enum DUPLICATION
    {
        DISTINCT = 1,
        NOT = 2
    }
    
    public class State
    {
        public SORT Sort = SORT.ASC;
        public CODE Code = CODE.NUMBER;
        public LINQ Linq = LINQ.ORDERBY;
        public DUPLICATION Duplication = DUPLICATION.DISTINCT;
    }

}
