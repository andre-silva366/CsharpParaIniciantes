﻿using static System.Console;
using static System.Math;
using static System.String;

//System.Math
// raiz quadrada

//WriteLine($"Raiz quadrada: {Sqrt(3*3 + 4*4)}");

//// Retorna o valor absoluto
//WriteLine($"Valor absoluto positivo: {Abs(1234.78)}");
//WriteLine($"Valor absoluto negativo: {Abs(-1234.78)}");
//WriteLine($"Valor absoluto negativo: {Abs(-850.99M)}");
//WriteLine($"Valor máximo: {Max(100,590)}");
//WriteLine($"Valor mínimo: {Min(100, 590)}");

//// Arredonda um valor para o inteiro mais próximo ou para o número especificado de casas decimais.
//WriteLine($"Arredonda com 1 casa decimal: {Round(3250.895M, 1)}");
//WriteLine($"Arredonda com 2 casas decimais: {Round(3250.895M, 1)}");

// System.String
WriteLine($"Tamanho da string: {"Livro de C#".Length}");
WriteLine($"Concatena 2 strings: {Concat("Livro de C#, ", "Livro de EF Core")}");
string livro = "Livro de EF Core";
WriteLine($"{livro.Insert(6,"avançado ").ToUpper()}");
ReadLine();


