namespace ReviewProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("press1 to perimeter of rectangle:");
            Console.WriteLine("press2 to area of circle:");
            Console.WriteLine("press 3 to area of triangle");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PerimeterofRectangle perimeter = new PerimeterofRectangle();
                    perimeter.area();
                    break;

                case 2:
                    AreaofCircle areaofcircle = new AreaofCircle();
                    areaofcircle.areaOfcircle();
                    break;

                case 3:
                    AreaofTriangle areaoftrianagle = new AreaofTriangle();
                    areaoftrianagle.areaoftrianagle();
                    break;
            }
        }
    }
}

