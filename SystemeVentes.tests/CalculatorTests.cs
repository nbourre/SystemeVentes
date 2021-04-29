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

        [Theory]
        [InlineData(1, 0.09975)]
        [InlineData(-10.00, -1)]
        [InlineData(50.00, 4.99)]
        [InlineData(1000.00, 99.75)]
        [InlineData(1000000, 99750)]
        public void CalculTVQ_ShouldBe_Valid(Decimal price, Decimal expected)
        {
            /// Arrange
            var prod = new Product() { SalePrice = price };

            /// Act
            /// 
            var actual = Calculatrice.CalculTVQ(prod);

            /// Assert
            Assert.Equal(expected, actual, 2);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-10.00)]
        [InlineData(50.00)]
        [InlineData(1000.00)]
        [InlineData(1000000)]
        public void CalculTVQ_NonTaxable_ShouldBe_Zero_Pass(Decimal price)
        {
            /// Arrange
            var prod = new Product() { SalePrice = price, TaxableProvincial = false };
            var expected = 0.0M;
            /// Act
            /// 
            var actual = Calculatrice.CalculTVQ(prod);

            /// Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculTVQ_NullProduct_Should_Fail()
        {
            /// Arrange
            Product prod = null;

            /// Assert
            Assert.Throws<ArgumentNullException>(() => Calculatrice.CalculTVQ(prod));
        }
    }
}
