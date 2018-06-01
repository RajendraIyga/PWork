using BCR.Domain.Models;
using BWF.DataServices.Metadata.Fluent.Abstract;
using BWF.DataServices.Metadata.Fluent.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.Domain.Metadata
{
    public class ContactMetadata : TypeMetadataProvider<Contact>
    {
        public ContactMetadata()
        {
            AutoUpdatesByDefault();

            ViewDefaults()
            .Property(x => x.ContactName)
            .Property(x => x.Active);

            IntegerProperty(x => x.Id)
                 .IsId()
                 .IsHidden();

            StringProperty(x => x.ContactName)
                .DisplayName("ContactName")
                .IsFreeFormat()
                .PersonalData(p => p
                .Searchable()
                .IncludeInReport()
                .IncludeInErasure(PersonalDataErasureRule.Obfuscate));

            BooleanProperty(x=>x.Active)
                .DisplayName("IsActive")
                .IsHidden()
                .PersonalData(p => p
                    .IncludeInReport()
                    .IncludeInErasure(PersonalDataErasureRule.Blank));

        }

    }
}
