using System;

namespace Program1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(valores[0]);
            int minutosInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutosFinal = int.Parse(valores[3]);

            int instanteInicial = horaInicial * 60 + minutosInicial;
            int instanteFinal = horaFinal * 60 + minutosFinal;

            int duracao;

            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}