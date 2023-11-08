// See https://aka.ms/new-console-template for more information
using ExemploPoo.Interfaces;
using ExemploPoo.Models;


ICalculadora calc = new Calculadora(); //IMPLEMENTANDO UMA INTERFACE
Console.WriteLine(calc.Somar(10, 20));







//EXPLORANDO HERANÇA DA CLASSE OBJECT
// Computador c = new Computador();
// Console.WriteLine(c.GetType()); //Estes são os métodos da classe Object, que já vem de ''fábrica'' para todas as classes


//EXPLORANDO CLASSES ABSTRATAS
// Corrente c1 = new Corrente();
// c1.Creditar(1000);
// c1.ExibirSaldo();
// c1.Creditar(500);
// c1.ExibirSaldo();





















// Aluno a1 = new Aluno();
// a1.Nome = "João";
// a1.Idade = 16;
// a1.Nota = 8.5;

// a1.Apresentar();
// //Console.WriteLine($"A nota de {a1.Nome} é {a1.Nota}");

// Professor p1 = new Professor();
// p1.Nome = "Maria";
// p1.Idade = 35;
// p1.Salario = 1000;
// p1.Apresentar();
