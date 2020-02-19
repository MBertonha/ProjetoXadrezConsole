using System;
using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tabu, Cor cor) : base(tabu, cor)
        {

        }

        public override string ToString()
        {
            return "P";
        }

        public bool podeMover(Posicao pos)
        {
            Peca p = tabu.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] matAux = new bool[tabu.linhas, tabu.colunas];
            Posicao pos = new Posicao(0, 0);

            //Acima ++
            if (qteMovimentos == 0)
            {
                pos.definirValores(posicao.linha - 1, posicao.coluna);
                if (tabu.posicaoValida(pos) && podeMover(pos))
                {
                    matAux[pos.linha, pos.coluna] = true;
                    matAux[pos.linha - 1, pos.coluna] = true;
                }
            }
            else
            {
                //Acima
                pos.definirValores(posicao.linha - 1, posicao.coluna);
                if (tabu.posicaoValida(pos) && podeMover(pos))
                {
                    matAux[pos.linha, pos.coluna] = true;
                }
            }
            return matAux;
        }
    }
}
