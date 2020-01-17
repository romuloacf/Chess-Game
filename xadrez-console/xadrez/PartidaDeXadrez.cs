using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; set; }
        private int Turno;
        private Cor JogadorAtual;

        public PartidaDeXadrez()
        {
        }

        public PartidaDeXadrez(Tabuleiro tab, int turno, Cor jogadorAtual)
        {
            Tab = tab; //new Tabuleiro(8,8);
            
            Turno = 1;
            JogadorAtual = Cor.Branca;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQteMovimentos();
            Peca PecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c',1).ToPosicao());
                        
        }




    }
}
