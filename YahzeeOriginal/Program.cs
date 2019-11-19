using System;
using System.Collections.Generic;
using System.Linq;

namespace YahzeeOriginal
{
    class Program
    {
        static void Main(string[] args)
        {
            //A bunch of Yahtze code...
            //Player has rolled dice and now has the dice they'd like to score
            var dice = Enumerable.Range(1, 5).Select(_ => new Die());
            if (IsYahtze(dice))
            {
                //score as Yahtze
            }
            else if (IsFullHouse(dice))
            {
                // score as Full House
            }
            //etc...
        }

        // Note these private functions are very difficult to test. We can't write tests for 
        // private functions, and making them public breaks encapsulation

        // Also, the randomness of the die implementation makes these very difficult to test
        private static bool IsYahtze(IEnumerable<Die> dice)
        {
            var dieGroups = dice.GroupBy(d => d.Value);
            return dieGroups.Count() == 1;
        }

        private static bool IsFullHouse(IEnumerable<Die> dice)
        {
            var dieGroups = dice.GroupBy(d => d.Value);
            if (dieGroups.Count() == 2 && dieGroups.Select(g => g.Count()).OrderBy(i => i).ToArray() == new int[] { 2, 3 })
            {
                return true;
            }

            return false;
        }

        // etc... other Yahtze functions
    }
}
