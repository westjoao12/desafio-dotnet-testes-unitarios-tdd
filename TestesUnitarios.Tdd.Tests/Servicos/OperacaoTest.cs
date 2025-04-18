using Microsoft.VisualStudio.TestPlatform.Utilities;
using TestesUnitarios.Tdd.Console;

namespace TestesUnitarios.Tdd.Tests;

public class OperacaoTest
{
    [Fact]
    public void MultiplicacaoNumero2RetornaLista()
    {
        // Arrange
        var operacao = new Operacao();
        var listEsperado = new List<int>();
        for (int i = 1; i <= 24; i++)
        {
            if(i % 2 == 0)
                listEsperado.Add(i);
        }

        // Act
        var resultado = operacao.TabelaMultiplicar(2);

        //Assert
        Assert.Equal(listEsperado, resultado);     
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void ExibirTabuadaMultiplicacaoQuallquerNumero(int v)
    {
        //Arrange
        var operacao = new Operacao();
        string _resultadoEsperado = string.Empty;
        for (int i = 1; i <= 12; i++)
        {
            _resultadoEsperado += $"{v} x {i} = {v * i}\n";
        }
        
        //Act
        var resultado = operacao.ExibirTabuadaMultiplicacao(v);

        //Assert
        Assert.Equal(_resultadoEsperado, resultado);
    }
}