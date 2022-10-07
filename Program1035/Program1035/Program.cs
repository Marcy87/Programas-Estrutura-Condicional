using System;

namespace Program1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, somaCD, somaAB, par;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            somaCD = C + D;
            somaAB = A + B;
            par = A % 2;

            if (B > C && D > A && somaCD > somaAB && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}