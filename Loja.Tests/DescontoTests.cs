using System.Reflection.PortableExecutable;

namespace Loja.Tests;

public class DescontoTests
{
    [Fact]
    public void Quando_o_produto_eh_vermelho_o_desconto_eh_de_10_porcento()
    {
        // Preparar -> Arrange
        var desconto = new Desconto();

        // Executar -> Act
        var valor = desconto.Calcule(Cor.Vermelho);

        // Verificar - Assert
        Assert.Equal(10, valor);
    }

    [Fact]
    public void Quando_o_produto_eh_verde_o_desconto_eh_de_20_porcento()
    {
        // Preparar
        var desconto = new Desconto();

        // Executar
        var valor = desconto.Calcule(Cor.Verde);

        // Verificar
        Assert.Equal(20, valor);
    }

    [Fact]
    public void Quando_o_produto_eh_azul_o_desconto_eh_de_30_porcento()
    {
        // Preparar
        var desconto = new Desconto();

        // Executar
        var valor = desconto.Calcule(Cor.Azul);

        // Verificar
        Assert.Equal(10, valor);
    }
}