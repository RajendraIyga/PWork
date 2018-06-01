using BCR.DataService.Interfaces;
using BWF.DataServices.Core.Interfaces;
using BWF.DataServices.Support.NHibernate.Abstract;
using BWF.Globalisation.Interfaces;
using BWF.Hosting.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.Concrete
{
    public class BCRRepository:ConventionalDatabaseDataServiceRepository,
    IBCRRepository
{
    public BCRRepository(
            IHostConfiguration hostConfiguration,
            IGlobalisationProvider globalisationProvider,
            IAuthorisation authorisation,
            IMetadataProvider metadataProvider)
        : base(
            hostConfiguration,
            globalisationProvider,
            authorisation,
            new List<string>(),
            metadataProvider,
            "bcr", // the name of the data service
            "dbo") // the default database schema the tables for the domain objects are in
    {
    }
}
}
