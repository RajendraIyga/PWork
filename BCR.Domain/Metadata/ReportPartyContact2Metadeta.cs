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
    public class ReportPartyContact2Metadeta : TypeMetadataProvider<ReportPartyContact2>
    {
        public ReportPartyContact2Metadeta()
        {
            AutoUpdatesByDefault();

            ViewDefaults()
                  .Property(x => x.Name)
                 .Property(x => x.Address)
                 .Property(x => x.AddressCode)
                 .Property(x => x.Telephone)
                 .Property(x => x.Facsimile)
                 .Property(x => x.Contact)
                 .Property(x => x.EmailAddress)
                 .Property(x => x.LCAddress)
                 .Property(x => x.LCRegNumber)
                 .Property(x => x.LCEmail)
                 .Property(x => x.LCTelephone)
                 .Property(x => x.Active);

            IntegerProperty(x => x.Id)
                .IsId()
                .IsHidden();

            StringProperty(x => x.Name)
                .PersonalData(p => p
                    .Searchable()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                .IsFreeFormat();
            StringProperty(x => x.Address)
                .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                    .IsFreeFormat();
            StringProperty(x => x.AddressCode)
                .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                    .IsFreeFormat();
            StringProperty(x => x.Telephone)
                 .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                   .IsFreeFormat();
            StringProperty(x => x.Facsimile)
                 .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                   .IsFreeFormat();
            StringProperty(x => x.Contact).PersonalData(p => p
            .Searchable()
                   .IncludeInErasure(PersonalDataErasureRule.Blank)
                   .IncludeInReport())
                   .IsFreeFormat();
            StringProperty(x => x.EmailAddress)
                 .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                   .IsFreeFormat();
            StringProperty(x => x.LCAddress)
                 .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                   .IsFreeFormat();
            StringProperty(x => x.LCRegNumber)
                 .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                   .IsFreeFormat();
            StringProperty(x => x.LCEmail)
                 .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                   .IsFreeFormat();
            StringProperty(x => x.LCTelephone)
                 .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                   .IsFreeFormat();
            StringProperty(x => x.Active)
                 .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport())
                   .IsFreeFormat();


        }
    }
}
