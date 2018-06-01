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
    public class ReportUser1BatchValidator : BatchValidator<long, ReportUser1>
    {
        protected override void SetupValidators(ChangeSetItems<long, ReportUser1> items)
        {
            validator = new EmptyValidator<ReportUser1>();
            deletionValidator = new EmptyValidator<ReportUser1>();
        }
    }
}
