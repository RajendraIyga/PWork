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
    public class ReportContactDetail2Metadata : TypeMetadataProvider<ReportContactDetail2>
    {
        public ReportContactDetail2Metadata()
        {
            IdentificationSummaryFields()
               .Property(x => x.ContactId)
               .Property(x => x.PartyId);

            AutoUpdatesByDefault();

            ViewDefaults()
                 .Property(x => x.Id)
                  .Property(x => x.PartyId)
                  .Property(x => x.ContactId)
                  .Property(x => x.FirstName)
                  .Property(x => x.MiddleName)
                  .Property(x => x.LastName)
                  .Property(x => x.URL)
                  .Property(x => x.NickName)
                  .Property(x => x.AddressLine2)
                  .Property(x => x.Email1)
                  .Property(x => x.Email2)
                  .Property(x => x.PhoneMain)
                  .Property(x => x.PhoneOffice)
                  .Property(x => x.PhoneMobile)
                  .Property(x => x.PhoneHome)
                  .Property(x => x.PhoneFax)
                  .Property(x => x.PhonePager)
                  .Property(x => x.PhoneTelex)
                  .Property(x => x.PhoneTelexAnswerBack)
                  .Property(x => x.PostCode);
            StringProperty(x => x.Id)
              .IsId()
               .IsHidden();

            IntegerProperty(x => x.ContactId)
                .IsId()
                .IsHidden();
            IntegerProperty(x => x.PartyId)
                 .IsId()
                .IsHidden();
            StringProperty(x => x.FirstName)
              .IsFreeFormat()
              .PersonalData(p => p
                    .Searchable()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.MiddleName)
              .IsFreeFormat()
              .PersonalData(p => p
                    .Searchable()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.LastName)
              .IsFreeFormat()
              .PersonalData(p => p
                     .Searchable()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.URL)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.NickName)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.AddressLine2)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.Email1)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.Email2)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.PhoneMain)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.PhoneOffice)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.PhoneMobile)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.PhoneHome)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.PhoneFax)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.PhonePager)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.PhoneTelex)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.PhoneTelexAnswerBack)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());
            StringProperty(x => x.PostCode)
              .IsFreeFormat()
              .PersonalData(p => p
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInReport());

        }
    }
}
