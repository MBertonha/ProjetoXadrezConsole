using System;
using tabuleiro;

namespace xadrez
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tabu, Cor cor) : base(tabu, cor)
        {

        }

        public override string ToString()
        {
            return "D";
        }
    }
}
