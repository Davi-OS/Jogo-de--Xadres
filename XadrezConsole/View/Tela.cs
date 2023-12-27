using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using XadrezConsole.tabuleiro;

namespace XadrezConsole.View
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (tabuleiro.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tabuleiro.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H ");
        }
        public static void imprimirPeca(Peca p)
        {
            if(p.cor == Cor.Branca)
            {
                Console.Write(p);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(p);
                Console.ForegroundColor = aux;  
            }
        }
    }
}
