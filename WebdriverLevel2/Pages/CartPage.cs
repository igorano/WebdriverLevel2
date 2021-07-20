// <copyright file="CartPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebdriverLevel2.Pages
{
    using OpenQA.Selenium;

    public class CartPage : BaseEshopPage
    {
        public CartPage(IWebDriver driver)
            : base(driver)
        {
        }

        protected override string GetUrl()
        {
            return @"http://demos.bellatrix.solutions/cart/";
        }

        private IWebElement ProceedToCheckOut => this.Driver.FindElement(By.LinkText("Proceed to checkout"));

        public void ClickProceedToCheckout()
        {
            this.ProceedToCheckOut.Click();
        }
    }
}
