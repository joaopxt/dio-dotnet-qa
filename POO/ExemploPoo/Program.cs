// See https://aka.ms/new-console-template for more information
using ExemploPoo.Models;


Aluno a1 = new Aluno();
a1.Nome = "João";
a1.Idade = 16;
a1.Nota = 8.5;

a1.Apresentar();
//Console.WriteLine($"A nota de {a1.Nome} é {a1.Nota}");

Professor p1 = new Professor();
p1.Nome = "Maria";
p1.Idade = 35;
p1.Salario = 1000;
p1.Apresentar();
