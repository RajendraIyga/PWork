using BWF.DataServices.StartUp.Concrete;
using BWF.Explorer.StartUp.Concrete;
using BWF.Explorer.StartUp.Interfaces;
using BWF.Globalisation.Concrete;
using BWF.Globalisation.Interfaces;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCR.ExplorerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            var hostUrl = ConfigurationManager.AppSettings["ExplorerHostUrl"];

            var availableLanguageCultures = new List<string> { "en-GB" };
            var availableFormattingCultures = new List<FormattingCulture>
    {
        new FormattingCulture ("en-GB", new List<string>
        {
            "dd/MM/yyyy HH:mm",
            "dd MMMM yyyy HH:mm:ss",
            "dd/MM/yyyy HH:mm:ss",
            "dd-MM-yyyy HH:mm:ss",
            "dd-MMM-yyyy HH:mm:ss",
            "dd MMM yyyy HH:mm:ss"
        },
        new List<string>
        {
            "dd/MM/yyyy",
            "dd MMMM yyyy",
            "dd MMMM",
            "MMMM yyyy",
            "dd-MM-yyyy",
            "dd-MMM-yyyy",
            "dd MMM yyyy"
        })
    };

            IResourceQuerier resourceQuerier = new ResourceQuerier(typeof(BWF.Globalisation.Resources).Assembly);
            var globalisationProvider = new GlobalisationProvider(resourceQuerier, availableLanguageCultures, availableFormattingCultures);

            IExplorerHostSettings explorerHostSettings =
                new ExplorerHostSettings(
                    "BwfBCRExplorerHost", // service name
                    "BWF BCR Explorer Host Service", // service display name
                    "Brady Credit Risk Host for the BWF", // service description
                    hostUrl,
                    globalisationProvider);

            var explorerHost = new BWF.Explorer.StartUp.Concrete.ExplorerHost(explorerHostSettings);
            explorerHost.Start();
        }
    }
}
