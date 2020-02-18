using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabu)
        {

            for(int i = 0; i < tabu.linhas; i++)
            {
                for(int j = 0; j < tabu.colunas; j++)
                {
                    if(tabu.peca(i,j) == null) //Se não houver peça
                    {
                        Console.Write("- ");
                    }
                    else                       //Se caso fouver uma peça no tabuleiro
                    {
                        Console.Write(tabu.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}
