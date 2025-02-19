﻿using System;
using tabuleiro;
using chess;

namespace Chess_CSharp_Console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i<tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for(int j = 0; j<tab.colunas; j++)
                {
                    ImprimirPeca(tab.peca(i, j));                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.WriteLine();
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoePossiveis)
        {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for(int i = 0;i < tab.linhas;i++)
            {
                Console.Write(8 - i + " ");
                for(int j = 0;j < tab.colunas;j++)
                {
                    if(posicoePossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor= fundoOriginal;
                    }
                    ImprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.WriteLine();
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca)
        {
            if(peca == null)
            { Console.Write("- "); } 
            else
            {
                if(peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
            
                }
                Console.Write(" ");
            }
            
        }
    }
}
