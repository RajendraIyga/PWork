using AutoMapper;
using BCR.DataService.Validators;
using BCR.Domain.Models;
using BWF.DataServices.Metadata.Attributes.Actions;
using BWF.DataServices.Support.NHibernate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.RecordTypes
{

    public class ReportUser1RecordType : ChangeableRecordType<ReportUser1, long, ReportUser1BatchValidator>
    {
        public override void ConfigureMapper()
        {
            Mapper.CreateMap<ReportUser1, ReportUser1>();
        }
    }
}
