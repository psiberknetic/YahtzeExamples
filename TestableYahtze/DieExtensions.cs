using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestableYahtze;

namespace TestableYahtzeTestsWithMocking
{
    public static class DieExtensions
    {
        public static int GetTotalBySide(this IEnumerable<IDie> dice, int side)
        {
            var sideGroup = dice.GroupBy(d => d.Value)
                .FirstOrDefault(g => g.Key.Equals(side));

            return sideGroup?.Key * sideGroup?.Count() ?? 0;
        }

        public static int GetDieCountBySide(this IEnumerable<IDie> dice, int side)
        {
            return dice.GroupBy(d => d.Value)
                .Where(g => g.Key.Equals(side))
                .Select(g => g.Count())
                .FirstOrDefault();
        }

        public static int GetMaxValue(this IEnumerable<IDie> dice)
        {
            throw new NotImplementedException();
        }
    }
}
