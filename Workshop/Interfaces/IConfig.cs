using Workshop.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Interfaces
{
    public interface IConfig
    {
        public BrowserType GetBrowser();
        public string GetCreditCardNumber();
        public string GetExpirationDate();
        public string GetCVC();
        public string GetWebsite();
    }
}
