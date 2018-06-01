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
    public class ApplicationUserBatchValidator : BatchValidator<long, ApplicationUser>
    {
        protected override void SetupValidators(ChangeSetItems<long, ApplicationUser> items)
        {
            validator = new EmptyValidator<ApplicationUser>();
            deletionValidator = new EmptyValidator<ApplicationUser>();
        }
    }
}
