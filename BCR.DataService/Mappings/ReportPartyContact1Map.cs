using BCR.Domain.Models;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.Mappings
{
    public class ReportPartyContact1Map : ClassMapping<ReportPartyContact1>
    {
        public ReportPartyContact1Map()
        {
            Table("ReportPartyContact1");
            Id(x => x.Id, m => m.Column("U_ID"));
            Property(x => x.Name, m => m.Column("sName"));
            Property(x => x.Address, m => m.Column("sAddress"));
            Property(x => x.AddressCode, m => m.Column("sAddressCode"));
            Property(x => x.Telephone, m => m.Column("sTelephone"));
            Property(x => x.Facsimile, m => m.Column("sFacsimile"));
            Property(x => x.Contact, m => m.Column("sContact"));
            Property(x => x.EmailAddress, m => m.Column("sEmailAddress"));
            Property(x => x.LCAddress, m => m.Column("sLCAddress"));
            Property(x => x.LCRegNumber, m => m.Column("sLCRegNumber"));
            Property(x => x.LCEmail, m => m.Column("sLCEmail"));
            Property(x => x.LCTelephone, m => m.Column("sLCTelephone"));
            Property(x => x.Active, m => m.Column("sActive"));

        }
    }
}
