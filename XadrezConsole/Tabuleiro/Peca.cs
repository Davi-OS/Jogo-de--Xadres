using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace XadrezConsole.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int nMovimentos { get; protected set; }

        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            this.Posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.nMovimentos = 0;
        }

        public void incrementaMovimentos()
        {
            nMovimentos++;
        }
        public abstract bool[,] movimentosPossiveis();

    }
}
