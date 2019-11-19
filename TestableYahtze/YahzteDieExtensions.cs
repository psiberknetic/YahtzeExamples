using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestableYahtze
{
    public static class YahzteDieExtensions
    {
        public static bool IsValidYahtzeRoll(this IEnumerable<IDie> dice)
        {
            if (dice.Count() != 5 || dice.Any(d => d.Sides != 6))
            {
                return false;
            }

            return true;
        }

        public static bool IsYahtze(this IEnumerable<IDie> dice)
        {
            throw new NotImplementedException();
        }

        public static bool IsLargeStraight(this IEnumerable<IDie> dice)
        {
            throw new NotImplementedException();
        }

        public static bool IsSmallStraight(this IEnumerable<IDie> dice)
        {
            throw new NotImplementedException();
        }

        public static bool IsFullHouse(this IEnumerable<IDie> dice)
        {
            throw new NotImplementedException();
        }

        public static bool GetScoreByValue(this IEnumerable<IDie> dice)
        {
            throw new NotImplementedException();
        }

        public static bool GetTotalScore(this IEnumerable<IDie> dice)
        {
            throw new NotImplementedException();
        }
    }
}
