using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestableYahtze;

namespace TestableYahtzeTestsWithMocking
{
    [TestClass]
    public class DieExtensionsTests
    {
        [TestMethod]
        public void GetTotalBySide_OneDie_ReturnsCorrectValue()
        {
            var dice = new[]{
                DieTestMockingHelper.CreateMockD6(6)
            };

            dice.GetTotalBySide(6).Should().Be(6);
        }

        [TestMethod]
        public void GetTotalBySide_MultipleDice_ReturnsCorrectValue()
        {
            var dice = new[]{
                DieTestMockingHelper.CreateMockD6(6),
                DieTestMockingHelper.CreateMockD6(2),
                DieTestMockingHelper.CreateMockD6(4),
                DieTestMockingHelper.CreateMockD6(6),
                DieTestMockingHelper.CreateMockD6(2),
                DieTestMockingHelper.CreateMockD6(5)
            };

            dice.GetTotalBySide(2).Should().Be(4);
        }

        [TestMethod]
        public void GetTotalBySide_MultipleTypesOfDice_ReturnsCorrectValue()
        {
            var dice = new[]{
                DieTestMockingHelper.CreateMockD6(6),
                DieTestMockingHelper.CreateMockDie(4,2),
                DieTestMockingHelper.CreateMockD6(2),
                DieTestMockingHelper.CreateMockD6(4),
                DieTestMockingHelper.CreateMockD6(6),
                DieTestMockingHelper.CreateMockD6(2),
                DieTestMockingHelper.CreateMockD6(5),
                DieTestMockingHelper.CreateMockDie(8,2),
                DieTestMockingHelper.CreateMockDie(4,1)
            };

            dice.GetTotalBySide(2).Should().Be(8);
        }

        [TestMethod]
        public void GetTotalBySide_MultipleDiceSideNotRepresented_ReturnsZero()
        {
            var dice = new[]{
                DieTestMockingHelper.CreateMockD6(6),
                DieTestMockingHelper.CreateMockD6(2),
                DieTestMockingHelper.CreateMockD6(4),
                DieTestMockingHelper.CreateMockD6(6),
                DieTestMockingHelper.CreateMockD6(2),
                DieTestMockingHelper.CreateMockD6(5)
            };

            dice.GetTotalBySide(1).Should().Be(0);
        }

        [TestMethod]
        public void GetTotalBySide_NoDice_ReturnsZero()
        {
            var dice = Enumerable.Empty<IDie>();

            dice.GetTotalBySide(5).Should().Be(0);
        }
    }
}
