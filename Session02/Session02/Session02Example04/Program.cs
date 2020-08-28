using System;

namespace Session02Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ålder: ");
            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);

            if (integer >= 18)
            {
                Console.WriteLine("Du får köpa tobaksprodukter");
            }
            else
            {
                Console.WriteLine("Du får inte köpa tobaksprodukter");
            }

            if (integer >= 40)
            {
                Console.WriteLine("Du är jättegammal");
            }

            Console.WriteLine("Ange vattentemperatur i grader C: ");
            var input1 = Console.ReadLine();
            var integer1 = Convert.ToInt32(input1);

            string waterLabel = integer1 >= 27 ? "Går att bada" : "Går inte att bada";
            //if (integer1 >= 27)
            //{
            //Console.WriteLine("Går att bada");
            //}
            //else
            //{
            //    Console.WriteLine("Det går inte att bada");
            //}

            switch (integer1)
            {
                case 1: waterLabel = "Går inte att bada alls"; break;
                case -3: waterLabel = "Det är 3 minusgrader"; break;
            }
            Console.WriteLine(waterLabel + " i havet");


        }
    }
}
