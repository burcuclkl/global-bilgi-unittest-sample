using global_bilgi_unittest_sample.Models.DISample2;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace globa_bilgi_unit_test_sample.test.ManagerTests
{
    public class DashboardTests
    {

        Mock<global_bilgi_unittest_sample.Models.DISample2.IProgress> _progress;

        public DashboardTests()
        {
            _progress = new Mock<global_bilgi_unittest_sample.Models.DISample2.IProgress>();
        }


        [Fact]
        public void Init()
        {
            Dashboard dashboard = new Dashboard(_progress.Object);
            dashboard.Init();
        }

    }
}
