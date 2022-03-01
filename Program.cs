using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03Assignment02
{
   class Program
   {
      static void Main(string[] args)
      {
         //Declarations
         int num1;
         int num2;
         String result;

         //Obtain values
         Console.WriteLine("*** Multiples Checker ***");
         Console.Write("Enter first integer: ");
         num1 = int.Parse(Console.ReadLine());
         Console.Write("Enter second integer: ");
         num2 = int.Parse(Console.ReadLine());

         //Check multiples
         if (num1 % num2 == 0)
         {
            result = num1 + " is a multiple of " + num2 + ".";
         }
         else
         {
            result = num1 + " is not a multiple of " + num2 + ".";
         }

         //Output result
         Console.WriteLine();
         Console.WriteLine("*** Result ***");
         Console.WriteLine(result);

         //End of program
         Console.WriteLine();
         Console.WriteLine("*** End of Program ***");
      }
   }
}
