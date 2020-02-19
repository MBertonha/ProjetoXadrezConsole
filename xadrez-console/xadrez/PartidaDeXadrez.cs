using System;
using tabuleiro;
namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tabu { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
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

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }


        public void validarPosicaoOrigem(Posicao pos)
        {
            if(tabu.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição escolhida");
            }
            if (jogadorAtual != tabu.peca(pos).cor)
            {
                throw new TabuleiroException("A peça escolhida não é sua");
            }
            if (!tabu.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possiveis para esta peça");
            }
        }

        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
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
