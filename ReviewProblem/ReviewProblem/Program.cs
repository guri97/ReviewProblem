namespace ReviewProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("press1 to perimeter of rectangle:");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PerimeterofRectangle perimeter = new PerimeterofRectangle();
                    perimeter.area();
                    break;
            }
        }
    }
}

