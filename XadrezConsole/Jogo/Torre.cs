using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using XadrezConsole.tabuleiro;

namespace XadrezConsole.Jogo
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.cor != this.cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            // acima 
            pos.definirValores(this.Posicao.Linha - 1, this.Posicao.Coluna);
            while (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            //direita
            pos.definirValores(this.Posicao.Linha , this.Posicao.Coluna+1);
            while (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.Linha = pos.Coluna + 1;
            }

            // abaixo
            pos.definirValores(this.Posicao.Linha + 1, this.Posicao.Coluna);
            while (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            // esquerda
            pos.definirValores(this.Posicao.Linha, this.Posicao.Coluna - 1);
            while (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.Linha = pos.Coluna - 1;
            }


            return mat;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
