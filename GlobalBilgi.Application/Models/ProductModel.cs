using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalBilgi.Application.Models
{
   public  class ProductModel : BaseModel
    {
        public string Name { get; set; }

        public int Stock { get; set; }
    }
}
