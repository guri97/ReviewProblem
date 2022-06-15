using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProgram
{
    internal class AreaofCircle
    {
        public void areaOfcircle()

        {
            double radius, area;
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("\nArea of circle: " + area);
        }
    }
}

