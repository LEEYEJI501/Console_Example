using Exam_State;
using Exam_Stream;

namespace Exam
{
    class Exam
    {
        static void Main(string[] args)
        {
            State state = new State();
            StreamBuilder streamBuilder = new StreamBuilder();
            streamBuilder.FileName = @"D:\test.txt";

            Init(state);

            Console.WriteLine(state.Sort.ToString());
            Console.WriteLine(state.Code.ToString());
            Console.WriteLine(state.Linq.ToString());
            Console.WriteLine(state.Duplication.ToString());
        }

        static void Init(State state)
        {
            int index = 0;
            string[] ments = new string[] {
                "1.오름차순, 2.내림차순",
                "1.숫자정렬, 2.문자정렬",
                "1.배열정렬, 2.LINQ정렬",
                "1.중복제거, 2.중복제거안함"
            };

            while (true)
            {
            START:
                Console.WriteLine("정렬 방식을 선택하세요.");

                Console.WriteLine(ments[index]);
                string Choice = Console.ReadLine();
                bool isCheck = Validate(Choice);

                if (!isCheck)
                {
                    goto START;
                }

                Step(state, index, Choice);

                index++;

                if (index == 4) break;
            }
        }

        // 값 추가
        static void Step(State state, int index, string Choice)
        {
            switch (index)
            {
                case 1:
                    state.Sort = (SORT)Convert.ToInt32(Choice);
                    break;
                case 2:
                    state.Code = (CODE)Convert.ToInt32(Choice);
                    break;
                case 3:
                    state.Linq = (LINQ)Convert.ToInt32(Choice);
                    break;
                case 4:
                    state.Duplication = (DUPLICATION)Convert.ToInt32(Choice);
                    break;
            }

        }

        // 입력값 검수
        static bool Validate(String value)
        {
            try
            {
                int currentValue = Convert.ToInt32(value);

                if (currentValue == 1 || currentValue == 2)
                {
                    return true;
                }
                throw new Exception("1 또는 2만 입력할 수 있습니다.");
            }
            catch (Exception e)
            {
                Console.WriteLine("정수 1 또는 2만 입력할 수 있습니다.");
                return false;
            }
        }
    }
}