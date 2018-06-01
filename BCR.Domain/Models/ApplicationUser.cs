using BWF.DataServices.Metadata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.Domain.Models
{
    public class ApplicationUser: IHaveId<long>
    {
        public virtual long Id { get; set; }
        public virtual string  LoginId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Initials { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string Telephone { get; set; }
        public virtual string RoutingEMailAddress { get; set; }

        public virtual bool Active { get; set; }
    }
}
