using System;
using System.Collections;
using System.Linq;

namespace TestableYahtze
{
    class Program
    {
        static void Main(string[] args)
        {
            //A bunch of Yahtze code...
            //Player has rolled dice and now has the dice they'd like to score
            var roll = Enumerable.Range(1, 5).Select(_ => new Die());
            if (roll.IsYahtze())
            {
                //score as Yahtze
            }
            else if (roll.IsLargeStraight())
            {
                // score as Full House
            }
            //etc...
        }
    }
}
