using BCR.Domain.Metadata;
using BWF.DataServices.Metadata.Fluent.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.Concrete
{
    public class BCRMetadataBundle : TypeMetadataBundle
    {
        public BCRMetadataBundle()
        : base("bcr",
            new ContactMetadata(),
            new  ApplicationUserMetadata(),
            new ReportUser1Metadata(),
            new ReportUser2Metadata(),
            new ContactDetailMeatadata(),
            new ReportContact1Metadata(),
            new ReportContact2Metadata(),
            new ReportPartyContact1Metadeta()
             ,new ReportPartyContact2Metadeta()
             ,new ReportContactDetail1Metadata()
               , new ReportContactDetail2Metadata())
        {

        }

    }
}
