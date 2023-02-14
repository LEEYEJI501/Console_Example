namespace Console_Example
{
    class Exam
    {
        static void Main(string[] args)
        {
            StreamBuilder streamBuilder = new StreamBuilder();
            streamBuilder.readFileName = @"D:\test.txt";
            CSVBuilder csvBuilder = new CSVBuilder();

            // 파일 이름 선언
            string saveFileName = "";

            Init();

            string[] arr = streamBuilder.Read();

            // 숫자 정렬
            if (State.Code == CODE.NUMBER)
            {
                int[] result = streamBuilder.ParseInt(arr);

                result = execute(result, streamBuilder);

                if (result.GetType() == typeof(int[]))
                {
                    arr = Array.ConvertAll(result, s => s.ToString());

                    string fileNameFinal = csvBuilder.FileNameSetting(saveFileName);
                    Console.WriteLine(fileNameFinal.ToString());
                    csvBuilder.SaveFile(fileNameFinal, arr);
                }
            }
            else
            {
                arr = execute(arr, streamBuilder);

                //string fileNameFinal = csvBuilder.FileNameSetting(saveFileName);
                //csvBuilder.SaveFile(saveFileName, arr);
            }
        }

        private static void Init()
        {
            int index = 0;

            while (true)
            {
            START:
                Console.WriteLine("정렬 방식을 선택하세요.");

                Console.WriteLine(State.ments[index]);

                string? Choice = Console.ReadLine();

                bool isCheck = Validate(Choice);

                if (!isCheck)
                {
                    goto START;
                }

                Step(index, Choice);

                index++;

                if (index == 4) break;
            }
        }

        // 입력받은 값 추가
        private static void Step(int index, string Choice)
        {
            switch (index)
            {
                case 0:
                    State.Sort = (SORT)Convert.ToInt32(Choice);
                    break;
                case 1:
                    State.Code = (CODE)Convert.ToInt32(Choice);
                    break;
                case 2:
                    State.Method = (METHOD)Convert.ToInt32(Choice);
                    break;
                case 3:
                    State.Duplication = (DUPLICATION)Convert.ToInt32(Choice);
                    break;
            }
        }

        // 입력값 검수
        private static bool Validate(string? value)
        {
            try
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("값을 입력해주세요.");
                }

                int.TryParse(value, out int currentValue);

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

        private static T[] execute<T>(T[] arr, StreamBuilder streamBuilder)
        {
            // 중복제거
            if (State.Duplication == DUPLICATION.DISTINCT)
            {
                arr = streamBuilder.Distinct(arr);
            }

            // 오름차순 내림차순
            if (State.Sort == SORT.ASC)
            {
                arr = streamBuilder.Sort(arr);
            }
            else
            {
                arr = streamBuilder.Sort(arr);
                arr = streamBuilder.Reverse(arr);
            }

            //LINQ 방식
            if (State.Method == METHOD.LINQ && State.Sort == SORT.ASC)
            {
                arr = streamBuilder.LinqOrderBy(arr);
            }
            else if (State.Method == METHOD.LINQ && State.Sort == SORT.DECS)
            {
                arr = streamBuilder.LinqOrderByDescending(arr);
                Console.WriteLine(arr.GetType());
            }

            return arr;
        }
    }

}