using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Professor : Pessoa
    {
        public Professor()//Construtor sem parâmetros
        {

        }

        public Professor(string nome) : base(nome)//Para herdar um construtor, preciso passar este  ": base (nome)" para que a classe filha também
        {
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e sou um professor de salário: {Salario}");
        }
    }
}