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
            for (int i = 1; i < 65; i++)
            {
                int test = i % 2;
                int lineBreak = i % 8;
                int lineSwitch = 1;

                if (lineSwitch % 2 == 1)
                {
                    if (lineBreak == 1)
                    {
                        Console.Write("\n");
                        lineSwitch++;
                    }
                    if (test == 1)
                        Console.Write('▓');
                    else
                        Console.Write('░');
                }
                else if (lineSwitch % 2 == 0)
                {
                    if (lineBreak == 1)
                    {
                    Console.Write("\n");
                    lineSwitch++;
                    }
                    if (test == 0)
                        Console.Write('▓');
                    else
                        Console.Write('░');
                }
            }
        }
    }
}
