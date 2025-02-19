using tabuleiro;

namespace chess
{
    class Peao : Peca
    {
        public Peao(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }

        public override string? ToString()
        {
            return "P";
        }
    }
}
