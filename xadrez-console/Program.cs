using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* Tabuleiro tab = new Tabuleiro(8, 8);
                 tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                 tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                 tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                 tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                 Tela.imprimirTabuleiro(tab);
                 Console.ReadLine();*/

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);
                    Console.WriteLine();

                    Console.Write("Posição Origem:");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                    
                    Console.Clear();
                    //imprimir as posições marcadas
                    Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Posição Destino");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);


                }


            }

            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
