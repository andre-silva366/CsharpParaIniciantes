using static System.Console;
WriteLine("--- Uso de dicionarios ---");
var sexo = new Dictionary<string, string>();
sexo.Add("M", "Masculino");
sexo.Add("F", "Feminino");
WriteLine(sexo["F"]);

var cidades = new Dictionary<string, string>
{
    ["MG"] = "Minas Gerais",
    ["SC"] = "Santa Catarina",
    ["SP"] = "São Paulo",
    ["RS"] = "Rio Grande do Sul"
};

WriteLine();

WriteLine($"--- dicionário com {cidades.Count} Cidades ---");
WriteLine(cidades["MG"]);
//WriteLine(cidades["mg"]); // =>  gera erros
//WriteLine(cidades[0]);   // => erro compilação

foreach (var cidade in cidades)
{
    WriteLine($"key: {cidade.Key} , value: {cidade.Value}");
}

WriteLine();

WriteLine("--- dicionário Países ---");
var paises = new Dictionary<int, string>
{
    [100] = "Brasil",
    [2] = "Australia",
    [60] = "Nova Zelândia"
};

foreach (var pais in paises)
{
    WriteLine($"key: {pais.Key} , value: {pais.Value}");
}

WriteLine();

var texto = new string[]
{           // índice do inicio  índice do final
    "Meu",     //       0               ^9
    "codigo",  //       1               ^8
    "rodou",   //       2               ^7
    "sem",     //       3               ^6
    "erros",   //       4               ^5
    "para",    //       5               ^4
    "ler",       //     6               ^3
    "cadastro",  //     7               ^2
    "clientes",  //     8               ^1
    
};

WriteLine($"A última palavra é : {texto[^1]}");
WriteLine($"A primeira palavra é : {texto[^9]}");

WriteLine();

WriteLine("--- parte do texto ---");
var pedacoTexto = texto[1..4]; // indices 1,2 e 3
foreach (var p in pedacoTexto)
{
    WriteLine(p);
}

WriteLine();

WriteLine("--- intervalo da coleção ---");
Range intervalo = 1..6; // indices 1,2,3,4,5
foreach (var p in texto[intervalo])
{
    WriteLine(p);
}

WriteLine();

var todas = texto[..]; // todas as palavras
WriteLine("--- primeiras 4 ---");
var primeiras4 = texto[..4];// primeiras quatro palavras indices 0,1,2 e 3
foreach (var p in primeiras4)
{
    WriteLine(p);
}

WriteLine();

WriteLine("--- últimas 4 ---");
var ultimas4 = texto[5..];// 4 últimas  indices: 5,6,7,8,9 ..........
foreach (var p in ultimas4)
{
    WriteLine(p);
}

ReadKey();
