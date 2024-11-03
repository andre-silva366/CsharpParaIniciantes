using static System.Console;

// Func < até 16 entradas e UMA saída >
int contador = 0;
Func<int> numero = () => ++contador;
WriteLine($"chamada 1 : {numero()}");
WriteLine($"chamada 2 : {numero()}");
WriteLine($"contador : {contador}");

// Func contador de caracteres
Func<string, int> contadorCaracteres = (string palavra) => palavra.Length;
WriteLine(contadorCaracteres("Visual C#"));

// Quantidade de palavras de uma expressão
Func<string, int> contaPalavras = (string texto) => texto.Split(' ').Where(x => x != "").Count();
WriteLine(contaPalavras("       Brasil  campeão            mundial     de     volei"));

//string texto = "       Brasil  campeão            mundial     de     volei";
//var novoTexto = texto.Split(' ').Where(x => x!= "") ;

//WriteLine("teste split começa");
//foreach (var item in novoTexto)
//{
//    WriteLine(item);
//}
//WriteLine("teste split termina");


// calcular o imposto
// salario, perc, aliquota
// formula: salario * (perc/100) - aliquota
// condicao: salario <= 1000 >>> imposto = 0
// cond ? true : false

Func<decimal, decimal, decimal, decimal> imposto = (salario, percentual, aliquota) =>
{
    return salario <= 100 ? 0 : salario * (percentual / 100) - aliquota;
};

WriteLine("---- Calculo do imposto ---");
WriteLine(imposto(1000, 10, 10).ToString("c2"));
WriteLine(imposto(5000, 27.5m, 80).ToString("c2"));
WriteLine(imposto(23500, 32.5m, 180).ToString("c2"));


ReadLine();

