using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using TestableYahtze;

namespace TestableYahtzeTestsWithMocking
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
    }
}
