using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestableYahtze
{
    public static class YahzteDieExtensions
    {
        private static IEnumerable<HashSet<int>> validLargeStraightValues = new[]{
            new HashSet<int>(new []{1,2,3,4,5}),
            new HashSet<int>(new []{2,3,4,5,6 })
        };


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
            if (!dice.IsValidYahtzeRoll())
            {
                throw new ArgumentException("A Yahzte roll must be a 5d6");
            }

            return dice.GroupBy(d => d.Value).Count() == 1;
        }

        public static bool IsLargeStraight(this IEnumerable<IDie> dice)
        {
            if (!dice.IsValidYahtzeRoll())
            {
                throw new ArgumentException("A Yahtze roll must be a 5d6");
            }

            var dieValueSet = new HashSet<int>(dice.Select(d => d.Value));
            return validLargeStraightValues.Any(s => s.SetEquals(dieValueSet));
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
