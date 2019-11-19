using System;
using System.Collections.Generic;
using System.Text;
using TestableYahtze;

namespace TestableYahtzeTests
{
    // This is "poor man's Mocking" This works great on a small scale, but creating
    // these classes on a large scale doesn't work well. We'll talk about Mocking 
    // frameworks
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
