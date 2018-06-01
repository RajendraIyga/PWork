using BWF.DataServices.Metadata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.Domain.Models
{
    public class ContactDetail : IHaveId<long>
    {
        public virtual long Id { get; set; }

       public virtual long ContactId { get; set; }
                
        //public virtual long ContactSalutationId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string Title { get; set; }
        public virtual string NickName { get; set; }
        public virtual string Department { get; set; }
        public virtual string URL { get; set; }
        
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string AddressLine3 { get; set; }
       // public virtual long CityId { get; set; }
        public virtual string Country { get; set; }
       // public virtual long StateId { get; set; }
        public virtual string PostCode { get; set; }
      //  public virtual long CountryId { get; set; }
        public virtual string Comments { get; set; }
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
        public virtual bool Active { get; set; }


    }
}
