using System;
using SystemeVentes.Models;
using SystemeVentes.Services;
using Xunit;

namespace SystemeVentes.tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculTPS_ShouldBe_Valid()
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
    }
}
