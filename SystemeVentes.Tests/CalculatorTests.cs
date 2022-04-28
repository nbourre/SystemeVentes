using System;
using System.Collections.Generic;
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
            var obj = new Product { SalePrice = 1.0M };

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

        [Fact]
        public void CalculTPSMulti_ShoudBe_valid()
        {
            /// Arrange
            var produits = new List<Product>
            {
                new Product {SalePrice = 1.0M},
                new Product {SalePrice = 13.0M},
            };

            var expected = 0.70M;

            /// Act
            var actual = Calculatrice.CalculTPSMulti(produits);

            /// Assert
            Assert.Equal(expected, actual);

        }

    }
}
