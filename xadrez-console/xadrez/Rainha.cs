using System;
using tabuleiro;

namespace xadrez
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro tabu, Cor cor) : base(tabu, cor)
        {

        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
