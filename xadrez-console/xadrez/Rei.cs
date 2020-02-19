using System;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabu, Cor cor) : base(tabu,cor)
        {

        }

        public override string ToString()
        {
            return "R";
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
            pos.definirValores(pos.linha - 1, pos.coluna);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Nordeste
            pos.definirValores(pos.linha - 1, pos.coluna + 1);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Direita
            pos.definirValores(pos.linha, pos.coluna + 1);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Sudeste
            pos.definirValores(pos.linha + 1, pos.coluna + 1);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Abaixo
            pos.definirValores(pos.linha + 1, pos.coluna);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Sudoeste
            pos.definirValores(pos.linha + 1, pos.coluna - 1);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Esquerda
            pos.definirValores(pos.linha, pos.coluna - 1);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            //Noroeste
            pos.definirValores(pos.linha - 1, pos.coluna - 1);
            if (tabu.posicaoValida(pos) && podeMover(pos))
            {
                matAux[pos.linha, pos.coluna] = true;
            }

            return matAux;
        }
    }
}
