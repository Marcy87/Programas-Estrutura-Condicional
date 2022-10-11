using System;
using System.Globalization;

namespace Program1040
{
    class Progrtam
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, notaFinal, media, mediaFinal;

            string[] vet = Console.ReadLine().Split(' ');

            N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaFinal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + notaFinal) / 2;
                Console.WriteLine("Nota do exame: " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}