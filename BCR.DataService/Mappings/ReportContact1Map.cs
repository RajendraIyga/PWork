using BCR.Domain.Models;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.Mappings
{
    public class ReportContact1Map : ClassMapping<ReportContact1>
    {
        public ReportContact1Map()
        {
            Table("ReportContact1");
            
            ComposedId(map =>
            {
                map.Property(x => x.ContactId, m => m.Column("lContactId"));
                map.Property(x => x.ContactDetailId, m => m.Column("lContactDetailId"));
            });

            Property(x => x.Id, m =>
            {
                m.Formula("CONCAT(CONCAT(lContactId,';'),lContactDetailId)");
                m.Insert(false);
                m.Update(false);
            });
            Property(x => x.Contact, m => m.Column("sContact"));
          
            Property(x => x.Description, m => m.Column("sDescription"));
            Property(x => x.ApplicationUser, m => m.Column("sApplicationUser"));
            Property(x => x.ISActive, m => m.Column("sISActive"));
            
            Property(x => x.ContactSalutation, m => m.Column("sContactSalutation"));
            Property(x => x.FirstName, m => m.Column("sFirstName"));
            Property(x => x.MiddleName, m => m.Column("sMiddleName"));
            Property(x => x.LastName, m => m.Column("sLastName"));
            Property(x => x.Suffix, m => m.Column("sSuffix"));
            Property(x => x.Title, m => m.Column("sTitle"));
            Property(x => x.NickName, m => m.Column("sNickName"));
       
            Property(x => x.AddressLine1, m => m.Column("sAddressLine1"));
            Property(x => x.AddressLine2, m => m.Column("sAddressLine2"));
            Property(x => x.AddressLine3, m => m.Column("sAddressLine3"));
      
            Property(x => x.Email1, m => m.Column("sEmail1"));
            Property(x => x.Email2, m => m.Column("sEmail2"));
            Property(x => x.PhoneMain, m => m.Column("sPhoneMain"));
            Property(x => x.PhoneOffice, m => m.Column("sPhoneOffice"));
            Property(x => x.PhoneMobile, m => m.Column("sPhoneMobile"));
            Property(x => x.PhoneHome, m => m.Column("sPhoneHome"));
            Property(x => x.PhoneFax, m => m.Column("sPhoneFax"));
            Property(x => x.PhonePager, m => m.Column("sPhonePager"));
            Property(x => x.PhoneTelex, m => m.Column("sPhoneTelex"));
            Property(x => x.PhoneTelexAnswerBack, m => m.Column("sPhoneTelexAnswerBack"));
          

        }
    }
}
