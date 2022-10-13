using System;
using System.Globalization;

namespace Program1051
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;

            if (salario <= 2000.00)
            {
                imposto = 0.00;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}