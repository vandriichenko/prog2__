using System;

namespace Lab_1_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int A, B;
            Console.Write("Enter value: ");
            A = Convert.ToInt32(Console.ReadLine());

            B = A + 1; // +1
            Console.Out.Write("Result: ");
            Console.Out.Write(Convert.ToString(A, 10));
            Console.Out.Write("=>");
            Console.Out.Write(Convert.ToString(A, 2));
            Console.Out.Write("=>");
            Console.Out.Write(Convert.ToString(B, 2));
            Console.Out.Write("=>");
            Console.Out.WriteLine(Convert.ToString(B, 10));

        }
    }
}