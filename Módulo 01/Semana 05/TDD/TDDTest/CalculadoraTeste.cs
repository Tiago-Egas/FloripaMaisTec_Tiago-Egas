using Xunit;
using TDD;
using TDD.Classes;

namespace TDDTest
{
    public class CalculadoraTeste
    {
        /// <summary>
        /// This function tests the sum of two integers
        /// </summary>
        [Fact]
        public void TestarSomarComNumerosInteiros()
        {
            int resultado = Calculadora.Somar(5, 5);

            int esperado = 10;

            Assert.Equal(resultado, esperado);
        }

        /// <summary>
        /// This function tests the sum of two decimal numbers
        /// </summary>
        [Fact]
        public void TestarSomarComNumerosDecimais()
        {
            decimal resultado = Calculadora.Somar(5.3M, 5.78M);

            decimal esperado = 11.08M;

            Assert.Equal(esperado, resultado);
        }

        /// <summary>
        /// This function tests the method DivisivelPor() from the class Calculadora
        /// </summary>
        [Fact]
        public void TestarMetodoDivisivelPor()
        {
            bool resultado = Calculadora.DivisivelPor(9, 3);
        }
    }
}
