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
 
    public class ReportUser2RecordType : ChangeableRecordType<ReportUser2, long, ReportUser2BatchValidator>
    {
        public override void ConfigureMapper()
        {
            Mapper.CreateMap<ReportUser2, ReportUser2>();
        }
    }
}
