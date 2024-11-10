using static System.Console;

// Processamento assincrono

var web = new HttpClient();
var site = await web.GetStringAsync(new Uri("https://www.microsoft.com"));

// CPU bound

var lista = new List<string>();
lista.Add("Maria");
lista.Add("João");
lista.Add("Antonio");
lista.Add("Joaquim");
lista.Sort();

foreach (var item in lista)
{
    WriteLine(item);
}

ReadLine();