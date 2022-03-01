using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03Assignment01
{
   class Program
   {
      static void Main(string[] args)
      {
         //Declarations
         int num = 1;
         String result = "odd";

         //Prompt and store integer in num
         Console.WriteLine("*** Odd or Even? ***");
         Console.Write("Enter an integer: ");
         num = int.Parse(Console.ReadLine());

         //Check if number is odd or even
         if (num % 2 == 0)
         {
            result = "even";
         }
         else
         {
            result = "odd";
         }

         //Output result
         Console.WriteLine();
         Console.WriteLine("*** Result ***");
         Console.WriteLine(num + " is considered " + result + ".");

         //End of program
         Console.WriteLine();
         Console.WriteLine("*** End of Program ***");
      }
   }
}
