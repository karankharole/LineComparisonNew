using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonNew
{
    internal class LineComparison
    {
       public void lenthOfLine()
        {
            Console.Write(" Enter the value of x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the value of  x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the value of  y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the value of y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length_Of_A_Line = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine(" The length of a line is (x2 - x1) ^ 2 + (y2 - y1) ^ 2  = " + length_Of_A_Line);

        }
    }
}
