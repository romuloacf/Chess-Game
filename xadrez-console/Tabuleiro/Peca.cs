using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        //Construtor inicia os valores.
        public Peca (Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.Tab = tab;
            this.QtdMovimentos = 0;
        }





    }
}
