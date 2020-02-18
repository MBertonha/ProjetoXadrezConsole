using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabu = new Tabuleiro(8, 8);

                tabu.colocarPeca(new Torre(tabu, Cor.Preta), new Posicao(0, 0));
                tabu.colocarPeca(new Torre(tabu, Cor.Preta), new Posicao(1, 3));
                tabu.colocarPeca(new Rei(tabu, Cor.Preta), new Posicao(2, 4));
                tabu.colocarPeca(new Rainha(tabu, Cor.Branca), new Posicao(4, 2));
                tabu.colocarPeca(new Peao(tabu, Cor.Branca), new Posicao(6, 3));

                Tela.imprimirTabuleiro(tabu);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

    }
}
