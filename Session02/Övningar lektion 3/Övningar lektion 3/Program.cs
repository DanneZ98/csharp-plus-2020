using System;

namespace Övningar_lektion_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Övning 1
            /*Console.WriteLine("Input value 1:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input value 2:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = input1 + 1; i < input2; i++)
            {
                Console.WriteLine(i);
            }
            */
            // Övning 2
            //int schack = 12;
            for (int i = 0; i < 12; i += 2)
            {
                int test = i %= 2;
                if(test == 1)
                Console.WriteLine('░');
                else
                Console.WriteLine('▓');
            }
        }
    }
}
