using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("João", "Peixoto");

Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Silva");


Curso cursoIngles = new Curso();
cursoIngles.Nome = "Inglês";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();
cursoIngles.RemoverAluno(p2);
cursoIngles.ListarAlunos();

Console.WriteLine("Fim do programa!");