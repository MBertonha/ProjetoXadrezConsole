namespace tabuleiro
{
    abstract class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tabu { get; protected set; }

        public Peca(Tabuleiro tabu, Cor cor)
        {
            this.posicao = null;
            this.tabu = tabu;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

        public void incrementaMovimento()
        {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tabu.linhas; i++)
            {
                for (int j = 0; j < tabu.colunas; j++)
                {
                    if(mat[i,j] == true)
                    {
                        return true; //Existe pelomeno 1 mov possivel
                    }
                }
            }
            return false;  //Nao existe nenhum mov possivel
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
