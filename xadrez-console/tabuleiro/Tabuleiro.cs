namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        
        private Peca[,] pecas;     //Matriz de peças

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; 
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)  //Sobrecarga do método peca
        {
            return pecas[pos.linha, pos.coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)     //Método para colocar a peça no tabuleiro
        {
            if (existePeca(pos))           //Verifica se a posição está vaga antes de colocar a peça
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool existePeca(Posicao pos)       //Verifica se existe uma peça em uma posição
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public bool posicaoValida(Posicao pos)      //Valida se a posição é valida
        {
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) //Caso a pos~ção nao seja valida ele lança uma execção
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida");
            }
        }
    }
}
