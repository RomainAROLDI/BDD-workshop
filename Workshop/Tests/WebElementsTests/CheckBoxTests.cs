using Workshop.BaseClasses;
using Workshop.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Tests.WebElementsTests
{
    [TestClass]
    public class CheckBoxTests
    {
        [TestMethod]
        [Ignore]
        public void CheckCheckBox_UncheckedCheckBoxThenCheckIt_ReturnsOppositeCheckedBoxResult()
        {
            NavigationHelper.NavigateToHomePage();
            LinkHelper.ClickLink(By.LinkText("New User"));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("mail_activation")));
            var actualCheckedBoxValue = CheckBoxHelper.IsCheckBoxChecked(By.Id("mail_activation"));
            CheckBoxHelper.CheckCheckBox(By.Id("mail_activation"));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("mail_activation")));
            var newCheckedBoxValue = CheckBoxHelper.IsCheckBoxChecked(By.Id("mail_activation"));

            Assert.AreEqual(newCheckedBoxValue, !actualCheckedBoxValue);
        }
    }
}
