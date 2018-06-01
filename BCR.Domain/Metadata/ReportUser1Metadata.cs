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
    public class ReportUser1Metadata : TypeMetadataProvider<ReportUser1>
    {
        public ReportUser1Metadata()
        {
            AutoUpdatesByDefault();

            ViewDefaults()
                .Property(x => x.LoginId)
                .Property(x => x.Name)
                .Property(x => x.LastName)
                .Property(x => x.FirstName)
                .Property(x => x.Active)
                .Property(x => x.EmailAddress)
                .Property(x => x.Telephone);

            IntegerProperty(x => x.Id)
                .IsId()
                .IsHidden();

            StringProperty(x=>x.LoginId)
                .DisplayName("LoginId")
                .IsFreeFormat()
                .PersonalData(p => p
                .Searchable()
                .IncludeInReport()
                .IncludeInErasure(PersonalDataErasureRule.Obfuscate));

            StringProperty(x => x.Name)
                .DisplayName("Name")
                .IsFreeFormat()
                .PersonalData(p => p
                .Searchable()
                .IncludeInReport()
                .IncludeInErasure(PersonalDataErasureRule.Obfuscate));

            StringProperty(x => x.FirstName)
               .DisplayName("FirstName")
               .IsFreeFormat()
               .PersonalData(p => p
               .Searchable()
               .IncludeInReport()
               .IncludeInErasure(PersonalDataErasureRule.Blank));

            StringProperty(x => x.LastName)
              .DisplayName("LastName")
              .IsFreeFormat()
              .PersonalData(p => p
              .Searchable()
              .IncludeInReport()
              .IncludeInErasure(PersonalDataErasureRule.Blank));

            StringProperty(x => x.Active)
              .DisplayName("Active")
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

            StringProperty(x => x.Telephone)
             .DisplayName("Telephone")
             .IsFreeFormat()
             .PersonalData(p => p
             .IncludeInReport()
             .IncludeInErasure(PersonalDataErasureRule.Blank));
        }
    }
}
