using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03Assignment03
{
   class Program
   {
      static void Main(string[] args)
      {
         //Declarations
         int radius, diameter;
         double area, circumference;

         //Get circle radius
         Console.WriteLine("*** Circle Measurements ***");
         Console.Write("Enter circle radius: ");
         radius = int.Parse(Console.ReadLine());

         //Calculations (ft. Math.PI)
         diameter = radius * 2;
         circumference = 2 * Math.PI * radius;
         area = Math.PI * (radius * radius);

         //Output result
         Console.WriteLine();
         Console.WriteLine("*** Result ***");
         Console.WriteLine("Radius: " + radius);
         Console.WriteLine("Diameter: " + diameter);
         Console.WriteLine("Circumference: " + circumference);
         Console.WriteLine("Area: " + area);

         //End of program
         Console.WriteLine();
         Console.WriteLine("*** End of Program ***");
      }
   }
}
