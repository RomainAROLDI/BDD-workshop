using Workshop.BaseClasses;
using Workshop.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Workshop.Tests.FindElements
{
    [TestClass]
    public class FindElementTests
    {
        [TestMethod]
        public void GetElementTests()
        {
            try
            {
                ObjectRepository.Driver.FindElement(By.LinkText("Blog"));
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void GetElementsTests()
        {
            try
            {
                ReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.TagName("input"));
                Console.WriteLine(elements.Count);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        [Ignore]
        public void GetElementFromGenericHelper()
        {
            Assert.IsNotNull(GenericHelper.GetElement(By.LinkText("Blog")));
        }

        [TestMethod]
        [Ignore]
        public void IsElementPresentOnce()
        {
            Assert.IsTrue(ObjectRepository.Driver.FindElements(By.LinkText("Blog")).Count == 1);
        }

        [TestMethod]
        [Ignore]
        public void IsElementPresentOnceFromGenericHelper()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.LinkText("Blog")));
        }
    }
}
