namespace MetodosExtensao;

public static class MetodosExtensao
{
    // o método de extensão deve set static
    public static string FormatarData(this DateTime data, string formato) => data.ToString(formato);
    public static string Formatar(this decimal valor, string formato) => valor.ToString(formato);
}
