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
    public class ReportContactDetail2RecordType : ChangeableRecordType<ReportContactDetail2, string, ReportContactDetail2BatchValidator>
    {
        public override void ConfigureMapper()
        {
            Mapper.CreateMap<ReportContactDetail2, ReportContactDetail2>();
        }

        public override Expression<Func<ReportContactDetail2, bool>> GetIdentityPredicate(ReportContactDetail2 item)
        {
            return x => x.ContactId == item.ContactId && x.PartyId == item.PartyId;
        }

        public override Expression<Func<ReportContactDetail2, bool>> GetIdentityPredicate(string id)
        {
            var identityValues = TypeMetadataInternal.GetIdentityValues(id);
            var cid = decimal.Parse(identityValues[0]);
            var pid = decimal.Parse(identityValues[1]);
            return x => x.PartyId == pid && x.ContactId == cid;
        }

        public override void PopulateId(ReportContactDetail2 item)
        {
            item.Id = String.Format("{0:00.0000000000};{1:00.0000000000}", item.ContactId, item.PartyId);
        }
    }
}
