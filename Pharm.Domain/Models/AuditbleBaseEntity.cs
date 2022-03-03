using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Domain.Models
{
    public abstract class AuditbleBaseEntity
    {
        public int Id { get; set; }

        public string Createdby { get; set; }

        public DateTime Created { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime LastModified { get; }
    }
}
