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
                DieTestMockingHelper.CreateMockD6(5),
                DieTestMockingHelper.CreateMockD6(5),
                DieTestMockingHelper.CreateMockD6(5),
                DieTestMockingHelper.CreateMockD6(5),
                DieTestMockingHelper.CreateMockD6(5)
            };

            dice.IsYahtze().Should().BeTrue();
        }
    }
}
