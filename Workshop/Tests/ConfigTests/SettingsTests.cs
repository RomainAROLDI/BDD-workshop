using Workshop.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Tests.ConfigTests
{
    [TestClass]
    public class SettingsTests
    {
        private WorkshopSettings settings;

        [TestInitialize]
        public void Init()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(WorkshopSettings)).Get<WorkshopSettings>();
        }

        [TestMethod]
        public void GetBrowserFromConfig()
        {
            Console.WriteLine($"Browser = { settings.Browser }");
        }

        [TestMethod]
        public void GetCreditCardNumberFromConfig()
        {
            Console.WriteLine($"Password = { settings.CreditCardNumber }");
        }
        
        [TestMethod]
        public void GetCVCFromConfig()
        {
            Console.WriteLine($"CVC = { settings.CVC }");
        }

        [TestMethod]
        public void GetExpirationDateFromConfig()
        {
            Console.WriteLine($"Password = { settings.ExpirationDate }");
        }

        [TestMethod]
        public void GetWebsiteFromConfig()
        {
            Console.WriteLine($"Website = { settings.Website }");
        }
    }
}
