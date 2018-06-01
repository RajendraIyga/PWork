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
    public class ReportPartyContact2BatchValidator : BatchValidator<long, ReportPartyContact2>
    {
        protected override void SetupValidators(ChangeSetItems<long, ReportPartyContact2> items)
        {
            validator = new EmptyValidator<ReportPartyContact2>();
            deletionValidator = new EmptyValidator<ReportPartyContact2>();
        }
    }
}
