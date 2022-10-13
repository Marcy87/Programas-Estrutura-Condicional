using System;
using System.Globalization;

namespace Program1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int conta = 0;
            double valor = 0, media;

            if (n1 > 0.0)
            {
                conta++;
                valor += n1;
            }
            if (n2 > 0.0)
            {
                conta++;
                valor += n2;
            }
            if (n3 > 0.0)
            {
                conta++;
                valor += n3;

            }
            if (n4 > 0.0)
            {
                conta++;
                valor += n4;

            }
            if (n5 > 0.0)
            {
                conta++;
                valor += n5;

            }
            if (n6 > 0.0)
            {
                conta++;
                valor += n6;

            }

            media = valor / conta;
            
            Console.WriteLine(conta + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}