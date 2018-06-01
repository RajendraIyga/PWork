using AutoMapper;
using BCR.DataService.Validators;
using BCR.Domain.Models;
using BWF.DataServices.Metadata;
using BWF.DataServices.Support.NHibernate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.RecordTypes
{
    public class ReportContactDetail1RecordType : ChangeableRecordType<ReportContactDetail1, string, ReportContactDetail1BatchValidator>
    {
        public override void ConfigureMapper()
        {
            Mapper.CreateMap<ReportContactDetail1, ReportContactDetail1>();
        }

        public override Expression<Func<ReportContactDetail1, bool>> GetIdentityPredicate(ReportContactDetail1 item)
        {
            return x => x.ContactId == item.ContactId && x.PartyId == item.PartyId;
        }

        public override Expression<Func<ReportContactDetail1, bool>> GetIdentityPredicate(string id)
        {
            var identityValues = TypeMetadataInternal.GetIdentityValues(id);
            var cid = decimal.Parse(identityValues[0]);
            var pid = decimal.Parse(identityValues[1]);
            return x => x.PartyId == pid && x.ContactId == cid;
        }

        public override void PopulateId(ReportContactDetail1 item)
        {
            item.Id = String.Format("{0:00.0000000000};{1:00.0000000000}", item.ContactId, item.PartyId);
        }
    }
}
