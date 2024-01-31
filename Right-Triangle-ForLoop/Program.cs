using System;

namespace RightTriangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Right Triangle Pattern\n\n");

            int row = 5;

            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}