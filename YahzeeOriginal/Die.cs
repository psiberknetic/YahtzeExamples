using System;
using System.Collections.Generic;
using System.Text;

namespace Dice
{
    public class Die
    {
        public Die(int sides = 6)
        {
            if (sides <= 0)
            {
                throw new ArgumentException("Sides must be greater than zero", "sides");
            }

            Id = Guid.NewGuid();
            Sides = sides;
            Roll();
        }

        private readonly Random _random = new Random();
        private int _value;

        public Guid Id { get; }

        public int Value => _value;

        public int Sides { get; }

        public Die Roll()
        {
            _value = _random.Next(1, Sides);
            return this;
        }
    }
}
