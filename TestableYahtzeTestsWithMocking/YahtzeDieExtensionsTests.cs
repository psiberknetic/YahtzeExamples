using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using TestableYahtze;

namespace TestableYahtzeTestsWithMocking
{
    [TestClass]
    public class YahtzeDieExtensionsTests
    {
        [TestMethod]
        public void IsYahtze_HasFiveOfAKind_IsTrue()
        {
            var dice = new[]{
                CreateMockD6(5),
                CreateMockD6(5),
                CreateMockD6(5),
                CreateMockD6(5),
                CreateMockD6(5)
            };

            dice.IsYahtze().Should().BeTrue();
        }

        private IDie CreateMockD6(int value)
        {
            var d6 = new Mock<IDie>();
            d6.SetupGet(d => d.Sides).Returns(6);
            d6.SetupGet(d => d.Value).Returns(value);
            d6.SetupGet(d => d.Id).Returns(Guid.NewGuid());

            return d6.Object;
        }
    }
}
