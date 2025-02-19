using tabuleiro;

namespace chess
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }

        public override string? ToString()
        {
            return "T";
        }
    }
}
