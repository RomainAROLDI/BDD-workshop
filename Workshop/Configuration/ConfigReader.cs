using Workshop.CustomExceptions;
using Workshop.Interfaces;
using Workshop.Settings;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Configuration
{
    public class ConfigReader : IConfig
    {

        private WorkshopSettings settings;

        public ConfigReader()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(WorkshopSettings)).Get<WorkshopSettings>();
        }

        public BrowserType GetBrowser()
        {
            string browser = settings.Browser;

            try
            {
                return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
            }
            catch (ArgumentException)
            {
                throw new NoSuitableDriverFound("Aucun driver n'a été trouvé  : " + settings.Browser);
            }
        }

        public string GetCreditCardNumber()
        {
            return settings.CreditCardNumber;
        }

        public string GetExpirationDate()
        {
            return settings.ExpirationDate;
        }

        public string GetCVC()
        {
            return settings.CVC;
        }
        
        public string GetWebsite()
        {
            return settings.Website;
        }
    }
}
