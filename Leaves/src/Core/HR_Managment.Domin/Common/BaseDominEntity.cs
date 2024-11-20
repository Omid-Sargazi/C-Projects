using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Managment.Domin.Common
{
    public abstract class BaseDominEntity
    {
        public int Id { get; set; }
         public DateTime DateCreated { get; set; }
         public string CreatedBy { get; set; }
         public DateTime LastModifiedDate { get; set; }
         public string LastModifiedBy { get; set; }
    }
}