using System;

namespace Program1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod = int.Parse(Console.ReadLine());

            if (cod == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if (cod == 71)
            {
                System.Console.WriteLine("Salvador");
            }
            else if (cod == 11)
            {
                System.Console.WriteLine("Sao Paulo");
            }
            else if (cod == 21)
            {
                System.Console.WriteLine("Rio de Janeiro");
            }
            else if (cod == 32)
            {
                System.Console.WriteLine("Juiz de Fora");
            }
            else if (cod == 19)
            {
                System.Console.WriteLine("Campinas");
            }
            else if (cod == 27)
            {
                System.Console.WriteLine("Vitoria");
            }
            else if (cod == 31)
            {
                System.Console.WriteLine("Belo Horizonte");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}