using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabu)
        {
            Console.WriteLine("  _________________ ");
            for (int i = 0; i < tabu.linhas; i++)
            {
                Console.Write(8 - i + "| ");
                for (int j = 0; j < tabu.colunas; j++)
                {
                    if(tabu.peca(i,j) == null) //Se não houver peça
                    {
                        
                        Console.Write("- ");
                    }
                    else                       //Se caso fouver uma peça no tabuleiro
                    {
                        imprimirPeca(tabu.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine(" |_________________|");
            Console.WriteLine("   A B C D E F G H  ");
        }

        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}
