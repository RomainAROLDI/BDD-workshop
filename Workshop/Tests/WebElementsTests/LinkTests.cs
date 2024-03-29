﻿using Workshop.BaseClasses;
using Workshop.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Tests.WebElementsTests
{
    [TestClass]
    public class HyperLinkTests
    {
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        [Ignore]
        public void ClickOnElement_FromLinkText_RightPageIsAccessed()
        {
            IWebElement element = GenericHelper.GetElement(By.LinkText("New User"));
            element.Click();
            Assert.AreEqual("bWAPP - New User", PageHelper.GetPageTitle());
        }

        [TestMethod]
        [Ignore]
        public void ClickLink_FromLinkHelper_RightPageIsAccessed()
        {
            LinkHelper.ClickLink(By.LinkText("New User"));
            Assert.AreEqual("bWAPP - New User", PageHelper.GetPageTitle());
        }
    }
}
