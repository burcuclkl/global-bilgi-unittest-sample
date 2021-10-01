using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace global_bilgi_unittest_sample.Models.DISample
{
    public class SupplierManager
    {
        ILogger _logger;

        public SupplierManager(ILogger logger)
        {
            _logger = logger;
        }


        public void AddSupplier(Supplier supplier)
        {
            //db işlemleri vesaire....

            _logger.LogAt();
            //log atılacak
        }

    }
}
