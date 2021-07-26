using System;

namespace _26_July_21
{
    class FibonacciSeries
    {
        public void main()
        {
            System.Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your Fibonacci series: ");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            System.Console.WriteLine();
        }
        public int Fibonacci(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else
                return (Fibonacci(num - 1) + Fibonacci(num - 2));
        }
    }
}