﻿using static Exam;
using Exam_Stream;
using Exam_State;

class Exam
{
    
    static void Main(string[] args)
    {
        State state = new State();
        StreamBuilder streamBuilder = new StreamBuilder();
        streamBuilder.FileName = @"D:\test.txt";

        init(state);
    }

    void init(State state)
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

            Step(state, index);

            index++;

            if (index == 4) break;
        }
    }

    void Step(State state, int index)
    {
        switch (index)
        {
            case 1:
                state.Code = (CODE)Int32.Parse(Choice);
                break;
            case 2:
                state.Code = (CODE)Int32.Parse(Choice);
                break;
            case 3:
                state.Code = (CODE)Int32.Parse(Choice);
                break;
            case 4:
                state.Code = (CODE)Int32.Parse(Choice);
                break;
        }
    }

    bool Validate(String value)
    {
        try
        {
            int currentValue = (int)Int32.Parse(value);

            if (currentValue == 1 || currentValue == 2)
            {
                return true;
            }
            throw new Exception("1과 2만 입력할 수 있습니다.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            return false;
        }
    }
}