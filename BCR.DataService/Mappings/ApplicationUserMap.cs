using BCR.Domain.Models;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.Mappings
{
    public class ApplicationUserMap : ClassMapping<ApplicationUser>
    {
        public ApplicationUserMap()
        {
            Id(x => x.Id, m=> m.Column("lApplicationUserId"));
            Property(x => x.Firstname, m => m.Column("sFirstname"));
            Property(x => x.LoginId, m => m.Column("sLoginId"));
            Property(x => x.EmailAddress, m => m.Column("sEmailAddress"));
            Property(x => x.RoutingEMailAddress, m => m.Column("sRoutingEMailAddress"));
            Property(x => x.Initials, m => m.Column("sInitials"));
            Property(x => x.Telephone, m => m.Column("sTelephone"));
            Property(x => x.UserName, m => m.Column("sUserName"));
            Property(x => x.Lastname, m => m.Column("sLastname"));
            Property(x => x.Active, m => m.Column("bActive"));
            Table("ApplicationUser");
        }
    }
}
