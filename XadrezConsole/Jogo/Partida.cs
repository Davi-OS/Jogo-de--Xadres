using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using XadrezConsole.Jogo;
using XadrezConsole.tabuleiro;

namespace Jogo
{
    class Partida
    {
        public Tabuleiro tab { get;private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool encerrada { get; private set; }

        public Partida()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            encerrada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementaMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('c', 1).toPosicao());

        }

    }
}
