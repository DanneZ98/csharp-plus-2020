using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var additionResult = 1 + 2;
            Console.WriteLine("Additionresult: " + additionResult);
            var incrementResult1 = additionResult++;
            var incrementResult2 = ++additionResult;
            Console.WriteLine("incrementresult: " + incrementResult1);
            Console.WriteLine("incrementresult: " + incrementResult2);

            var trueValue = true;
            var falseValue = false;

            // Inte boolsk jämförelse
            var andResult = 0b0010 & 0b0100; // 0b0110
            var orResult = trueValue | falseValue;
            var xorResult = trueValue ^ falseValue;

            Console.WriteLine("andResult: " + andResult);
            Console.WriteLine("orResult: " + orResult);
            Console.WriteLine("xorValue: " + xorResult);

            var moduleResult = 3 % 2;

            Console.WriteLine("ModuleResult: " + moduleResult);

            var highInteger = 1000;
            var divisionResult = highInteger / 3;
            // Implicit värdekonvertering till double
            var doubleDivisionResult = highInteger / 3.0;

            var forcedIntDivisionResult = (int)(highInteger / 3.0);

            Console.WriteLine("DivisionResult: " + divisionResult);
            Console.WriteLine("DoubleDivisionResult: " + doubleDivisionResult);
            Console.WriteLine("forcedIntDivisionResult: " + forcedIntDivisionResult);

            var conversionResult = Convert.ToInt32(doubleDivisionResult);
            Console.WriteLine("conversionResult: " + conversionResult);

            var midpointDivisionResult = 1.0 / 3.0;

            Console.WriteLine("midpointDivisionResult: " + midpointDivisionResult);
            Console.WriteLine("castToInt: " + ((int)midpointDivisionResult));
            Console.WriteLine("Ceiling: " + Math.Ceiling(midpointDivisionResult));
            Console.WriteLine("Floor: " + Math.Floor(midpointDivisionResult));
            Console.WriteLine("Round: " + Math.Round(midpointDivisionResult, 3));

            //Det går även att använda sammanslagna operatorer
            // -=
            // +=
            // *=
            // /=

            // Finns även <=, >=, ==, 
            var greaterResult = 5 > 3;
            var lessThanResult = 5 < 3;

            Console.WriteLine("greaterThanREsult: " + greaterResult);
            Console.WriteLine("lessThanResult: " + lessThanResult);


          
        }
    }
}
