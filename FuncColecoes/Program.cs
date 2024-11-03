using FuncColecoes;
using static System.Console;

WriteLine("---- Cálculo de FUNC em coleções");
// Fórmula : média de km rodados por ano
// Km /(today.year - ano)
// "Modelo - Ano - Km - Cor - Litros - km/ano"

int anoAtual = DateTime.Today.Year;
Func<int, double, double> CalculoKmPorAno = (ano, km) => ano >= anoAtual ? km : km / (anoAtual - ano);

//Carrega a lista de carros
var dados = Carro.Get();

// looping para varrer todos os carros da lista
dados.ForEach( c =>
{
    var KmPorAno = CalculoKmPorAno(c.AnoFabricacao, c.KmRodados);
    WriteLine($"{c.Modelo}  |   ano: {c.AnoFabricacao}  |   km: {c.KmRodados:n0}    |   litros: {c.Litros}  |   km/ano: {KmPorAno:n0}");
});

ReadLine();
    
