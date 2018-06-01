using BCR.Domain.Models;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.Mappings
{
    public class ReportUser2Map : ClassMapping<ReportUser2>
    {
        public ReportUser2Map()
        {
            Table("ReportUser2");
            Id(x => x.Id, m => m.Column("lApplicationUserId"));
            Property(x => x.LoginId, m => m.Column("sLoginId"));
            Property(x => x.Name, m => m.Column("sName"));
            Property(x => x.LastName , m => m.Column("sLastName"));
            Property(x => x.FirstName, m => m.Column("sFirstName"));
            Property(x => x.EmailAddress, m => m.Column("sEmailAddress"));
            Property(x => x.Telephone, m => m.Column("sTelephone"));
           Property(x => x.Active, m => m.Column("sActive"));
           
        }
    }
}
