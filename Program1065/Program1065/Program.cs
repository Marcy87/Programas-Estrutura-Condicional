using System;

namespace Program1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());

            int conta = 0;

            if (n1 % 2 == 0)
            {
                conta++;
            }
            if (n2 % 2 == 0)
            {
                conta++;
            }
            if (n3 % 2 == 0)
            {
                conta++;
            }
            if (n4 % 2 == 0)
            {
                conta++;
            }
            if (n5 % 2 == 0)
            {
                conta++;
            }

            Console.WriteLine(conta + " valores pares");
        }
    }
}