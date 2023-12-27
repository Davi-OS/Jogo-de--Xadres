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
                Partida jogo = new Partida();
                while (!jogo.encerrada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(jogo.tab);


                    Console.Write("Origem:");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino:");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    jogo.executaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}