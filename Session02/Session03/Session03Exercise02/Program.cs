using System;

namespace Session03Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();

            //Alternativt var inputArray = input.Split(new [] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

            int total = 0;

            foreach (var number in inputArray)
            {
                Console.WriteLine("Värdet är " + number);
                total += Convert.ToInt32(number);
            }
        }
    }
}
