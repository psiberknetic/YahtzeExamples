using System;

namespace TestableYahtze
{
    public class Die : IDie
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

        public IDie Roll()
        {
            _value = _random.Next(1, Sides);
            return this;
        }
    }
}
