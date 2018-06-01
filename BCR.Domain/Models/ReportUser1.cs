using BWF.DataServices.Metadata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.Domain.Models
{
   public class ReportUser1 : IHaveId<long>
    {
        public virtual long Id { get; set; }
        public virtual string LoginId { get; set; }
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Active { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string Telephone { get; set; }

    }
}
