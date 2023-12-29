using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using XadrezConsole.tabuleiro;

namespace XadrezConsole.Jogo
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
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
            if (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //nordeste
            pos.definirValores(this.Posicao.Linha - 1, this.Posicao.Coluna + 1);
            if (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //direita
            pos.definirValores(this.Posicao.Linha, this.Posicao.Coluna + 1);
            if (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //sudeste
            pos.definirValores(this.Posicao.Linha + 1, this.Posicao.Coluna + 1);
            if (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // abaixo
            pos.definirValores(this.Posicao.Linha + 1, this.Posicao.Coluna);
            if (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // sudoeste
            pos.definirValores(this.Posicao.Linha + 1, this.Posicao.Coluna - 1);
            if (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // esquerda
            pos.definirValores(this.Posicao.Linha, this.Posicao.Coluna - 1);
            if (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // noroeste
            pos.definirValores(this.Posicao.Linha - 1, this.Posicao.Coluna - 1);
            if (tabuleiro.posicaoIsValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
