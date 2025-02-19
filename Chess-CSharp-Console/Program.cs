using Chess_CSharp_Console;
using System;
using tabuleiro;
using chess;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
        }
    }
}