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
    public class ReportContact1Metadata : TypeMetadataProvider<ReportContact1>
    {
        public ReportContact1Metadata()
        {
            IdentificationSummaryFields()
                .Property(x => x.ContactId)
                .Property(x => x.ContactDetailId);

            AutoUpdatesByDefault();

            ViewDefaults()
                .Property(x => x.Id)
                .Property(x => x.ContactId)
                .Property(x => x.ContactDetailId)
                .Property(x => x.Contact)
                .Property(x => x.Description)
                .Property(x => x.ApplicationUser)
                .Property(x => x.ISActive)
                .Property(x => x.ContactSalutation)
                .Property(x => x.FirstName)
                .Property(x => x.MiddleName)
                .Property(x => x.LastName)
                .Property(x => x.Suffix)
                .Property(x => x.Title)
                .Property(x => x.NickName)
                .Property(x => x.AddressLine1)
                .Property(x => x.AddressLine2)
                .Property(x => x.AddressLine3)
                .Property(x => x.Email1)
                .Property(x => x.Email2)
                .Property(x => x.PhoneMain)
                .Property(x => x.PhoneOffice)
                .Property(x => x.PhoneMobile)
                .Property(x => x.PhoneHome)
                .Property(x => x.PhoneFax)
                .Property(x => x.PhonePager)
                .Property(x => x.PhoneTelex)
                .Property(x => x.PhoneTelexAnswerBack);

            StringProperty(x => x.Id)
              .IsId()
               .IsHidden();

            IntegerProperty(x => x.ContactId)
                .IsId() 
                .IsHidden();
            IntegerProperty(x => x.ContactDetailId)
                 .IsId()
                .IsHidden();

            StringProperty(x => x.Contact)
                .IsFreeFormat()
                .PersonalData(p => p
                .IncludeInErasure(PersonalDataErasureRule.Blank)
                .IncludeInReport()
                .Searchable());

            StringProperty(x => x.Contact)
                .IsFreeFormat()
                .PersonalData(p => p
                .IncludeInErasure(PersonalDataErasureRule.Blank)
                .IncludeInReport()
                .Searchable());

            StringProperty(x => x.Description)
               .IsFreeFormat()
               .PersonalData(p => p
               .IncludeInErasure(PersonalDataErasureRule.Blank)
               .IncludeInReport()
              );

            StringProperty(x => x.ApplicationUser)
              .IsFreeFormat()
              .PersonalData(p => p
              .IncludeInErasure(PersonalDataErasureRule.Blank)
              .IncludeInReport()
             );

            StringProperty(x => x.ISActive)
              .IsFreeFormat()
              .PersonalData(p => p
              .IncludeInErasure(PersonalDataErasureRule.Blank)
              .IncludeInReport()
             );

            StringProperty(x => x.FirstName)
               .IsFreeFormat()
               .PersonalData(p => p
               .IncludeInErasure(PersonalDataErasureRule.Blank)
               .IncludeInReport()
               .Searchable());

            StringProperty(x => x.LastName)
               .IsFreeFormat()
               .PersonalData(p => p
               .IncludeInErasure(PersonalDataErasureRule.Blank)
               .IncludeInReport()
               .Searchable());

            StringProperty(x => x.MiddleName)
              .IsFreeFormat()
              .PersonalData(p => p
              .IncludeInErasure(PersonalDataErasureRule.Blank)
              .IncludeInReport()
              .Searchable());

            StringProperty(x => x.Title)
              .IsFreeFormat()
              .PersonalData(p => p
              .IncludeInErasure(PersonalDataErasureRule.Blank)
              .IncludeInReport()
             );

            StringProperty(x => x.Suffix)
             .IsFreeFormat()
             .PersonalData(p => p
             .IncludeInErasure(PersonalDataErasureRule.Blank)
             .IncludeInReport()
            );

            StringProperty(x => x.Title)
            .IsFreeFormat()
            .PersonalData(p => p
            .IncludeInErasure(PersonalDataErasureRule.Blank)
            .IncludeInReport()
           );

            StringProperty(x => x.NickName)
           .IsFreeFormat()
           .PersonalData(p => p
           .IncludeInErasure(PersonalDataErasureRule.Blank)
           .IncludeInReport()
          );

            StringProperty(x => x.AddressLine1)
           .IsFreeFormat()
           .PersonalData(p => p
           .IncludeInErasure(PersonalDataErasureRule.Blank)
           .IncludeInReport()
          );

            StringProperty(x => x.AddressLine2)
           .IsFreeFormat()
           .PersonalData(p => p
           .IncludeInErasure(PersonalDataErasureRule.Blank)
           .IncludeInReport()
          );

            StringProperty(x => x.AddressLine3)
          .IsFreeFormat()
          .PersonalData(p => p
          .IncludeInErasure(PersonalDataErasureRule.Blank)
          .IncludeInReport()
         );
         StringProperty(x => x.Email1)
        .IsFreeFormat()
        .PersonalData(p => p
        .IncludeInErasure(PersonalDataErasureRule.Blank)
        .IncludeInReport()
       );

       StringProperty(x => x.Email2)
      .IsFreeFormat()
      .PersonalData(p => p
      .IncludeInErasure(PersonalDataErasureRule.Blank)
      .IncludeInReport()
     );

            StringProperty(x => x.PhoneMain)
      .IsFreeFormat()
      .PersonalData(p => p
      .IncludeInErasure(PersonalDataErasureRule.Blank)
      .IncludeInReport()
     );

            StringProperty(x => x.PhoneOffice)
      .IsFreeFormat()
      .PersonalData(p => p
      .IncludeInErasure(PersonalDataErasureRule.Blank)
      .IncludeInReport()
     );

            StringProperty(x => x.PhoneMobile)
     .IsFreeFormat()
     .PersonalData(p => p
     .IncludeInErasure(PersonalDataErasureRule.Blank)
     .IncludeInReport()
    );

            StringProperty(x => x.PhoneFax)
    .IsFreeFormat()
    .PersonalData(p => p
    .IncludeInErasure(PersonalDataErasureRule.Blank)
    .IncludeInReport()
   );

            StringProperty(x => x.PhoneHome)
   .IsFreeFormat()
   .PersonalData(p => p
   .IncludeInErasure(PersonalDataErasureRule.Blank)
   .IncludeInReport()
  );

            StringProperty(x => x.PhonePager)
  .IsFreeFormat()
  .PersonalData(p => p
  .IncludeInErasure(PersonalDataErasureRule.Blank)
  .IncludeInReport()
 );

            StringProperty(x => x.PhoneTelex)
 .IsFreeFormat()
 .PersonalData(p => p
 .IncludeInErasure(PersonalDataErasureRule.Blank)
 .IncludeInReport()
);
            StringProperty(x => x.PhoneTelexAnswerBack)
 .IsFreeFormat()
 .PersonalData(p => p
 .IncludeInErasure(PersonalDataErasureRule.Blank)
 .IncludeInReport()
);
        }
    }
}
