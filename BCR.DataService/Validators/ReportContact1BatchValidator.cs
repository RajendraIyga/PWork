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
    public class ReportContact1BatchValidator : BatchValidator<string, ReportContact1>
    {
        protected override void SetupValidators(ChangeSetItems<string, ReportContact1> items)
        {
            validator = new EmptyValidator<ReportContact1>();
            deletionValidator = new EmptyValidator<ReportContact1>();
        }
    }
}
