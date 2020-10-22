using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStep224
{
    public class Class1OutputInt
    {

        public Class1OutputInt(int passNum = 0)
        {
            PassNum = passNum;
            string paramOption = (passNum == 0)
                ? "Class Instantiated; Instance of Object Created; No Parameters."
                : "Class Instantiated; Instance of Object Created w/ One Parameter; One Argument Passed to Object.";
            Console.WriteLine(paramOption);
            Console.ReadLine();
        }

      

        public void DivideByTwo(int passNum = 0)
        {
            string argIsNotZero = (passNum != 0)
                ? "\n " + passNum + " divided by 2 = " + (passNum / 2)
                : "\n This Program Does Not Calculate Division Operations When the Number To be Divided Has The Value of Zero. Thank You. Goodbye.";
            Console.WriteLine(argIsNotZero);
            Console.ReadLine();
        }
        
        public void EnterNextValue(out int nextValue)
        {
            Console.WriteLine("Enter another value to see this program in action one more time: ");
            nextValue = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Instantiated the Class1OutputInt Problem 2 Object to Demonstrate Output Parameters.");
        }
        public int PassNum { get; set; }
    }

}









