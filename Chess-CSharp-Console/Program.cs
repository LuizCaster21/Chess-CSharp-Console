using Chess_CSharp_Console;
using System;
using tabuleiro;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);
        }
    }
}