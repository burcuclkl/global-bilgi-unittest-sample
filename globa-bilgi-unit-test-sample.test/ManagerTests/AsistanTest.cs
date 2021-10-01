using global_bilgi_unittest_sample.Models.StateDesingPattern;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace globa_bilgi_unit_test_sample.test.ManagerTests
{
    public class AsistanTest
    {
        Mock<IMode> _mode;

        public AsistanTest()
        {
            _mode = new Mock<IMode>();
        }


        [Fact]
        public void ChangeMode()
        {
            Asistan asistan = new Asistan();
            asistan.ChangeMode(_mode.Object);


        }
    }
}
