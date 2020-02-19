using System;
using tabuleiro;

namespace xadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tabu, Cor cor) : base(tabu, cor)
        {

        }

        public override string ToString()
        {
            return "B";
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

            //Nordeste
            pos.definirValores(pos.linha - 1, pos.coluna + 1);
            while (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
                if (tabu.peca(pos) != null && tabu.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
                pos.linha = pos.linha - 1;
            }

            //Noroeste
            pos.definirValores(pos.linha - 1, pos.coluna - 1);
            while (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
                if (tabu.peca(pos) != null && tabu.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
                pos.linha = pos.linha - 1;
            }

            //Sudoeste
            pos.definirValores(pos.linha + 1, pos.coluna - 1);
            while (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
                if (tabu.peca(pos) != null && tabu.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
                pos.linha = pos.linha + 1;
            }

            //Sudeste
            pos.definirValores(pos.linha + 1, pos.coluna + 1);
            while (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
                if (tabu.peca(pos) != null && tabu.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
                pos.linha = pos.linha + 1;
            }

            return matAux;
        }
    }
}
