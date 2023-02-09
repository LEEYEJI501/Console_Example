using System;
using Exam_Constant;

namespace Exam_State
{
    static class State
    {
        public SORT Sort = SORT.ASC;
        public CODE Code = CODE.NUMBER;
        public LINQ Linq = LINQ.ORDERBY;
        public DUPLICATION Duplication = DUPLICATION.DISTINCT;
    }

}
