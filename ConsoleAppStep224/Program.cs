﻿using System;
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
            Console.ReadLine();
            Console.WriteLine("Enter a number: ");
            int passNum = Convert.ToInt32(Console.ReadLine());
            problem1.DivideByTwo(passNum);
            Console.ReadLine();
        }
    }
}