using _1._1___Sintaxe_e_Identação.models;

// Declarando variáveis
// Inteiros:
int numeroInteiro = 10;

// Ponto Flutuante:
float numeroFlutuante = 3.14f;
double numeroDuplo = 325.14;

// Caracteres:
char caractere = 'A';

// Booleano:
bool verdadeiroOuFalso = true;

// Tipos de Dados Compostos:
// Cadeia de Caracteres (String):
string texto = "Hello, World!";

// Declarando uma variável como Date Time
DateTime dataAtual = DateTime.Now;

//Instanciando uma classe e atribuindo e exibindo os valores dos atributos
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Tiago";
pessoa1.Idade = 37;

pessoa1.Apresentar();

Console.WriteLine("Data e hora: " + dataAtual);
Console.WriteLine("Data e hora: " + dataAtual.ToString("dd/mm/yyyy"));
 