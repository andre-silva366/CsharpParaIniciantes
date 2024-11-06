using System.Linq.Expressions;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

//WriteLine("Usando LINQ com IEnumerable\n");

//var numeros = new[] { 1, 2, 3};

////Função entrada inteiro, saída booleano
//Func<int, bool> funcao = i => i > 2;
//var resultado = numeros.Where(funcao);

//// Faz a iteração na variavel resultado
//foreach (var numero in resultado)
//{
//    //Imprime o número
//    WriteLine(numero);
//}

//// Resultado : 3

//WriteLine("\nUsando LINQ com IQueryable\n");

//// IQueryable
//var numeros2 = numeros.AsQueryable();

//// Expressão
//Expression<Func<int, bool>> funcao2 = p => p > 2;

//// Filtro
//var resultado2 = numeros2.Where(funcao2);

//// Faz a iteração da variavel resultado2
//foreach (var numero in resultado2)
//{
//    //Imprime o número
//    WriteLine(numero);
//}

//WriteLine("\nConsulta com LINQ - usando sintaxe de método\n");

//// Array de números
//var numeros3 = new[] { 1,2,3,4,5,6,7,8,9,10};

//// Filtrar números => sintaxe de método
//var numerosFiltrados = numeros3.Where(n => n > 5);

//// Fazer iteração
//foreach (var item in numerosFiltrados)
//{
//    WriteLine(item);
//}

//WriteLine("\nConsulta com LINQ - usando sintaxe de consulta\n");

//// Array de números
//var numeros4 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//// Filtrar números => sintaxe de consulta
//var numerosFiltrados2 = from n in numeros4 where n > 5 select n;

//// Fazer iteração
//foreach (var item in numerosFiltrados2)
//{
//    WriteLine(item);
//}

//WriteLine("Operadores LINQ - WHERE");

//// Coleção de pessoas
//var pessoas = new[]
//{
//    "Carlos dos Santos","Renato Haddad","Claudenir Andrade","Andre Carlucci","Ray Carneiro","Rafael Almeida"
//};

////Filtro de pessoas que contém o nome Almeida
//var pessoasFiltradas = pessoas.Where(p => p.Contains("Almeida"));

//// Iteração com pessoas filtradas
//WriteLine("\nImprimindo nomes que contenham Almeida: ");
//foreach (var item in pessoasFiltradas)
//{
//    // Imprime no console o nome da pessoa
//    WriteLine(item);
//}

//WriteLine("\nOperador de agregação COUNT");

//var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//// Faz contagem em toda coleção
//var countTotal = numeros.Count();

//// Faz contagem na coleção com filtro
//var countParcial = numeros.Count(n => n > 5);

////Imprime contagem
//WriteLine("\nContagem de todos os números: " + countTotal);
//WriteLine("Contagem de números maiores que 5: " + countParcial);

//WriteLine("\nOperador de agregação SUM");

//var numeros1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//// Soma todos elementos da coleção
//var somaTotal = numeros1.Sum();

//// Soma cada elemento da coleção multiplicado por 2
//var somaComMultiplicação = numeros1.Sum(n => n * 2);

////Imprime soma
//WriteLine("\nSoma de todos os números: " + somaTotal);
//WriteLine("Soma de todos os números, multiplicado por 2: " + somaComMultiplicação);

//WriteLine("\nOperador de agregação MAX");

//var numeros2 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//// Recupera o valor máximo de um elemento da coleção
//var maxTotal = numeros2.Max();

//// Valor máximo do elemento da coleção multiplicado por 2
//var maxComMultiplicação = numeros2.Max(n => n * 2);

////Imprime valor máximo
//WriteLine("\nMaximo total: " + maxTotal);
//WriteLine("Maximo multiplicado por 2: " + maxComMultiplicação);

//WriteLine("\nOperador de agregação MIN");

//var numeros3 = new[] { 1, 2, 3, 4};

//// Recupera o valor máximo de um elemento da coleção
//var minTotal = numeros3.Min();

//// Valor máximo do elemento da coleção multiplicado por 2
//var minComMultiplicação = numeros3.Min(n => n * 2);

////Imprime valor minimo
//WriteLine("\nMinimo total: " + minTotal);
//WriteLine("Minimo multiplicado por 2: " + minComMultiplicação);

//WriteLine("\nOperador de agregação AVERAGE");

//var numeros4 = new[] { 1, 2, 3, 4 ,5,6,7,8,9,10};

//// Média dos elementos da coleção
//var media = numeros4.Average();

////Imprime valor da média
//WriteLine("\nMédia: " + media);

//WriteLine("\nOperador de Ordenação REVERSE");
//var numeros5 = new[] { 3, 2, 1 };

//// Executa o operador de ordenação na coleção
//var numerosReverse = numeros5.Reverse();

//WriteLine("Imprimindo os números invertidos.");

//foreach (var item in numerosReverse)
//{
//    WriteLine(item);
//}

//WriteLine("\nOperador de Ordenação ORDERBY");
//var numeros6 = new[] { 3, 1, 2 };

//// Executa o operador de ordenação na coleção
//var numerosOrderBy = numeros6.OrderBy(n => n);

//WriteLine("Imprimindo os números ordenados.");

//foreach (var item in numerosOrderBy)
//{
//    WriteLine(item);
//}

//WriteLine("\nOperador de Ordenação ORDERBYDESCENDING");
//var numeros7 = new[] { 3, 1, 2 };

//// Executa o operador de ordenação na coleção
//var numerosOrderByDesc = numeros6.OrderByDescending(n => n);

//WriteLine("Imprimindo os números ordenados de forma descendente.");

//foreach (var item in numerosOrderByDesc)
//{
//    WriteLine(item);
//}

//WriteLine("\nOperador de Paginação TAKE");
//var numeros8 = new[] { 1, 2, 3, 4 };

//// Executa o operador de paginação take na coleção
//var doisElementos = numeros8.Take(2);

//WriteLine("Imprimindo os números após o take");

//foreach (var item in doisElementos)
//{
//    WriteLine(item);
//}

//WriteLine("\nOperador de Paginação TAKEWHILE");
//var numeros9 = new[] { 5, 4, 9, 6,7,2 };

//// Executa o operador de paginação takewhile na coleção
//var items = numeros9.TakeWhile(n=> n < 6);

//WriteLine("Imprimindo os números após o takewhile");

//foreach (var item in items)
//{
//    WriteLine(item);
//}

//WriteLine("\nOperador de Paginação FIRST");
//var numeros10   = new[] { 5, 4, 9, 6, 7, 2 };

//// Executa o operador de paginação first na coleção
//var numero = numeros9.First();

//WriteLine("Imprimindo o numero após o first");
//WriteLine(numero);

//// Executa o operador de paginação first na coleção
//WriteLine("\nOperador de Paginação FIRST com sobrecarga");
//var numeroA = numeros10.First(n => n == 9);

//WriteLine("Imprimindo o numero após o first com sobrecarga");
//WriteLine(numeroA);

//WriteLine("\nOperador de Paginação FIRSTORDEFAULT");

//// Executa o operador de paginação first na coleção
//var numeroB = numeros10.FirstOrDefault( n => n == 10);

//WriteLine("Imprimindo o numero após o firstordefault --- número não encontrado retorna o padrão do tipo int : 0");
//WriteLine(numeroB);

//WriteLine("\nOperador de Paginação LAST e LASTORDEFAULT");
//var numeros11 = new[] { 5, 4, 9, 6, 7, 2 };

//// Executa o operador de paginação last na coleção
//var ultimo = numeros11.Last();
//WriteLine(ultimo);

//var ultimoOuDefault = numeros11.LastOrDefault(n => n == 10);
//WriteLine(ultimoOuDefault);

WriteLine("Operador de paginação - SINGLE");
var numeros = new[] {1,2,2,3};

//Executa o operador de paginação Single na coleção
try
{
    var numero = numeros.Single(n => n == 2);
    WriteLine(numero);
}
catch
{
    WriteLine("Ocorreu um erro, foi encontrado mais de um elemento");
}

var numero1 = numeros.Single(n => n == 3);
WriteLine(numero1);

var numero2 = numeros.SingleOrDefault(n => n == 3
);
WriteLine(numero2);

ReadLine();