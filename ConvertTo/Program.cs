using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

try
{
    // Conversões com Convert.To
    WriteLine("-----Convert Números");
    int n1 = Convert.ToInt16("100");
    WriteLine($"{n1.GetType()} - {n1}");
    Int32 n2 = Convert.ToInt32("200500");
    WriteLine($"{n2.GetType()} - {n2}");
    Int64 n3 = Convert.ToInt64("1003232131321321");
    WriteLine($"{n3.GetType()} - {n3}");
    decimal preco = Convert.ToDecimal("1420,50");
    WriteLine($"{preco.GetType()} - {preco: n2}");
    WriteLine();
    WriteLine("-----Convert String");
    string texto1 = Convert.ToString(250.59M);
    WriteLine($"{texto1.GetType()} - { texto1} - resultado: {texto1 ?? "texto é nulo"}");
    string texto2 = Convert.ToString(DateTime.Today);
    WriteLine($"{ texto2.GetType()} - { texto2}");
    WriteLine();
    WriteLine("-----Convert Boleano");
    bool valido = Convert.ToBoolean("false");
    WriteLine($"{ valido.GetType()} - { valido}");
    WriteLine($"0 - { Convert.ToBoolean(0)}");
    WriteLine($"1 - { Convert.ToBoolean(1)}");
    WriteLine($"100 - { Convert.ToBoolean(100)}");
    WriteLine();
    WriteLine("-----Convert Data");
    DateTime natal = Convert.ToDateTime("25 / 12 / 2021");
    WriteLine($"Natal: { natal.GetType()} - {natal: dd / MMMM / yyyy}");
    WriteLine($"Natal: { natal.Day} - {natal.Month} - { natal.Year}");
}
catch (Exception ex)
{
    WriteLine(ex);
}

ReadKey();

