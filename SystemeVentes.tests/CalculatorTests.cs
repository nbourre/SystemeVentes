using System;
using SystemeVentes.Models;
using SystemeVentes.Services;
using Xunit;

namespace SystemeVentes.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculTPS_1_ShouldBe_0_05()
        {
            /// Arrange
            var prod = new Product() { SalePrice = 1.00M };

            var expected = 0.05M;

            /// Act
            /// 
            var actual = Calculatrice.CalculTPS(prod);

            /// Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 0.05)]
        [InlineData(-10.00, -0.50)]
        [InlineData(50.00, 2.50)]
        [InlineData(1000.00, 50.00)]
        [InlineData(1000000, 50000)]
        public void CalculTPS_ShouldBe_Valid(Decimal price, Decimal expected)
        {
            /// Arrange
            var prod = new Product() { SalePrice = price };

            /// Act
            /// 
            var actual = Calculatrice.CalculTPS(prod);

            /// Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-10.00)]
        [InlineData(50.00)]
        [InlineData(1000.00)]
        [InlineData(1000000)]
        public void CalculTPS_NonTaxable_ShouldBe_Zero_Pass(Decimal price)
        {
            /// Arrange
            var prod = new Product() { SalePrice = price, TaxableFederal = false };
            var expected = 0.0M;
            /// Act
            /// 
            var actual = Calculatrice.CalculTPS(prod);

            /// Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculTPS_NullProduct_Should_Fail()
        {
            /// Arrange
            Product prod = null;
            
            /// Act
            /// 

            /// Assert
            Assert.Throws<ArgumentNullException>(() => Calculatrice.CalculTPS(prod));
            
        }

    }
}
