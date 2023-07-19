using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Type_Division
{
    public class Program          // 문자 하나를 입력받아 해당 문자가 영어 대문자, 영어 소문자, 숫자, 특수문자 인지 구분하기
    {
        static void Main(string[] args)
        {
            char code = default;          // char 로 입력받기
            bool codeCheck = false;       // 해당 입력을 참, 거짓 구분

            Console.WriteLine("아무 문자를 하나만 입력해 주세요 => ");
            char.TryParse(Console.ReadLine(), out code);

            codeCheck = ('A' <= code && code <= 'Z');         // 영어 대문자인지 체크
            if (codeCheck == true)
            {
                Console.WriteLine("해당 문자는 '영어 대문자' 입니다.");       // 영어 대문자면 출력
            }
            else
            {
                codeCheck = ('a' <= code && code <= 'z');        // 영어 소문자인지 체크
                if (codeCheck == true)
                {
                    Console.WriteLine("해당 문자는 '영어 소문자' 입니다.");      // 영어 소문자면 출력
                }
                else
                {
                    codeCheck = ('0' <= code && code <= '9');        // 숫자인지 체크
                    if (codeCheck == true)
                    {
                        Console.WriteLine("해당 문자는 '숫자' 입니다.");        // 숫자면 출력
                    }
                    else
                    {
                        Console.WriteLine("해당 문자는 '특수 문자' 입니다.");        // 그 외 특수문자로 판단
                    }
                }
            }
        }
    }
}
