namespace CalculadoraTestes;

using Calculadora.Services;

public class CalcTestes
{

    private CalculadoraImplementacao _calc;

    public CalcTestes()
    {
        _calc = new CalculadoraImplementacao();
    }


    [Fact]
    public void Soma10Com2ERetorna12()
    {
        // Arrange
        int n1 = 10;
        int n2 = 2;

        // Act
        int resultado = _calc.Somar(n1, n2);

        // Assert
        Assert.Equal(12, resultado);
    }

    [Fact] // Teste passando um parametro só
    public void DeveVerificarSe4EhParERetornarTrue()
    {
        // Arrange
        int n = 4;

        // Act
        bool resultado = _calc.EhPar(n);

        // Assert
        Assert.True(resultado);
    }


    //     Teste Theory passando um inteiro por vez
    //     [Theory] //Teste passando vários parametros
    //     [InlineData(2)]
    //     [InlineData(4)]
    //     [InlineData(6)]
    //     [InlineData(8)]
    //     [InlineData(10)]
    //     public void DeveVerificarSeOsNumeroSaoParesERetornarTrue(int n)
    //     {

    //         // Act
    //         bool resultado = _calc.EhPar(n);

    //         // Assert
    //         Assert.True(resultado);
    //     }
    // }


    // Teste Theory passando arrays de inteiros
    [Theory] //Teste passando vários parametros
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]

    public void DeveVerificarSeOsNumeroSaoParesERetornarTrue(int[] ns)
    {

        // Act - Assert
        Assert.All(ns, x => Assert.True(_calc.EhPar(x)));
    }


    [Theory] //Teste passando vários parametros
    [InlineData(2, 4, 8)]
    public void TesteMultiplicar(int n1, int n2, int resultadoEsperado)
    {

        // Act
        int resultado = _calc.Multiplicar(n1, n2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory] //Teste passando vários parametros
    [InlineData(4, 2, 2)]
    public void TesteDividir(int n1, int n2, int resultadoEsperado)
    {

        // Act
        int resultado = _calc.Dividir(n1, n2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory] //Teste passando vários parametros
    [InlineData(4, 2, 2)]
    public void TesteSubtrair(int n1, int n2, int resultadoEsperado)
    {

        // Act
        int resultado = _calc.Subtrair(n1, n2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {


        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(10, 0));
    }

    [Fact]
    public void TestarHistorico()
    {

        _calc.Somar(10, 2);
        _calc.Somar(10, 4);
        _calc.Somar(10, 6);
        _calc.Somar(10, 3);

        var lista = _calc.Historico();


        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}


