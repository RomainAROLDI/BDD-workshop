using Workshop.BaseClasses;
using Workshop.ComponentHelper;
using Workshop.Configuration;
using Workshop.Settings;

namespace SpecFlow.Hooks
{
    [Binding]
    public class InitScenarioHook
    {
        [BeforeScenario]
        public static void InitScenario()
        {
            ObjectRepository.Config = new ConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = BaseClass.GetChromeWebDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.Driver = BaseClass.GetFirefoxWebDriver();
                    break;

                case BrowserType.InternetExplorer:
                    ObjectRepository.Driver = BaseClass.GetInternetExplorerWebDriver();
                    break;
            }

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite() + "/Workshop.html");
        }

        [AfterScenario]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}