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
    public class ReportContact2RecordType : ChangeableRecordType<ReportContact2, string, ReportContact2BatchValidator>
    {
        public override void ConfigureMapper()
        {
            Mapper.CreateMap<ReportContact2, ReportContact2>();
        }

        public override Expression<Func<ReportContact2, bool>> GetIdentityPredicate(ReportContact2 item)
        {
            return x => x.ContactId == item.ContactId && x.ContactDetailId == item.ContactDetailId;
        }

        public override Expression<Func<ReportContact2, bool>> GetIdentityPredicate(string id)
        {
            var identityValues = TypeMetadataInternal.GetIdentityValues(id);
            var lat = decimal.Parse(identityValues[0]);
            var lng = decimal.Parse(identityValues[1]);
            return x => x.ContactDetailId == lng && x.ContactId == lat;
        }

        public override void PopulateId(ReportContact2 item)
        {
            item.Id = String.Format("{0:00.0000000000};{1:00.0000000000}", item.ContactId, item.ContactDetailId);
        }
    }
}
