using System.Globalization;
using static System.Console;

// Comaparando Strings

// 1 
//Console.WriteLine();

//string upper = "ANDRÉ LUIZ DA SILVA";
//string lower = "andré luiz da silva";

//Console.WriteLine($"Comparando as Strings: {upper == lower}");
//Console.WriteLine($"Comparando as Strings: {upper == lower.ToUpper()}");
//Console.WriteLine($"Comparando as Strings: {upper.Equals(lower,StringComparison.OrdinalIgnoreCase)}");

//Console.WriteLine();
//Console.ReadLine();
////Usando o Remove

//string nome1 = "Cibele Pereira Fonseca";
//Console.WriteLine("Nome antes do Remove(9): " + nome1);
//var nome2 = nome1.Remove(9);
//Console.WriteLine("Nome depois do Remove(9): " + nome2);
//var nome3 = nome2.Remove(nome1.IndexOf(" "));
//Console.WriteLine("Nome usando indexOf: " + nome3);

//var i = nome1.IndexOf(" ");
//Console.WriteLine("Indice do primeiro espaço: " + i);

//Console.WriteLine();
//Console.ReadLine();

//// Usando o Split

//string texto = "Rua George Ebers";
//string[] palavras = texto.Split(' ');
//var contador = 1;
//foreach (var item in palavras)
//{
//    Console.WriteLine($"{contador++} - {item}");
//}

//Console.WriteLine();
//Console.ReadLine();

//string[] cesta = ["5 Laranjas", "10 Goiabas Vermelhas", "5 Pêssegos doces", "5 Bananas"];

//foreach (var item in cesta)
//{
//    Console.WriteLine($"{item.Substring(item.IndexOf(" ") + 1)}");

//}

//string texto = "Hoje é dia 28 de outubro de 2024";
//string[] palavras = texto.Split(' ');

//foreach (var item in palavras)
//{
//    Console.WriteLine(item);
//}

//Console.ReadKey();
//Console.WriteLine();

//string[] frutas = ["100 - Laranja", "20 - Pêras", "30 - Ameixas", "50 - Mangas", "80 - Limões"];
//int qtde = 0;

//foreach (var fruta in frutas)
//{
//    Console.WriteLine(fruta.Substring(fruta.IndexOf('-') + 2));
//    qtde += Convert.ToInt32(fruta.Substring(0, fruta.IndexOf(' ')));
//}

//Console.WriteLine($"Quantidade total: {qtde}");


//string texto = "Hoje é dia 28 de outubro de 2024";
//string texto2 = texto.Remove(10,3);

//Console.WriteLine(texto2);
//Console.WriteLine(texto2.Length);

// Datas

//int dia = 12;
//int mes = 05;
//int ano = 2021;
//DateTime dtAniversario = new DateTime(ano, mes, dia);
//DateTime dtFesta = new DateTime(2021, 08,25);

//Console.WriteLine("------Funções de Datas------ -");
//Console.WriteLine($"Aniversário: { dtAniversario}");
//Console.WriteLine($"Aniversário: {dtAniversario:dd/MM/yyyy}");
//Console.WriteLine($"Aniversário: {dtAniversario:ddd/MMM/yyyy}");
//Console.WriteLine($"Aniversário: {dtAniversario:dddd dd/MMMM/yyyy}");

//DateTime hoje = DateTime.Today;
//WriteLine("TODAY - retorna a data atual");
//WriteLine($"TODAY: {hoje:dd/MM/yyyy HH:mm:ss}");

//WriteLine();

//DateTime DataHora = DateTime.Now;
//WriteLine($"NOW - retorna a data e a hora atual");
//WriteLine($"Now: {DataHora:dd/MM/yyyy HH:mm:ss}");

//DateTime DataHora = DateTime.Now.ToUniversalTime();

//WriteLine("DAY / MONTH / YEAR - capturar o dia, mês e ano separadamente");
//WriteLine($"Dia: {DataHora.Day}");
//WriteLine($"Mês: {DataHora.Month}");
//WriteLine($"Ano: {DataHora.Year}");
//WriteLine($"Kind: {DataHora.Kind}");
//WriteLine($"Hora: {DataHora.Hour}");
//WriteLine($"Minuto: {DataHora.Minute}");
//WriteLine($"Dia da semana: {DataHora.DayOfWeek}");
//WriteLine($"Dia do ano: {DataHora.DayOfYear}");

//DateTime dtPedido = DateTime.Today;
//// adiciona 35 dias
//DateTime dtVencto = dtPedido.AddDays(35);

//// adiciona 2 meses
//DateTime dtPagto = dtVencto.AddMonths(2);
//WriteLine($"Pedido feito em {dtPedido:dd/MMM/yyyy} vence em {dtVencto:dd/MMM/yyyy}");
//WriteLine($"Formatação completa: {dtVencto.ToLongDateString()}");
//WriteLine($"Formatação curta: {dtVencto.ToShortDateString()}");
//WriteLine();

//// dia da semana
//WriteLine($"Dia da semana: {dtVencto.DayOfWeek}");
//WriteLine($"Dia da semana em português: {dtVencto.ToString("dddd",new CultureInfo("pt-BR"))}");
//WriteLine($"Número do dia da semana: {(int) dtVencto.DayOfWeek}");
//WriteLine();

//// dia do ano
//WriteLine($"Dia do ano: {dtVencto.DayOfYear}");
//WriteLine();

//// subtrai 2 datas
//var qtdeDias = dtPagto.Subtract(dtPedido);
//WriteLine($"Entre o pedido e o pagamento foram {qtdeDias:dd} dias");

// Conversoes de Datas
WriteLine("Conversão de Texto para Date");
string dataTexto = "30/06/2024";
DateTime dataTextoConvertida;

// tentativa (TryParse) de conversão de dataTexto 
// caso dê certo a saida OUT será em dataTextoConvertida
if (DateTime.TryParse(dataTexto, out dataTextoConvertida))
{
    WriteLine("Data com conversão aceita");
}
else
{
    WriteLine("Erro na conversão da data");
}
 
string dataTextoErrada = "30/metade do ano/2023";
DateTime dataTextoErradaConvertida;
if(DateTime.TryParse(dataTextoErrada, out dataTextoErradaConvertida))
{
    WriteLine("Data com conversão aceita");
}
else
{
    WriteLine("Erro na conversão da data");
}

WriteLine($"DataTextoConvertida: {dataTextoConvertida}");
WriteLine($"DataTextoErradaConvertida: {dataTextoErradaConvertida}");

ReadKey();