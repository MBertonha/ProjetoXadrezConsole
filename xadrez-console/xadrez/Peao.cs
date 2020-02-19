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


            int cont = 1;
            //Acima ++
            if (qteMovimentos == 0)
            {
                cont++;
            }

            int mov = cont;

            if (cor == Cor.Branca)
            {
                mov = mov * -1;
            }

            for (int i = 0; i < cont; i++)
            {
                pos.definirValores(posicao.linha - mov, posicao.coluna);
                if (tabu.posicaoValida(pos) && podeMover(pos))
                {
                    matAux[pos.linha, pos.coluna] = true;
                }

                if (cor == Cor.Branca){
                    mov++;
                }
                else
                {
                    mov--;
                }   
            }
            cont = 0;
            return matAux;
        }
    }
}
