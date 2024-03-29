﻿using BCR.Domain.Models;
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
    public class ReportContact2BatchValidator : BatchValidator<string, ReportContact2>
    {
        protected override void SetupValidators(ChangeSetItems<string, ReportContact2> items)
        {
            validator = new EmptyValidator<ReportContact2>();
            deletionValidator = new EmptyValidator<ReportContact2>();
        }
    }
}
