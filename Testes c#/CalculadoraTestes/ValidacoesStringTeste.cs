using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTeste
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTeste()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void Contar3CharEmOlaERetorna3()
        {
            // Arrange
            string texto = "ola";

            // Act
            int resultado = _validacoes.ContarCaracteres(texto);

            // Assert
            Assert.Equal(3, resultado);
        }
    }
}