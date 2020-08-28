using System;
using System.Globalization;

namespace Session03Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            Console.WriteLine();
            // Alternativt var inputArray = input.Split(new [] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            IFormatProvider formatProvider = 
            #region min grej
            /*
            int total = 0;
            int loops = 0;
            int maxValue = 0;
            int minValue = Convert.ToInt32(inputArray[0]);
            int testValue;

            foreach (var number in inputArray)
            {
                Console.WriteLine("Värdet är " + number);
                
                testValue = Convert.ToInt32(number);
                if (maxValue < testValue)
                {
                    maxValue = testValue;
                }

                if (minValue > testValue)
                {
                    minValue = testValue;
                }

                total += Convert.ToInt32(number);
                loops++;
            }
            Console.WriteLine();
            Console.WriteLine("Medelvärdet är: " + total/loops);
            Console.WriteLine();
            Console.WriteLine("Max värdet är: " + maxValue);
            Console.WriteLine();
            Console.WriteLine("Min värdet är: " + minValue);
            */
            #endregion
            double? [] array = new double?[inputArray.Length];
            #region min andra grej
            /*
            for (int i = 0; i <inputArray.Length; i++)
            {
                try
                {
                    array[i] = Convert.ToDouble(inputArray[i]);
                }
                catch (Exception)
                {
                    array[i] = 0;
                    Console.WriteLine("Värdet ändrades");
                }
            }
            */
            #endregion
            for (int i = 0; i < inputArray.Length; i++)
            {
                #region Bortkommenterat
                
                NumberStyles numberStyle = NumberStyles.Integer | NumberStyles.Float;
                bool parsed = double.TryParse(inputArray[i], numberStyle, formatProvider, out double parsedValue);

                if (parsed == true)
                {
                    array[i] = parsedValue;
                }
                else
                {
                    Console.WriteLine("!");
                    array[i] = null;
                }
                
                #endregion
                #region try catch
                /*try
                {
                    array[i] = Convert.ToDouble(inputArray[i]);
                }
                catch
                {
                    array[i] = null;
                }
                */
                #endregion
            }

            double? total = 0;
            double? loops = 0;
            double? maxValue = 0;
            double? minValue = array[0];
            double? testValue;

           
            foreach (var number in array)
            {
                Console.WriteLine("Värdet är " + number);

                testValue = number;
                if (maxValue < testValue)
                {
                    maxValue = testValue;
                }

                if (minValue > testValue)
                {
                    minValue = testValue;
                }

                total += number;
                loops++;
            }
            Console.WriteLine();
            Console.WriteLine("Medelvärdet är: " + total / loops);
            Console.WriteLine();
            Console.WriteLine("Max värdet är: " + maxValue);
            Console.WriteLine();
            Console.WriteLine("Min värdet är: " + minValue);
        }
    }
}
