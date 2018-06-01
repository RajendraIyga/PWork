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
    public class ApplicationUserMetadata : TypeMetadataProvider<ApplicationUser>
    {
        public ApplicationUserMetadata()
        {
            AutoUpdatesByDefault();

            ViewDefaults()
            .Property(x => x.LoginId)
            .Property(x => x.UserName)
            .Property(x => x.Firstname)
            .Property(x => x.Lastname)
            .Property(x => x.EmailAddress)
            .Property(x => x.RoutingEMailAddress)
            .Property(x => x.Telephone)
            .Property(x => x.Initials)
            .Property(x => x.Active);

            IntegerProperty(x => x.Id)
                .IsId()
                .IsHidden();

            StringProperty(x => x.LoginId)
               .DisplayName("LoginId")
                  .IsFreeFormat()
                 .PersonalData(p => p
                .Searchable()
                .IncludeInReport()
                .IncludeInErasure(PersonalDataErasureRule.Obfuscate));

            StringProperty(x => x.UserName)
              .DisplayName("sUserName")
                 .IsFreeFormat()
                .PersonalData(p => p
               .Searchable()
               .IncludeInReport()
               .IncludeInErasure(PersonalDataErasureRule.Obfuscate));

            StringProperty(x => x.Firstname)
                 .DisplayName("Firstname")
                .IsFreeFormat()
                 .PersonalData(p => p
                .Searchable()
                .IncludeInReport()
                .IncludeInErasure(PersonalDataErasureRule.Blank));

            StringProperty(x => x.Lastname)
                 .DisplayName("Lastname")
                .IsFreeFormat()
                .PersonalData(p => p
                .Searchable()
                .IncludeInReport()
                .IncludeInErasure(PersonalDataErasureRule.Blank));

            StringProperty(x => x.RoutingEMailAddress)
                .DisplayName("RoutingEMailAddress")
                .IsFreeFormat()
                 .PersonalData(p => p
                .IncludeInReport()
                .IncludeInErasure(PersonalDataErasureRule.Blank));

            StringProperty(x => x.EmailAddress)
               .DisplayName("EmailAddress")
               .IsFreeFormat()
                .PersonalData(p => p
                .IncludeInReport()
                .IncludeInErasure(PersonalDataErasureRule.Blank));

            StringProperty(x => x.Initials)
              .DisplayName("Initials")
              .IsFreeFormat()
              .IsHidden()
            .PersonalData(p => p
            .IncludeInReport()
            .IncludeInErasure(PersonalDataErasureRule.Blank));

            StringProperty(x => x.Telephone)
             .DisplayName("Telephone")
             .IsFreeFormat()
             .IsHidden()
           .PersonalData(p => p
           .IncludeInReport()
           .IncludeInErasure(PersonalDataErasureRule.Blank));

            BooleanProperty(x => x.Active)
                .DisplayName("Is Active")
                .IsHidden()
                .PersonalData(p => p
                .IncludeInReport()
                .IncludeInErasure(PersonalDataErasureRule.Blank));
        }
    }
}
