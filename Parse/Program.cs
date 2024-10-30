using System.Globalization;
using static System.Console;

WriteLine("Conversões com PARSE");
try
{
    WriteLine("----- .Parse");
    WriteLine($"{Int16.Parse("150")}");
    WriteLine("-----------------------------");
    // retorna -150, os parênteses representam o valor negativo
    WriteLine($"{Int16.Parse("(150)", NumberStyles.AllowParentheses)}");
    WriteLine("-----------------------------");
    // retorna 50000 mesmo com o ponto de milhar
    WriteLine($"{int.Parse("50.000", NumberStyles.AllowThousands)}");
    WriteLine("-----------------------------");
    // retorna 50000 mesmo com o simbolo monetário
    WriteLine($"Cultura atual: {CultureInfo.CurrentCulture.Name}");
    WriteLine("-----------------------------");
    WriteLine($"Símbolo da moeda: {NumberFormatInfo.CurrentInfo.CurrencySymbol}");
    WriteLine("-----------------------------");
    // retorna -200 mesmo com o símbolo de negativo
    WriteLine($"{int.Parse("-200", NumberStyles.AllowLeadingSign)}");
    WriteLine("-----------------------------");
    // retorna 200 mesmo com os espaçõs em branco antes e depois
    WriteLine($"{int.Parse(" 100 ", NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite)}");
    WriteLine("-----------------------------");
    // retorna 5432123456
    WriteLine($"{Int64.Parse("5432123456")}");
    WriteLine("-----------------------------");
    WriteLine($"Data: {DateTime.Parse("21/4/2021"):dd/MMM/yyyy}");
}
catch (Exception ex)
{
    WriteLine(ex);
}

ReadKey();