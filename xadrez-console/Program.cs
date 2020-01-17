using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tabuleiro tab = new Tabuleiro(8, 8);
              tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
              tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
              tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
              Tela.imprimirTabuleiro(tab);
              Console.ReadLine();*/

            Console.WriteLine("Entre com pos char:");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Entre com pos number:");
            int num = int.Parse(Console.ReadLine());            
            
            PosicaoXadrez pos = new PosicaoXadrez(ch, num);

            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());


            Console.ReadLine();



        }
    }
}
