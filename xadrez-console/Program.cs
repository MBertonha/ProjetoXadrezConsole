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
            Tabuleiro tabu = new Tabuleiro(8, 8);

            tabu.colocarPeca(new Torre(tabu, Cor.Preta), new Posicao(0, 0));
            tabu.colocarPeca(new Torre(tabu, Cor.Preta), new Posicao(1, 3));
            tabu.colocarPeca(new Rei(tabu, Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tabu);
            Console.ReadLine();
        }
    }
}
