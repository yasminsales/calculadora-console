using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora_console
{
    class OperacoesMatematicas
    { 
        public int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Subtracao(int numero1, int numero2)
        {
            return numero1 - numero2; 
        }

        public int Multiplicacao(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Divisao(int numero1, int numero2)
        {
            return numero1 / numero2; 
        }
    }
}
