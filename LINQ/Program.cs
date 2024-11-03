using System.Linq.Expressions;
using static System.Console;

WriteLine("Usando LINQ com IEnumerable\n");

var numeros = new[] { 1, 2, 3};

//Função entrada inteiro, saída booleano
Func<int, bool> funcao = i => i > 2;
var resultado = numeros.Where(funcao);

// Faz a iteração na variavel resultado
foreach (var numero in resultado)
{
    //Imprime o número
    WriteLine(numero);
}

// Resultado : 3

WriteLine("\nUsando LINQ com IQueryable\n");

// IQueryable
var numeros2 = numeros.AsQueryable();

// Expressão
Expression<Func<int, bool>> funcao2 = p => p > 2;

// Filtro
var resultado2 = numeros2.Where(funcao2);

// Faz a iteração da variavel resultado2
foreach (var numero in resultado2)
{
    //Imprime o número
    WriteLine(numero);
}

WriteLine("\nConsulta com LINQ - usando sintaxe de método\n");

// Array de números
var numeros3 = new[] { 1,2,3,4,5,6,7,8,9,10};

// Filtrar números => sintaxe de método
var numerosFiltrados = numeros3.Where(n => n > 5);

// Fazer iteração
foreach (var item in numerosFiltrados)
{
    WriteLine(item);
}

WriteLine("\nConsulta com LINQ - usando sintaxe de consulta\n");

// Array de números
var numeros4 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Filtrar números => sintaxe de método
var numerosFiltrados2 = from n in numeros4 where n > 5 select n;

// Fazer iteração
foreach (var item in numerosFiltrados2)
{
    WriteLine(item);
}

ReadLine();