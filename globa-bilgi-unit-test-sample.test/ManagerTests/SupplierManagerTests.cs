using Castle.Core.Logging;
using global_bilgi_unittest_sample.Models.DISample;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace globa_bilgi_unit_test_sample.test.ManagerTests
{
    public class SupplierManagerTests
    {

        private readonly Mock<global_bilgi_unittest_sample.Models.DISample.ILogger> _logger;

        public SupplierManagerTests()
        {
            _logger = new Mock<global_bilgi_unittest_sample.Models.DISample.ILogger>();
        }


        [Fact(DisplayName ="Supplier Ekle")]
        public void AddSupplier()
        {
            SupplierManager supplierManager = new SupplierManager(_logger.Object);

            Supplier supplier = new Supplier();
            supplier.CompanyName = "Vestel";
            supplier.ContactName = "Zorlu";

            supplierManager.AddSupplier(supplier);



        }
    }
}
