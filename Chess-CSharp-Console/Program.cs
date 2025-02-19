using System;
using Tabuleiro;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(1, 2);
            Console.WriteLine("Posição: " + p);
        }
    }
}