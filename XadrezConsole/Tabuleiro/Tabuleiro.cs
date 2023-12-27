using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace XadrezConsole.tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;
        public Tabuleiro(int nlinha, int ncoluna)
        {

            this.linhas = nlinha;
            this.colunas = ncoluna;
            this.pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public void colocarPeca(Peca peca, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("ja existe uma peça nessa posição");
            }
            pecas[pos.Linha, pos.Coluna] = peca;
            peca.Posicao = pos;
        }

        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }

            Peca aux = peca(pos);
            aux.Posicao = null;
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }
        public bool posicaoIsValida(Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Linha >= linhas || posicao.Coluna < 0 || posicao.Coluna >= colunas)
            {
                return false;

            }
            return true;
        }

        public bool existePeca(Posicao pos)
        {
            validaPosicao(pos);
            return peca(pos) != null;
        }

        public void validaPosicao(Posicao posicao)
        {
            if (!posicaoIsValida(posicao))
            {
                throw new TabuleiroException("Posição invalida");
            }
        }

    }
}
