using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProgram
{
    internal class PerimeterofRectangle
    {
        public void area()
        {
            float l, w, perimeter;
            Console.Write("Enter the value of length: ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of width: ");
            w = Convert.ToInt32(Console.ReadLine());

            perimeter = 2 * (l + w);

            Console.WriteLine("Perimeter of rectangle: " + perimeter);

        }
    }
}
