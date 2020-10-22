using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStep224
{
    class static void Class3
    {
       public Class3()
    {
            Console.WriteLine("if you are finished type \"yes\":");
            string theEnd = Console.ReadLine();
            string answer = (theEnd == "yes")
                ? "\n\n Thank you for running this program. The End. Bye."
                : "I know you don't want to stop... because this is so much fun!! \n But All Good Things Must Come To An End....Farewell, My Friend....Farewell.";


            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }

}