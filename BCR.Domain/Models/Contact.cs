using BWF.DataServices.Metadata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.Domain.Models
{
    public class Contact : IHaveId<long>
    {
       public virtual long Id { get; set; }
       public virtual string ContactName { get; set; }
        public virtual bool Active { get; set; }
    }
}
