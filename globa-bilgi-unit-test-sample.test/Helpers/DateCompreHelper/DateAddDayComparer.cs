using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace globa_bilgi_unit_test_sample.test.Helpers.DateCompreHelper
{
    public class DateAddDayComparer : IEqualityComparer<DateTime>
    {
        public bool Equals([AllowNull] DateTime x, [AllowNull] DateTime y)
        {
            if (x.AddDays(1) == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode([DisallowNull] DateTime obj)
        {
            return obj.GetHashCode();
        }
    }
}
