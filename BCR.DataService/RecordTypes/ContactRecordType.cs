using AutoMapper;
using BCR.DataService.Validators;
using BCR.Domain.Models;
using BWF.DataServices.Core.Abstract;
using BWF.DataServices.Support.NHibernate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.RecordTypes
{
    public class ContactRecordType : ChangeableRecordType<Contact, long, ContactBatchValidator>
    {
        public override void ConfigureMapper()
        {
            Mapper.CreateMap<Contact, Contact>();
        }
    }
}
