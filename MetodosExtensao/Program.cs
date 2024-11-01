using MetodosExtensao;
using static System.Console;

WriteLine(DateTime.Today.FormatarData("dd/MMM/yyyy"));
WriteLine(DateTime.Today.FormatarData("dddd dd/MMM/yyyy"));
WriteLine(DateTime.Today.FormatarData("yyyy"));

decimal valor = 5800.78m;

WriteLine(valor.Formatar("R$ ##,##0.00"));
WriteLine($"{4578.87M.Formatar("C2")}");
ReadLine();

