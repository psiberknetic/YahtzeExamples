using System;
using System.Collections.Generic;
using System.Text;

namespace TestableYahtze
{
    public interface IDie
    {
        IDie Roll();

        Guid Id { get; }
        int Value { get; }
        int Sides { get; }
    }
}
