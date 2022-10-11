using System;

namespace Program1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int duracao;

            string[] valores = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            } else
            {
                duracao = 24 - horaInicial + horaFinal;                
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}