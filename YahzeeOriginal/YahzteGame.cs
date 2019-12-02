using System;
using System.Collections.Generic;
using System.Linq;
using YahzeeOriginal;

namespace YahtzeOriginal
{
    public class YahzteGame
    {
        public void TakeTurn()
        {
            var dice = RollDice();

            //A bunch of Yahtze code...
            //Player has rolled dice and now has the dice they'd like to score

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

        private IEnumerable<Die> RollDice()
        {
            return Enumerable.Range(1, 5).Select(_ => new Die());
        }

        // Note these private functions are very difficult to test. We can't write tests for 
        // private functions, and making them public breaks encapsulation

        // Also, the randomness of the die implementation makes these very difficult to test
        private bool IsYahtze(IEnumerable<Die> dice)
        {
            var dieGroups = dice.GroupBy(d => d.Value);
            return dieGroups.Count() == 1;
        }

        private bool IsFullHouse(IEnumerable<Die> dice)
        {
            var dieGroupCounts = dice.GroupBy(d => d.Value).Select(g => g.Count());
            if (dieGroupCounts.Contains(2) && dieGroupCounts.Contains(3))
            {
                return true;
            }

            return false;
        }

        // etc... other Yahtze functions
    }
}
