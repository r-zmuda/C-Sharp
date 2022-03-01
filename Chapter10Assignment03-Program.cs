using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Rectangle Class
Create class Rectangle. The class has attributes length and
width, each of which defaults to 1. It has read-only properties
that calculate the Perimeter and Area of the rectangle. It has
properties for both length and width. The set accessors should
verify the length and width are each floating-point numbers
greater than 0.0 and less than 20.0. Write an app to test
class Rectangle.
*/
namespace Chapter10Assignment03
{
	class Program
	{
		static void Main(string[] args)
		{
			//Header
			Console.WriteLine(" *** Rectangle Class ***");
			Console.WriteLine();

			//Make Rectangles
			Rectangle rec = new Rectangle();
			Rectangle rec2 = new Rectangle();
			rec2.Length = 20;
			rec2.Width = 20;
			Rectangle rec3 = new Rectangle();
			rec3.Length = 8;
			rec3.Width = 14;

			//Output Rectangles
			Console.WriteLine($"Default Rectangle:");
			Console.WriteLine($"rec.Length: {rec.Length}");
			Console.WriteLine($"rec.Width: {rec.Width}");
			Console.WriteLine($"rec.Area: {rec.Area}");
			Console.WriteLine($"rec.Perimeter: {rec.Perimeter}");
			Console.WriteLine();
			Console.WriteLine($"rec2.Length: {rec2.Length}");
			Console.WriteLine($"rec2.Width: {rec2.Width}");
			Console.WriteLine($"rec2.Area: {rec2.Area}");
			Console.WriteLine($"rec2.Perimeter: {rec2.Perimeter}");
			Console.WriteLine();
			Console.WriteLine($"rec3.Length: {rec3.Length}");
			Console.WriteLine($"rec3.Width: {rec3.Width}");
			Console.WriteLine($"rec3.Area: {rec3.Area}");
			Console.WriteLine($"rec3.Perimeter: {rec3.Perimeter}");
			Console.WriteLine();
		}
	}
}
