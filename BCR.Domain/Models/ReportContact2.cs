using BWF.DataServices.Metadata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.Domain.Models
{
    public class ReportContact2 : IHaveCompositeId, IEquatable<ReportContact2>
    {
        public virtual long ContactId { get; set; }
        public virtual string Id { get; set; }

        public virtual long ContactDetailId { get; set; }
        public virtual string Contact { get; set; }

        public virtual string Description { get; set; }
        public virtual string ApplicationUser { get; set; }
        public virtual string ISActive { get; set; }

        public virtual string ContactSalutation { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string Title { get; set; }
        public virtual string NickName { get; set; }


        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string AddressLine3 { get; set; }

        public virtual string Email1 { get; set; }
        public virtual string Email2 { get; set; }
        public virtual string PhoneMain { get; set; }
        public virtual string PhoneOffice { get; set; }
        public virtual string PhoneMobile { get; set; }
        public virtual string PhoneHome { get; set; }
        public virtual string PhoneFax { get; set; }
        public virtual string PhonePager { get; set; }
        public virtual string PhoneTelex { get; set; }
        public virtual string PhoneTelexAnswerBack { get; set; }


        public override int GetHashCode()
        {
            unchecked
            {
                return ContactId.GetHashCode() * 27 * ContactDetailId.GetHashCode();
            }
        }

        public virtual bool Equals(ReportContact2 other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.ContactId == other.ContactId && this.ContactDetailId == other.ContactDetailId;
        }

        public override bool Equals(object obj)
        {
            var wp = obj as ReportContact2;
            return wp == null
                ? false
                : Equals(wp);
        }

    }
}
