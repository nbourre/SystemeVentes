using System;
using System.Collections;
using System.Collections.Generic;
using SystemeVentes.Models;
using SystemeVentes.Services;
using Xunit;

namespace SystemeVentes.tests
{
    public class CalculatorTests
    {
        class TestingThingWithThings
        {
            public static IEnumerable<object[]> Data = new List<object[]> {
                new object[] { 1, 0.05 },
                new object[] { -10, -0.50 },
                new object[] { 50.00, 2.50 },
                new object[] { 1000.00, 50.00 },
                new object[] { 1000000, 50000 }
            };
        }


        class TestDataGenerator : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { 1, 0.05 };
                yield return new object[] { -10, -0.50 };
                yield return new object[] { 50.00, 2.50 };
                yield return new object[] { 1000.00, 50.00 };
                yield return new object[] { 1000000, 50000 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }


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
        [ClassData(typeof(TestDataGenerator))]
        [MemberData(nameof(TestingThingWithThings.Data), MemberType = typeof(TestingThingWithThings))]
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
        public void CalculTVQ_NullProduct_Should_Fail()
        {
            /// Arrange
            Product prod = null;

            Action act = () => Calculatrice.CalculTVQ(prod);

            /// Assert
            Assert.Throws<ArgumentNullException>(act);
        }

    }
}
