using BWF.DataServices.Metadata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.Domain.Models
{
    public class ReportPartyContact2 : IHaveId<long>
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string AddressCode { get; set; }
        public virtual string Telephone { get; set; }
        public virtual string Facsimile { get; set; }
        public virtual string Contact { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string LCAddress { get; set; }
        public virtual string LCRegNumber { get; set; }
        public virtual string LCEmail { get; set; }
        public virtual string LCTelephone { get; set; }
        public virtual string Active { get; set; }

    }
}
