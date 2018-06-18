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
    public class ContactDetailMeatadata : TypeMetadataProvider<ContactDetail>
    {
        public ContactDetailMeatadata()
        {
            AutoUpdatesByDefault();

            ViewDefaults()
             .Property(x => x.ContactId)
           
            .Property(x => x.FirstName)
            .Property(x => x.MiddleName)
            .Property(x => x.LastName)
            .Property(x => x.Suffix)
            .Property(x => x.Title)
            .Property(x => x.NickName)
            .Property(x => x.Department)
            .Property(x => x.URL)
            .Property(x => x.AddressLine1)
            .Property(x => x.AddressLine2)
            .Property(x => x.AddressLine3)
          
            .Property(x => x.Country)
          
            .Property(x => x.PostCode)
           
            .Property(x => x.Comments)
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
            .Property(x => x.Active);

            IntegerProperty(x => x.Id)
                .IsHidden();

            IntegerProperty(x => x.ContactId)
                .IsHidden();


           
            StringProperty(x => x.FirstName)
                .IsFreeFormat()
                .PersonalData(p => p
                .Searchable()
                .IncludeInReport()
                .IncludeInErasure()
                .IncludeInErasure(PersonalDataErasureRule.Obfuscate)
                   );
            StringProperty(x => x.MiddleName)
                 .IsFreeFormat()
                .PersonalData(p => p
                 .Searchable()
                .IncludeInReport()
                .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Obfuscate)
                   );
            StringProperty(x => x.LastName)
                 .IsFreeFormat()
                .PersonalData(p => p
                 .Searchable()
                .IncludeInReport()
                .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Obfuscate)
                   );
            StringProperty(x => x.Suffix)
                 .IsFreeFormat()
                .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.Title)
                 .IsFreeFormat()
                .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.NickName)
                 .IsFreeFormat()
                .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.Department)
                 .IsFreeFormat()
                .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInErasureWithValue(string.Empty)
                   );
            StringProperty(x => x.URL)
                 .IsFreeFormat()
                .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );

            StringProperty(x => x.AddressLine1).IsFreeFormat()
                .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                      .IncludeInErasureWithValue(string.Empty)
                   );
            StringProperty(x => x.AddressLine2)
                 .IsFreeFormat()
                .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.AddressLine3)
                .IsFreeFormat()
                .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            IntegerProperty(x => x.CityId)
                .IsHidden()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInErasureWithValue(0)
                   );
            StringProperty(x => x.Country)
                .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                    .IncludeInErasureWithValue(string.Empty)
                   );
            IntegerProperty(x => x.StateId)
                 .IsHidden()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                     .IncludeInErasureWithValue(0)
                   );
            StringProperty(x => x.PostCode)
                 .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                      .IncludeInErasureWithValue(string.Empty)
                    .IncludeInReport()
                    
                   );
            IntegerProperty(x => x.CountryId)
                .IsHidden()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                     .IncludeInErasureWithValue(0)
                   );
            StringProperty(x => x.Comments)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );

            StringProperty(x => x.Email1)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                     .IncludeInErasureWithValue(string.Empty)
                   );
            StringProperty(x => x.Email2)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.PhoneMain)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                      .IncludeInErasureWithValue(string.Empty)
                   );
            StringProperty(x => x.PhoneOffice)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.PhoneMobile)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.PhoneHome)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.PhoneFax)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.PhonePager)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.PhoneTelex)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );
            StringProperty(x => x.PhoneTelexAnswerBack)
                  .IsFreeFormat()
                 .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );

            BooleanProperty(x => x.Active)
                  .PersonalData(p => p
                 .IncludeInErasure()
                    .IncludeInErasure(PersonalDataErasureRule.Blank)
                   );


        }
    }
}
