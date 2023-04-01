

namespace testmaximumproblem
{
    class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Welcome to the Find Maximum values with Generics Problem");

            Console.WriteLine("Please enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int val = FindMaxInteger_UC1.MaximumIntegerNumber(num1, num2, num3);
            Console.WriteLine("{0} IS GREATER  NUMBER.", val);

        }

    }
}
