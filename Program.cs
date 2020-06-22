using System;

namespace StaticPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Conversor.CotacaoDolar = 5.25f;
            Console.WriteLine(Conversor.ConverterDolarReal(200));
            System.Console.WriteLine(Conversor.ConverterRealDolar(1500));
            
            Console.ResetColor();
        }
    }
}
