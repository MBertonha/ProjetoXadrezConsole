using System;
using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tabu, Cor cor) : base(tabu, cor)
        {

        }

        public override string ToString()
        {
            return "C";
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

            //Cima-Dir 1
            pos.definirValores(posicao.linha + 2, posicao.coluna + 1);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Cima-Esq 1
            pos.definirValores(posicao.linha + 2, posicao.coluna - 1);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Baixo-Dir 1 
            pos.definirValores(posicao.linha - 2, posicao.coluna + 1);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Baixo-Esq 1
            pos.definirValores(posicao.linha - 2, posicao.coluna - 1);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Cima-Dir 2
            pos.definirValores(posicao.linha + 1, posicao.coluna + 2);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Cima-Esq 2
            pos.definirValores(posicao.linha + 1, posicao.coluna - 2);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Baixo-Dir 2
            pos.definirValores(posicao.linha - 1, posicao.coluna + 2);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Baixo-Esq 2
            pos.definirValores(posicao.linha - 1, posicao.coluna - 2);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            return matAux;
        }
    }
}
