using BCR.Domain.Models;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.Mappings
{
    public class ContactMap : ClassMapping<Contact>
    {
        public ContactMap()
        {
            Id(x => x.Id, m=> m.Column("lContactId"));
            Property(x => x.ContactName, m=>m.Column("sMnemonic"));
            Property(x => x.Active, m => m.Column("bActive"));
            Table("Contact");
        }
    }
}
