using tabuleiro;
using System;
using XadrezConsole.tabuleiro;
using XadrezConsole.View;
using XadrezConsole.Jogo;
using Jogo;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 2));


                tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(3, 5));
                tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(3, 4));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}