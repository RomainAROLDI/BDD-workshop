using Workshop.BaseClasses;
using Workshop.Configuration;
using Workshop.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Tests.ConfigTests
{
    [TestClass]
    public class ConfigTests
    {
        [TestMethod]
        public void GetConfigKeysFromConfigReader()
        {
            IConfig config = new ConfigReader();
            Console.WriteLine("Browser : " + config.GetBrowser());
            Console.WriteLine("CreditCardNumber : " + config.GetCreditCardNumber());
            Console.WriteLine("ExpirationDate : " + config.GetExpirationDate());
            Console.WriteLine("CVC : " + config.GetCVC());
            Console.WriteLine("Website : " + config.GetWebsite());
        }

        [TestMethod]
        public void GetConfigKeysFromObjectRepository()
        {
            Console.WriteLine("Browser : " + ObjectRepository.Config.GetBrowser());
            Console.WriteLine("CreditCardNumber : " + ObjectRepository.Config.GetCreditCardNumber());
            Console.WriteLine("ExpirationDate : " + ObjectRepository.Config.GetExpirationDate());
            Console.WriteLine("CVC : " + ObjectRepository.Config.GetCVC());
            Console.WriteLine("Website : " + ObjectRepository.Config.GetWebsite());
        }
    }
}
