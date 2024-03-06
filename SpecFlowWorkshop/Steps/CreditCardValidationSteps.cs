using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Workshop.BaseClasses;
using Workshop.ComponentHelper;
using Workshop.Configuration;

namespace SpecFlow.Steps;

[Binding]
public class CreditCardValidationSteps
{
    private readonly ConfigReader _config = new ConfigReader();

    private IWebElement _creditCardNumber { get; set; }
    
    private IWebElement _expirationDate { get; set; }
    
    private IWebElement _cvc { get; set; }
    
    [Given(@"user fills the three inputs")]
    public void GivenUserFillsTheThreeInputs()
    {
        _creditCardNumber = GenericHelper.GetElement(By.Id("creditCardNumber"));
        _expirationDate = GenericHelper.GetElement(By.Id("expirationDate"));
        _cvc = GenericHelper.GetElement(By.Id("cvc"));
        
        _creditCardNumber.SendKeys(_config.GetCreditCardNumber());
        _expirationDate.SendKeys(_config.GetExpirationDate());
        _cvc.SendKeys(_config.GetCVC());
    }

    [Given(@"credit card number is sixteen digits long")]
    public void GivenCreditCardNumberIsSixteenDigitsLong()
    {
        Assert.AreEqual(16, _creditCardNumber.GetAttribute("value").Length);
    }

    [Given(@"expiration date is at format MM/YYYY")]
    public void GivenExpirationDateIsAtFormatMmyyyy()
    {
        string expirationDate = _expirationDate.GetAttribute("value");
        
        Assert.AreEqual(expirationDate.Length, 7);
        Assert.AreEqual(expirationDate.Substring(2, 1), "/");
        Assert.IsTrue(int.TryParse(expirationDate.Substring(0, 2), out int month));
        Assert.IsTrue(int.TryParse(expirationDate.Substring(3, 4), out int year));
        Assert.IsTrue(month >= 1 && month <= 12);
        Assert.IsTrue(year >= 2024 && year <= 2099);
    }

    [Given(@"cvc is three digits long")]
    public void GivenCvcIsThreeDigitsLong()
    {
        string cvcValue = _cvc.GetAttribute("value");

        Assert.AreEqual(3, cvcValue.Length);
        Assert.IsTrue(cvcValue.All(char.IsDigit));
    }

    [When(@"submit button is pressed")]
    public void WhenSubmitButtonIsPressed()
    {
        GenericHelper.GetElement(By.Id("submitCard")).Click();
    }

    [Then(@"user is on page paymentConfirmed")]
    public void ThenUserIsOnPagePaymentConfirmed()
    {
        Assert.IsTrue(CurrentPageIs("Paiement confirmé"));
    }

    [Given(@"credit card number is not sixteen digits long")]
    public void GivenCreditCardNumberIsNotSixteenDigitsLong()
    {
        _creditCardNumber.Clear();
        _creditCardNumber.SendKeys("1234");
    }

    [Then(@"user is on homePage")]
    public void ThenUserIsOnHomePage()
    {
        Assert.IsTrue(CurrentPageIs("Page Workshop Card Validator"));
    }

    [Given(@"expiration date is not at format MM/YYYY")]
    public void GivenExpirationDateIsNotAtFormatMmyyyy()
    {
        _expirationDate.SendKeys("invalidDate");
    }

    [Given(@"cvc is not three digits long")]
    public void GivenCvcIsNotThreeDigitsLong()
    {
        _cvc.SendKeys("01");
    }
    
    private bool CurrentPageIs(string pageName)
    {
        return PageHelper.GetPageTitle().Contains(pageName);
    }
}