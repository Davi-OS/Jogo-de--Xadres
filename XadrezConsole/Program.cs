using tabuleiro;
using System;
using XadrezConsole.tabuleiro;
namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(2,4);
            Console.WriteLine("Posicão "+ p);
            Tabuleiro tabuleiro = new Tabuleiro(8,8);
            Tela.imprimirTabuleiro(tabuleiro);

        }
    }
}