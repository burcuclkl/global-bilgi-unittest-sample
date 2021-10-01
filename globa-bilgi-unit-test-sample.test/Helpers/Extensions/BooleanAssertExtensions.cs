using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using Xunit;

namespace globa_bilgi_unit_test_sample.test.Helpers.Extensions
{
    public static class BooleanAssertExtensions
    {

        public static void ShouldBeFalse(this bool condition)
        {
            Assert.False(condition);
        }

        public static void ShouldBeFalse(this bool condition, string userMessage)
        {
            Assert.False(condition, userMessage);
        }



    }
}
