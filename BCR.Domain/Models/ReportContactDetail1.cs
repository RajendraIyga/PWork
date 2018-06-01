using BWF.DataServices.Metadata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.Domain.Models
{
    public class ReportContactDetail1: IHaveCompositeId, IEquatable<ReportContactDetail1>
    {
        public virtual string Id { get; set; }
        public virtual long PartyId { get; set; }
        public virtual long ContactId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string URL { get; set; }
        public virtual string NickName { get; set; }
        public virtual string AddressLine2 { get; set; }
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
        public virtual string PostCode { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                return ContactId.GetHashCode() * 27 * PartyId.GetHashCode();
            }
        }

        public virtual bool Equals(ReportContactDetail1 other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.ContactId == other.ContactId && this.PartyId == other.PartyId;
        }

        public override bool Equals(object obj)
        {
            var wp = obj as ReportContactDetail1;
            return wp == null
                ? false
                : Equals(wp);
        }
    }
}
