using System;

namespace ProjectTest
{
    class Test2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your count");
            int count = Convert.ToInt32(Console.ReadLine());

            int var = 1, temp, i, j;
            for (i = 0; i < count; i++)
            {
                for (temp = 1; temp <= count - i; temp++)
                    Console.Write(" ");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0)
                        var = 1;
                    else
                        var = (i - j + 1);
                    Console.Write(var + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}