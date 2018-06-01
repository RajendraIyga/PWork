using BCR.Domain.Models;
using BWF.DataServices.Core.Concrete.ChangeSets;
using BWF.DataServices.Support.NHibernate.Abstract;
using BWF.DataServices.Support.NHibernate.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.Validators
{
    public class ContactDetailBatchValidator : BatchValidator<long, ContactDetail>
    {
        protected override void SetupValidators(ChangeSetItems<long, ContactDetail> items)
        {
            validator = new EmptyValidator<ContactDetail>();
            deletionValidator = new EmptyValidator<ContactDetail>();
        }
    }
}
