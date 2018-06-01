using AutoMapper;
using BCR.DataService.Validators;
using BCR.Domain.Models;
using BWF.DataServices.Core.Abstract;
using BWF.DataServices.Metadata.Attributes.Actions;
using BWF.DataServices.Support.NHibernate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.RecordTypes
{
   // [CreateAction("ApplicationUser")]
  //  [EditAction("ApplicationUser")]
  //  [DeleteAction("ApplicationUser")]
    public class ApplicationUserRecordType : ChangeableRecordType<ApplicationUser, long, ApplicationUserBatchValidator>
    {
       
        public override void ConfigureMapper()
        {
            Mapper.CreateMap<ApplicationUser, ApplicationUser>();
        }
    }
}
