using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalBilgi.Core.Entities.Base
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public DateTime? DeleteDate { get; set; }


        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;

        public int? AddUserId { get; set; }
        public int? UpdateUserId { get; set; }
        public int? DeleteUserId { get; set; }
    }
}
