﻿using System;
using System.Collections.Generic;
using System.Text;
using TestableYahtze;

namespace TestableYahtzeTestsWithMocking
{
    public static class DieExtensions
    {
        public static int GetTotalBySide(this IEnumerable<IDie> dice, int side)
        {
            throw new NotImplementedException();
        }

        public static int GetDieCountBySide(this IEnumerable<IDie> dice, int side)
        {
            throw new NotImplementedException();
        }
    }
}
