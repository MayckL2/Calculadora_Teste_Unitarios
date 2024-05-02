using Calculadora.Console.Controllers;

namespace CalculadoraTeste
{
    public class UnitTest1
    {
        private CalculadoraController _calc;

        public UnitTest1()
        {
            _calc = new CalculadoraController();
        }

        [Theory]
        [InlineData(1, 1, 2)]
        public void Somar(float num1, float num2, float esperado)
        {
            // Act
            float result = _calc.Somar(num1, num2);
            // Assert
            Assert.Equal(esperado, result);
        }
        
        [Theory]
        [InlineData(1, 1, 0)]
        public void Subtrair(float num1, float num2, float esperado)
        {
            // Act
            float result = _calc.Subtrair(num1, num2);
            // Assert
            Assert.Equal(esperado, result);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        public void Multiplicar(float num1, float num2, float esperado)
        {
            // Act
            float result = _calc.Multiplicar(num1, num2);
            // Assert
            Assert.Equal(esperado, result);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        public void Dividir(float num1, float num2, float esperado)
        {
            // Act
            float result = _calc.Dividir(num1, num2);
            // Assert
            Assert.Equal(esperado, result);
        }

        [Fact]
        public void Historico()
        {
            // Arrange
            _calc.Somar(1, 1);
            _calc.Subtrair(1, 1);
            _calc.Multiplicar(1, 1);
            _calc.Dividir(1, 1);
            // Act
            List<float> result = _calc.Historico();
            // Assert
            Assert.NotEmpty(result);
            Assert.Equal(4, result.Count);
        }
    }
}
