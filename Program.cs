using System;
namespace LineComparsionUC
{
    class Program
    {
        public static void Linecomparison()
        {
            int x1, y1, x2, y2, length;
            Console.WriteLine("Enter x coordinate of first point:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of first point:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of second point:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of second point:");
            y2 = Convert.ToInt32(Console.ReadLine());

            length = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            int x = (x1 - y1) ^ 2;
            int y = (x2 - y2) ^ 2;

            Console.WriteLine("The length of the straight line joining the two points is:" + Math.Sqrt(length));
            Console.WriteLine("Equality of two points is:" + x.Equals(y));

            int value = x.CompareTo(y);

            if (value > 0)
                Console.WriteLine("{0} is greater than {1}", x, y);
            else if (value < 0)
                Console.WriteLine("{0} is less than {1}", x, y);
            else
                Console.WriteLine("{0} is equal to {1}", x, y);
        }
        public static void Main(string[] args)
        {
            Linecomparison();
        }
    }
}



