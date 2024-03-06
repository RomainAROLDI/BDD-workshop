using Workshop.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.ComponentHelper
{
    public class PageHelper
    {
        public static string GetPageTitle()
        {
            return ObjectRepository.Driver.Title;
        }

        public static string GetPageUrl()
        {
            return ObjectRepository.Driver.Url;
        }
    }
}
