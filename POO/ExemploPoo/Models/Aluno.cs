using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Aluno : Pessoa //O OBJETO ALUNO ESTÁ HERDANDO AS PROPRIEDADES E MÉTODOS DO OBJETO PESSOA
    {

        public Aluno()
        {

        }

        public Aluno(string nome) : base(nome) //Para herdar um construtor, preciso passar este  ": base (nome)" para que a classe filha também 
        {
        }

        public double Nota { get; set; } //PROPRIEDADE NOTA SOMENTE DO OBJETO ALUNO

        public override void Apresentar() //AQUI ESTOU UTILIZANDO O CONCEITO DE POLIMORFISMO PARA SOBRESCREVER MEU MÉTODO APRESENTAR()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e minha nota é {Nota}");
        }
    }
}