using tabuleiro;

namespace chess
{
    class Cavalo : Peca
    {
        public Cavalo(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }

        public override string? ToString()
        {
            return "C";
        }
    }
}
