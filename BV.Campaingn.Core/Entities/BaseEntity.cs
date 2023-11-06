using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string UserCreated { get; set; }
        public string UserUpdated { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateUpdated { get; set; }
        public DateTimeOffset DateDeleted { get; set; }
    }
}
