using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "가", "나" };
            Console.Write("숫자를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            if(input>=0 && input < array.Length)
            {
                Console.WriteLine("입력한 위치의 값은 '" + array[input] + "' 입니다.");
            }
            else
            {
                Console.WriteLine("올바른 인덱스를 입력해주세요");
            }
        }
    }
}
