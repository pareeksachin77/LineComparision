using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparision
{
    internal class uc1
    {
        public static void lc1()
        {
            Console.WriteLine("welcome to line comparision");
            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n Length of line is" + Length(X1, Y1, X2, Y2));
            Console.ReadLine();

        }
        private static int Length(int X1, int Y1, int X2, int Y2)
        {
            return (int)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
    }
}
