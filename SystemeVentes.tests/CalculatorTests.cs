using System;
using SystemeVentes.Models;
using SystemeVentes.Services;
using Xunit;

namespace SystemeVentes.tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculTPS_1_ShouldBe_0_05()
        {
            /// Arrange
            var product = new Product 
            {
                SalePrice = 1.00M
            };

            var expected = 0.05M;
            
            /// Act
            var actual = Calculatrice.CalculTPS(product);

            /// Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1.00, 0.05)]
        [InlineData(-10.00, -0.50)]
        [InlineData(50.00, 2.50)]
        [InlineData(1000.00, 50.00)]
        public void CalculTPS_Shouldbe_Valid(Decimal price, Decimal expected)
        {
            /// Arrange
            Product product = new() { SalePrice = price };

            /// Act
            var actual = Calculatrice.CalculTPS(product);

            /// Assert
            Assert.Equal(expected, actual);
        }
    }
}
