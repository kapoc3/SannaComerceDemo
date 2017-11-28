using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaComerce.Domain.Entities
{
    public abstract class SannaComerce
    {
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UserName { get; set; }

    }
}
