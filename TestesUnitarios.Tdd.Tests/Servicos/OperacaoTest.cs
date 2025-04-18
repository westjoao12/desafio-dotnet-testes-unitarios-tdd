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
}