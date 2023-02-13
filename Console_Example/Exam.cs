using System.Runtime.InteropServices;

namespace Console_Example
{
    class Exam
    {
        static void Main(string[] args)
        {
            State state = new State();
            StreamBuilder streamBuilder = new StreamBuilder();
            streamBuilder.FileName = @"D:\test.txt";
            SaveCSVFile saveCSVFile = new SaveCSVFile();

            // 파일 이름 선언
            string saveFileName = "Test.csv";

            Init(state);

            string[] arr = streamBuilder.Read();

            // 숫자 정렬
            if (state.Code == CODE.NUMBER)
            {
                int[] result = streamBuilder.ParseInt(arr);
            }

            // LINQ 정렬 선택 시
            if (state.Linq == LINQ.DESENDING)
            {
                //LINQ 오름차순 내림차순
                if (state.Linq == LINQ.ORDERBY)
                {
                    arr = streamBuilder.LinqOrderBy(arr);
                }
                else
                {
                    arr = streamBuilder.LinqOrderByDescending(arr);
                }
            }
            // 배열 정렬 선택시 
            else if (state.Linq == LINQ.ORDERBY)
            {
                // 오름차순 내림차순
                if (state.Sort == SORT.ASC)
                {
                    arr = streamBuilder.Sort(arr);
                }
                else
                {
                    arr = streamBuilder.Reverse(arr);
                }
            }

            // 중복제거
            if (state.Duplication == DUPLICATION.DISTINCT)
            {
                arr = streamBuilder.Distinct(arr);
            }

            saveCSVFile.SaveFile(saveFileName, arr);
        }

        public static void Init(State state)
        {
            int index = 0;

            while (true)
            {
            START:
                Console.WriteLine("정렬 방식을 선택하세요.");

                Console.WriteLine(state.ments[index]);
                string? Choice = Console.ReadLine();
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

        // 입력받은 값 추가
        public static void Step(State state, int index, string Choice)
        {
            switch (index)
            {
                case 0:
                    state.Sort = (SORT)Convert.ToInt32(Choice);
                    break;
                case 1:
                    state.Code = (CODE)Convert.ToInt32(Choice);
                    break;
                case 2:
                    state.Linq = (LINQ)Convert.ToInt32(Choice);
                    break;
                case 3:
                    state.Duplication = (DUPLICATION)Convert.ToInt32(Choice);
                    break;
            }

        }

        // 입력값 검수
        public static bool Validate(string? value)
        {
            try
            {
                //if (value.GetType() != typeof(int))
                //{
                //    throw new Exception("1 또는 2만 입력할 수 있습니다");
                //}

                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("값을 입력해주세요.");
                }

                int currentValue = Convert.ToInt32(value);

                if (currentValue == 1 || currentValue == 2)
                {
                    return true;
                }
                else
                {
                    throw new Exception("1 또는 2만 입력할 수 있습니다.");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }

}