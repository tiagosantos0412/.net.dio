// Introdução ao operador de atribuição
// int a = 10;
// int b = 30;
// int c = a + b;

// Console.WriteLine($"Valor de C =  {c}");

//Combinando Operadores
//c = c + 5;
// c += 5;
// c -= 10;
// Console.WriteLine($"Valor de C =  {c}");

//Convertendo Tipos de Variáveis (Cast ou Casting)
// int a = 5;
// a = Convert.ToInt32("25");
// int b = int.Parse("52");
// int c = 21;
// c = 15;
// Console.WriteLine($"Valor de a =  {a}");
// Console.WriteLine($"Valor de b =  {b}");
// Console.WriteLine($"Valor de c =  {c}");

//Conversão para String
// int inteiro = 5;
// string a = Convert.ToString(inteiro);
// Console.WriteLine($"Valor de a = {a} {a.GetType()}");

//Conversão Implícita
// int a = 5;
// Console.WriteLine($"Valor de a = {a} {a.GetType()}");
// double b = a;
// Console.WriteLine($"Valor de a = {b} {b.GetType()}");
// int c = int.MaxValue;
// Console.WriteLine($"Valor de a = {c} {c.GetType()}");
// long d = c;
// Console.WriteLine($"Valor de a = {d} {d.GetType()}");

//Ordem dos operadores o C# segue a mesma regra da hierarquia dos operadores matemáticos
// double a  = 4 / (2 + 2);

// Console.WriteLine(a);

//Convertendo com segurança
string a = "15-";
int b = 0;
int.TryParse(a, out b);
Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!");

