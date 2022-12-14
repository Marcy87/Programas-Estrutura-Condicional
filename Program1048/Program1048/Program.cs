using System;
using System.Globalization;

namespace Program1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double aumento, novoSalario, percentual;

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                percentual = 15.0;
            }
            else if (salario <= 800.00)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200.00)
            {
                percentual = 10.0;
            }
            else if (salario <= 2000.00)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            aumento = salario * percentual / 100.00;
            novoSalario = salario + aumento;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + aumento.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}