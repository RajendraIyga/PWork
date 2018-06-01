using BCR.DataService.Interfaces;
using BWF.DataServices.Core.Abstract;
using BWF.DataServices.Core.Interfaces;
using BWF.DataServices.Core.Menu;
using BWF.DataServices.Support.NHibernate.Abstract;
using BWF.Globalisation.Interfaces;
using BWF.Hosting.Infrastructure.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.DataService.Concrete
{
    public class BCRDataService :
    ConventionalDatabaseDataService<BCRDataService>
    {
        public BCRDataService(
                IHostConfiguration hostConfiguration,
                IEnumerable<IRecordType> recordTypes,
                IGlobalisationProvider globalisationProvider,
                IAuthorisation authorisation,
                IMetadataProvider metadataProvider,
                IBCRRepository ibcrRepository,
                IDatabaseStreamingQueryExecutor databaseStreamingQueryExecutor)
            : base(
                "bcr", // the name of the data service
                globalisationProvider,
                ibcrRepository as DatabaseDataServiceRepository,
                recordTypes,
                metadataProvider,
                databaseStreamingQueryExecutor)
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;
        }

        public override IEnumerable<MenuItem> GetCustomMenus()
        {
            var menuList = new List<MenuItem>();
            var typesMenu = new MenuItem
            {
                Id = "types",
                Text = "Types",
                Items = new List<MenuItem>
        {
            new MenuItem
            {
                Id = "contact",
                Text = "Contacts",
                Link = "{{appSetting-ExplorerHostUrl}}/View/#default/BCR/Contact"
            }
            //,
            // new MenuItem
            //{
            //    Id = "applicationuser",
            //    Text = "ApplicationUser",
            //    Link = "{{appSetting-ExplorerHostUrl}}/View/#default/BCR/ApplicationUser"
            //}

        }
            };
            menuList.Add(typesMenu);
            return menuList;
        }
    }
}
