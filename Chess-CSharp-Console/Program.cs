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
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}