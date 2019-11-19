using System;
using System.Collections.Generic;
using System.Text;
using TestableYahtze;

namespace TestableYahtzeTests
{
    public class TestingD6 : IDie
    {
        public TestingD6(int value)
        {
            Value = value;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }

        public int Value { get; }

        public int Sides => 6;

        public IDie Roll()
        {
            return this;
        }
    }
}
