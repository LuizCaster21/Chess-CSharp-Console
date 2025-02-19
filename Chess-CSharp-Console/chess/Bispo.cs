﻿using tabuleiro;

namespace chess
{
    class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }

        public override string? ToString()
        {
            return "B";
        }
    }
}
