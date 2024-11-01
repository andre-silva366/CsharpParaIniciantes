using static System.Console;

WriteLine("Parâmetros Opcionais");
WriteLine(ParametrosOpcionais.Faturamento(500,5,10));
WriteLine("Parâmetros 1 e 2");
WriteLine(ParametrosOpcionais.Faturamento(50, 12));
WriteLine("Parâmetros 1 e 3"); 
WriteLine(ParametrosOpcionais.Faturamento(50, bonus: 12));
ReadLine();

public static class ParametrosOpcionais
{
    // regra : obrigatórios DEVEM vir antes dos opcionais
   public static decimal Faturamento(decimal qtde, decimal preco = 10, decimal bonus = 5) => qtde * preco + bonus;
}



