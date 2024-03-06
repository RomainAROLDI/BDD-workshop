using Workshop.BaseClasses;
using Workshop.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Tests.PageNavigationTests
{
    [TestClass]
    public class PageNavigationTests
    {
        [TestMethod]
        public void OpenPageFromDriver()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }

        [TestMethod]
        public void OpenPageFromObjectRepository()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

        [TestMethod]
        public void OpenPageFromObjectRepositoryAndGetTitle()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine(ObjectRepository.Driver.Title);
        }

        [TestMethod]
        public void OpenPageFromObjectRepositoryAndGetTitleFromPageHelper()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine(PageHelper.GetPageTitle());
        }

        [TestMethod]
        [Ignore]
        public void ClickOnLoginFromButtonHelperAndCheckPageTitleTest()
        {
            NavigationHelper.NavigateToHomePage();
            //TextBoxHelper.TypeInTextBox(By.Id("login"), ObjectRepository.Config.GetUsername());
            //TextBoxHelper.TypeInTextBox(By.Id("password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Name("form"));
            Assert.AreEqual("bWAPP - Portal", PageHelper.GetPageTitle());
            NavigationHelper.NavigateToUrl("http://127.0.0.1/logout.php");
        }

        [TestMethod]
        [Ignore]
        public void ClickOnLoginFromButtonHelperAndCheckPageUrlTest()
        {
            NavigationHelper.NavigateToHomePage();
            //TextBoxHelper.TypeInTextBox(By.Id("login"), ObjectRepository.Config.GetUsername());
            //TextBoxHelper.TypeInTextBox(By.Id("password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Name("form"));
            Assert.AreEqual("http://127.0.0.1/portal.php", PageHelper.GetPageUrl());
            NavigationHelper.NavigateToUrl("http://127.0.0.1/logout.php");
        }
    }
}
