using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XadrezConsole.tabuleiro
{
     class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;
        public Tabuleiro(int nlinha, int ncoluna) {

            this.linhas = nlinha;
            this.colunas = ncoluna;
            this.pecas = new Peca[linhas,colunas];
        }

        public Peca peca( int linha, int coluna)
        {
            return pecas[linha, coluna];
        }


    }
}
