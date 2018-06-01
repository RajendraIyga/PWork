using AutoMapper;
using BCR.DataService.Validators;
using BCR.Domain.Models;
using BWF.DataServices.Support.NHibernate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.RecordTypes
{
    public class ReportPartyContact1RecordType : ChangeableRecordType<ReportPartyContact1, long, ReportPartyContact1BatchValidator>
    {
        public override void ConfigureMapper()
        {
            Mapper.CreateMap<ReportPartyContact1, ReportPartyContact1>();
        }
    }
}
