using System;
using SystemeVentes.Models;
using SystemeVentes.Services;
using Xunit;

namespace SystemVentes.tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculTPS_1_ShouldBe_0_05()
        {
            
            /// Arrange
            var obj = new Product{ SalePrice = 1.00M};

            var expected = 0.05M;

            /// Act
            var actual = Calculatrice.CalculTPS(obj);

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

        [Theory]
        [InlineData(1.00, 10, 10.00)]
        [InlineData(1000.00, 10, 10000.00)]
        [InlineData(-50.00, 1000, -50000.00)]
        [InlineData(9.99, 25.2, 251.748)]
        public void CalculSoustotal_ShoulBe_Valid(Decimal price, double quantity, Decimal expected)
        {
            /// Arrange
            var obj = new Product { SalePrice = price };
                        

            /// Act
            var actual = Calculatrice.CalculSoustotal(obj, quantity);

            /// Assert
            Assert.Equal(expected, actual);
        }


    }
}
