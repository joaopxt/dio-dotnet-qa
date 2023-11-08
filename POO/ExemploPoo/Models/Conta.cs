using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public abstract class Conta // abstract: não pode ser instanciada, só pode ser herdada
    {
        protected decimal saldo;// protected: só pode ser acessado pelas classes que herdam de Conta

        public abstract void Creditar(decimal valor); // método abstrato, os objetos que herdarem que serão responsáveis por implementar o método

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }
    }
}