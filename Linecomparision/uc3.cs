using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparision
{
    internal class uc3
    {
        public static void Length()
        {
            Console.WriteLine("Welcome to line comparision:");
            Console.WriteLine("Enter the Value of x1,x2,y1,y2");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
           int length1 = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

       
            Console.WriteLine("Enter the Value of x3,x4,y3,y4");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());
            int length2 = (int)Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));

            if (length1.Equals(length2))
            {
                Console.WriteLine("Lines are equal");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Line 1 is greater");
            }
            else
            {
                Console.WriteLine("Line 2 is greater");
            }

        }

        
    }
}
