using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStep224
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1OutputInt problem1 = new Class1OutputInt();
            Console.WriteLine("Enter a number: ");
            int passNum = Convert.ToInt32(Console.ReadLine());
           

            problem1.DivideByTwo(passNum);
            Console.ReadLine();

            Class1OutputInt problem2 = new Class1OutputInt();
            problem2.EnterNextValue(out passNum);
            problem2.DivideByTwo(passNum);
            Console.ReadLine();

            string result = Class3.myMethod();
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}