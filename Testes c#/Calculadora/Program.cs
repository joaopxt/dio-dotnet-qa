using Calculadora.Services;


CalculadoraImplementacao c = new CalculadoraImplementacao();

int n1 = 10;
int n2 = 2;

Console.WriteLine($"Soma: {n1} + {n2} = {c.Dividir(n1, n2)}");


int n = new ValidacoesString().ContarCaracteres("joao");
Console.WriteLine(n);

