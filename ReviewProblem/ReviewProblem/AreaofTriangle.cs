using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProgram
{
    internal class AreaofTriangle
    {
        public void areaoftrianagle()
        {
            Console.WriteLine("Enter the base of triangle:");
            double triangleBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of triangle:");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());
            double areaOfTriangle = (triangleBase * triangleHeight) / 2;
            Console.WriteLine("Area of triangle is: " + areaOfTriangle);
        }
    }
}
