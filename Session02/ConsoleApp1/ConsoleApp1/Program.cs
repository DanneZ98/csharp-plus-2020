using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var integerValues = new[] { 1, 2, 3 };
            var name = nameof(integerValues);
            Console.WriteLine("For-loop");
            for (var i = 0; i < integerValues.Length; i++)
            {
                var value = integerValues[i];

                Console.WriteLine($"Index {i} i arrayen {name} har värdet: {value}");
            }
            Console.WriteLine();
            Console.WriteLine("Do-while-loop");
            var doWhileIndex = 0;
            do
            {
                var value = integerValues[doWhileIndex];
                Console.WriteLine($"Index {doWhileIndex} i arrayen {name} har värdet: {value}");
                doWhileIndex++;
            }
            while (doWhileIndex < integerValues.Length);

            var whileIndex = 0;
            Console.WriteLine();
            Console.WriteLine("While-loop");
            while(whileIndex < integerValues.Length)
            {
                var value = integerValues[whileIndex];
                Console.WriteLine($"Index {whileIndex} i arrayen {name} har värdet: {value}");
                whileIndex++;
            }
        }
    }
}
