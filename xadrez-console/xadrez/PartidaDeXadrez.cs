using System;
using tabuleiro;
namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tabu { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tabu = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            //Retira peça da origem
            Peca p = tabu.retirarPeca(origem);
            p.incrementaMovimento();

            //Coloca no destino incrementando o movimento e retirando uma peça se houver
            Peca pecaCapturada = tabu.retirarPeca(destino);
            tabu.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tabu.colocarPeca(new Torre(tabu, Cor.Preta), new PosicaoXadrez('d', 2).toPosicao());
            tabu.colocarPeca(new Rei(tabu, Cor.Preta), new PosicaoXadrez('e', 4).toPosicao());
            tabu.colocarPeca(new Peao(tabu, Cor.Preta), new PosicaoXadrez('g', 7).toPosicao());
            tabu.colocarPeca(new Peao(tabu, Cor.Branca), new PosicaoXadrez('a', 6).toPosicao());
            tabu.colocarPeca(new Peao(tabu, Cor.Branca), new PosicaoXadrez('g', 4).toPosicao());
            tabu.colocarPeca(new Peao(tabu, Cor.Branca), new PosicaoXadrez('f', 1).toPosicao());

        }
    }
}
