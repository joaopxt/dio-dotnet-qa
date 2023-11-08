using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPoo.Interfaces;

namespace ExemploPoo.Models
{
    public class Calculadora : ICalculadora
    {
        // public int Dividir(int n1, int n2) //COMO EU JÁ IMPLEMENTEI A FUNÇÃO NA INTERFACE, NÃO PRECISO IMPLEMENTAR AQUI
        // {
        //     return n1 / n2; //A IMPLEMENTAÇÃO DELE É OPCIONAL, POIS JÁ FOI IMPLEMENTADA NA INTERFACE
        // }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}