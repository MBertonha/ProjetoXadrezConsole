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

        public bool podeMover(Posicao pos)
        {
            Peca p = tabu.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] matAux = new bool[tabu.linhas, tabu.colunas];

            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
                if (tabu.peca(pos) != null && tabu.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            //Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
                if (tabu.peca(pos) != null && tabu.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //Direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
                if (tabu.peca(pos) != null && tabu.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            //Esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
                if (tabu.peca(pos) != null && tabu.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }

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
