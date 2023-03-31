

namespace testmaximumproblem
{
    class Program
    {
        public static void Main(string[]args)
        {
             int a = 10, b = 20, c = 15;
            double x = 15.5, y = 77.9, z = 10.0;
            string p = "Queen", q = "King", r = "Jokar";

            FindMax<int> obj = new FindMax<int>(a, b, c);
            int MaxInt = obj.TestMaximum();
            Console.WriteLine("Maximum value in integer is: " + MaxInt);
            Console.WriteLine("****************************************");

            FindMax<double> obj1 = new FindMax<double>(x, y, z);
            double MaxDouble = obj1.TestMaximum();
            Console.WriteLine("Maximum value in double is: " + MaxDouble);
            Console.WriteLine("****************************************");

            FindMax<string> obj2 = new FindMax<string>(p, q, r);
            string MaxString = obj2.TestMaximum();
            Console.WriteLine("Maximum value in string is: " + MaxString);
            Console.WriteLine("****************************************");
        }

    }
}
