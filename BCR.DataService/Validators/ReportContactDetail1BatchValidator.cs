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
    public class ReportContactDetail1BatchValidator : BatchValidator<string, ReportContactDetail1>
    {
        protected override void SetupValidators(ChangeSetItems<string, ReportContactDetail1> items)
        {
            validator = new EmptyValidator<ReportContactDetail1>();
            deletionValidator = new EmptyValidator<ReportContactDetail1>();
        }
    }
}
