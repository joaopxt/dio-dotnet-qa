using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Pessoa //ABSTRAÇÃO DE UM OBJETO PESSOA
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() //EU USO O "VIRTUAL" PARA SOBRESCREVER ESTA FUNÇÃO EM OUTRAS CLASSES: POLIMORFISMO
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }

    }
}