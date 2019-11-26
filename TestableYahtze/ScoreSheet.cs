using System;
using System.Collections.Generic;
using System.Text;

namespace TestableYahtze
{
    public class ScoreSheet
    {
        public int Total { get; }
        public int YahzteScore { get; private set; }
        public int LargeStraightScore { get; }
        public int SmallStraightScore { get; }
        public int FullHouseScore { get; private set; }

        public void AddYahtze(IEnumerable<IDie> dice)
        {
            if (HasYahtze)
                throw new ArgumentException("A Yahtze has already been scored");

            if (!dice.IsYahtze())
                throw new ArgumentException("That roll does not contain a Yahtze");

            YahzteScore = 50;
        }

        public int FourOfAKindScore { get; }
        public int ThreeOfAKindScore { get; }
        public int ChanceScore { get; }
        public int AcesScore { get; }
        public int TwosScore { get; }
        public int ThreesScore { get; }
        public int FoursScore { get; }
        public int FivesScore { get; }
        public int SixesScore { get; }
        public int BonusScore { get; }
        public int YahzteBonuses { get; }
        public bool HasYahtze => YahzteScore != 0;

        public bool HasFullHouse => FullHouseScore != 0;

        public void AddFullHouse(IEnumerable<IDie> dice)
        {
            if (HasFullHouse)
                throw new ArgumentException("A Full House has already been scored");

            if (!dice.IsFullHouse())
                throw new ArgumentException("That roll does not contain a Full House");

            FullHouseScore = 25;
        }
    }
}
