using ExemploExplorando.Models;

//UTILIZANDO O IF TERNÁRIO
int numero = 10;
bool ehPar = false;

ehPar = numero % 2 == 0;

Console.WriteLine($"O numero {numero} é " + (ehPar ? "par" : "ímpar")); //ESSA É A SINTAXE DE UM IF TERNÁRIO 

// if (numero % 2 == 0)   ESSA É A MANEIRA CONVENCIONAL DE SE FAZER UM IF ELSE
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }













/*UTILIZANDO UM DESCONSTRUTOR

Pessoa p1 = new Pessoa("João", "Peixoto");

(string nome, string sobrenome) = p1;

Console.WriteLine($"Nome: {nome}, Sobrenome: {sobrenome}");*/
















/* UTILIZANDO UM MÉTODO QUE RETORNA UMA TUPLA
LeituraArquivos arquivo = new LeituraArquivos();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine("Quantidade linhas do arquivo: " + qtdLinhas); CASO EU NÃO VÁ MAIS USAR O qtdLinhas, EU POSSO USAR O _ NA DECLARAÇÃO DELE PARA DESCARTAR ELE
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Erro ao ler o arquivo!");
}*/












/* UTILIZANDO TUPLAS
(int, string, string, decimal) tupla = (23, "João", "Peixoto", 1.85M);//ATRIBUIÇÃO DE TUPLA #1
Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");

ValueTuple<int, string, string, decimal> tupla2 = (21, "Emilly", "Peixoto", 1.55M);//ATRIBUIÇÃO DE TUPLA #2
Console.WriteLine($"ID: {tupla2.Item1}");
Console.WriteLine($"Nome: {tupla2.Item2}");
Console.WriteLine($"Sobrenome: {tupla2.Item3}");
Console.WriteLine($"Altura: {tupla2.Item4}");

var tupla3 = Tuple.Create(48, "Elinai", "Silva", 1.63M);//ATRIBUIÇÃO DE TUPLA #3
Console.WriteLine($"ID: {tupla3.Item1}");
Console.WriteLine($"Nome: {tupla3.Item2}");
Console.WriteLine($"Sobrenome: {tupla3.Item3}");
Console.WriteLine($"Altura: {tupla3.Item4}");*/

















/* UTILIZANDO DICIONÁRIOS
Dictionary<string, string> dicionario = new Dictionary<string, string>();

dicionario.Add("DF", "Distrito Federal"); //ADICIONANDO UM ELEMENTO NO DICIONÁRIO
dicionario.Add("RJ", "Rio de Janeiro");
dicionario.Add("MG", "Minas Gerais");

foreach (KeyValuePair<string, string> item  in dicionario)// Ou vocÊ pode só escrever (var in dicionario)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

try
{
    dicionario.Add("DF", "Distrito Federal"); //ADICIONANDO UM ELEMENTO JÁ EXISTENTE NO DICIONÁRIO
}
catch (Exception err)
{
    Console.WriteLine($"Erro ao adicionar o item: {err.Message}");
}

dicionario.Remove("DF"); //REMOVENDO UM ELEMENTO DO DICIONÁRIO
dicionario["RJ"] = "Rio de Janeiro continua lindo"; //ALTERANDO UM ELEMENTO DO DICIONÁRIO

Console.WriteLine("-------");

foreach (KeyValuePair<string, string> item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

string chave = "RJ";
Console.WriteLine($"Verificando o elemento: {chave}");

if (dicionario.ContainsKey(chave))//VERIFICANDO SE UM ELEMENTO EXISTE NO DICIONÁRIO
{
    Console.WriteLine($"O elemento {chave} existe no dicionário!");
}
else
{
    Console.WriteLine($"O elemento {chave} não existe no dicionário!");
}

Console.WriteLine(dicionario["RJ"]); //ACESSANDO UM ELEMENTO DO DICIONÁRIO
*/








/* UTILIZANDO PILHAS
Stack<int> pilha = new Stack<int>();
pilha.Push(1);
pilha.Push(3);
pilha.Push(5);
pilha.Push(7);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");

pilha.Push(9);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}*/











/*UTILIZANDO FILAS


Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach (int item in fila)
{
    Console.WriteLine(item);
}*/





/*TRATANDO EXCEÇÕES
new ExemploExcecao().Metodo1();

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo-Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}//Eu consigo tratar as exceções de forma individual:
catch (FileNotFoundException error)
{
    Console.WriteLine($"Erro ao ler o arquivo: Arquivo não encontrado! ({error.Message})");
}
catch (DirectoryNotFoundException error)
{
    Console.WriteLine($"Erro ao ler o arquivo: Caminho da pasta não encontrado! ({error.Message})");
}//Ou eu posso tratar todas as exceções de uma vez:
catch (Exception error)
{
    Console.WriteLine($"Erro ao ler o arquivo: {error.Message}");
}
finally
{
    Console.WriteLine("Após passar por todos os blocos, independente de erro ou sucesso no programa, o finally é executado!");
}*/








/*

MANIPULANDO LISTAS E OBJETOS

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

DateTime data = DateTime.Now;

Console.WriteLine($"Data de aquisição do curso: {data}");

Console.WriteLine("Fim do programa!");*/