using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestableYahtze;

namespace YahtzeSpecByExampleTests
{
    public static class DieTestMockingHelper
    {
        internal static IDie CreateMockD6(int value)
        {
            var d6 = new Mock<IDie>();
            d6.SetupGet(d => d.Sides).Returns(6);
            d6.SetupGet(d => d.Value).Returns(value);
            d6.SetupGet(d => d.Id).Returns(Guid.NewGuid());

            return d6.Object;
        }

        internal static IDie CreateMockDie(int sides, int value)
        {
            var d6 = new Mock<IDie>();
            d6.SetupGet(d => d.Sides).Returns(sides);
            d6.SetupGet(d => d.Value).Returns(value);
            d6.SetupGet(d => d.Id).Returns(Guid.NewGuid());

            return d6.Object;
        }

        internal static IEnumerable<IDie> CreateYahtze(int value)
        {
            return Enumerable.Range(1, 5)
                .Select(_ => CreateMockD6(value));
        }

        internal static IEnumerable<IDie> CreateRollWithNoSpecialScore()
        {
            return new[]{
                DieTestMockingHelper.CreateMockD6(5),
                DieTestMockingHelper.CreateMockD6(1),
                DieTestMockingHelper.CreateMockD6(1),
                DieTestMockingHelper.CreateMockD6(2),
                DieTestMockingHelper.CreateMockD6(4)
            };
        }

        internal static IEnumerable<IDie> CreateRollWithFullHouse()
        {
            return new[]{
                DieTestMockingHelper.CreateMockD6(1),
                DieTestMockingHelper.CreateMockD6(1),
                DieTestMockingHelper.CreateMockD6(1),
                DieTestMockingHelper.CreateMockD6(2),
                DieTestMockingHelper.CreateMockD6(2)
            };
        }
    }
}
