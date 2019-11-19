using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TestableYahtze;

namespace TestableYahtzeTests
{
    [TestClass]
    public class YahtzeDieExtensionsTests
    {
        [TestMethod]
        public void IsValidYahtzeRoll_TooManyDice_ReturnsFalse()
        {
            var dice = Enumerable.Range(1, 6).Select(_ => new Die());

            dice.IsValidYahtzeRoll().Should().BeFalse();
        }

        [TestMethod]
        public void IsValidYahtzeRoll_NotEnoughDice_ReturnsFalse()
        {
            var dice = Enumerable.Range(1, 4).Select(_ => new Die());

            dice.IsValidYahtzeRoll().Should().BeFalse();
        }

        [TestMethod]
        public void IsValidYahtzeRoll_NotAllD6_ReturnsFalse()
        {
            var dice = Enumerable.Range(1, 4).Select(_ => new Die())
                .Concat(Enumerable.Range(1, 1).Select(_ => new Die(4)));

            dice.IsValidYahtzeRoll().Should().BeFalse();
        }

        [TestMethod]
        public void IsValidYahtzeRoll_Is5d6_ReturnsTrue()
        {
            var dice = Enumerable.Range(1, 5).Select(_ => new Die());

            dice.IsValidYahtzeRoll().Should().BeTrue();
        }

        [TestMethod]
        public void IsYahtze_RollContainsYahtze_ReturnsTrue()
        {
            var dice = new[]{
                new TestingD6(6),
                new TestingD6(6),
                new TestingD6(6),
                new TestingD6(6),
                new TestingD6(6)
            };

            dice.IsYahtze().Should().BeTrue();
        }

        [TestMethod]
        public void IsYahtze_RollDoesNotContainYahzte_ReturnsFalse()
        {
            var dice = new[]{
                new TestingD6(6),
                new TestingD6(4),
                new TestingD6(6),
                new TestingD6(6),
                new TestingD6(6)
            };

            dice.IsYahtze().Should().BeFalse();
        }

        [TestMethod]
        public void IsYahtze_InvalideYahtzeRoll_ThrowsException()
        {
            var dice = new[]{
                new TestingD6(6),
                new TestingD6(6),
                new TestingD6(6),
                new TestingD6(6)
            };

            Action yahzteCheck = () => dice.IsYahtze();

            yahzteCheck.Should().Throw<ArgumentException>();
        }
    }
}
