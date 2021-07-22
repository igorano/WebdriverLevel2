// <copyright file="CheckoutPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebdriverLevel2.Pages
{
    using OpenQA.Selenium;

    public class CheckoutPage : BaseEshopPage
    {
        public CheckoutPage(IWebDriver driver)
            : base(driver)
        {
        }

        protected override string GetUrl()
        {
            return @"http://demos.bellatrix.solutions/checkout/";
        }

        private IWebElement FirstName => this.Driver.FindElement(By.Id("billing_first_name"));

        private IWebElement LastName => this.Driver.FindElement(By.Id("billing_last_name"));

        private IWebElement StreetAddress => this.Driver.FindElement(By.Id("billing_address_1"));

        private IWebElement City => this.Driver.FindElement(By.Id("billing_city"));

        private IWebElement PostCode => this.Driver.FindElement(By.Id("billing_postcode"));

        private IWebElement PhoneNumber => this.Driver.FindElement(By.Id("billing_phone"));

        private IWebElement Email => this.Driver.FindElement(By.Id("billing_email"));

        private IWebElement PlaceOrderElement => this.Driver.FindElement(By.Id("place_order"));

        public void PlaceOrder(string firstName, string lastName, string streetAddress, string city, string postCode, string phoneNumber, string email)
        {
            this.FirstName.SendKeys(firstName);
            this.LastName.SendKeys(lastName);
            this.StreetAddress.SendKeys(streetAddress);
            this.City.SendKeys(city);
            this.PostCode.SendKeys(postCode);
            this.PhoneNumber.SendKeys(phoneNumber);
            this.Email.SendKeys(email);
            this.wait.WaitForDocumentReady();
            this.PlaceOrderElement.Click();
        }
    }
}
