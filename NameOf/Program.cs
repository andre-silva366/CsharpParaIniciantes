using static System.Console;

WriteLine("USO DE NAMEOF NO OPERADOR\n");
try
{
    string produto = "peixe";
    DateTime lancto = new DateTime(2010, 5, 15);
    WriteLine($"O {produto} tem {idade(lancto.Year)} anos");
    WriteLine($"O {produto} tem {idade(2025)} anos");
}
catch(Exception ex)
{
    WriteLine(ex.Message);
}

static int idade(int pAno)
{
    if(pAno > DateTime.Today.Year)
    {
        throw new Exception($"ano invalido {nameof(pAno)}");
    }
    return DateTime.Today.Year - pAno;
}

ReadLine();
