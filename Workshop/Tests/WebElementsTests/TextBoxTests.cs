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
    public class TextBoxTests
    {
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        [Ignore]
        public void GetTextBoxValue_WithConfigUsername_ReturnsUsername()
        {
            //TextBoxHelper.TypeInTextBox(By.Id("login"), ObjectRepository.Config.GetUsername());
            //Assert.AreEqual(ObjectRepository.Config.GetUsername(), TextBoxHelper.GetTextBoxValue(By.Id("login")));
        }

        [TestMethod]
        [Ignore]
        public void TypeInTextBox_ForUsernameAndPassword_ReturnsRightValues()
        {
            //TextBoxHelper.TypeInTextBox(By.Id("login"), ObjectRepository.Config.GetUsername());
            //TextBoxHelper.TypeInTextBox(By.Id("password"), ObjectRepository.Config.GetPassword());
            //Assert.AreEqual(ObjectRepository.Config.GetUsername(), TextBoxHelper.GetTextBoxValue(By.Id("login")));
            //Assert.AreEqual(ObjectRepository.Config.GetPassword(), TextBoxHelper.GetTextBoxValue(By.Id("password")));
        }

        [TestMethod]
        [Ignore]
        public void ClearTextBox_WithInputFilled_EmptyTheTextBox()
        {
            //TextBoxHelper.TypeInTextBox(By.Id("login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.ClearTextBox(By.Id("login"));
            Assert.AreEqual(string.Empty, TextBoxHelper.GetTextBoxValue(By.Id("password")));
        }
    }
}
