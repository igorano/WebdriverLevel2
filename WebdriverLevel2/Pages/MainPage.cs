// <copyright file="MainPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace WebdriverLevel2.Pages
{
    using OpenQA.Selenium;

    public class MainPage : BaseEshopPage
    {
        public MainPage(IWebDriver driver)
            : base(driver)
        {
        }

        private IWebElement AddFalcon9 => this.Driver.FindElement(By.XPath("//a[@data-product_id='28' and contains(text(),'Add to cart')]"));

        private IWebElement ViewCartButton => this.Driver.FindElement(By.XPath("//a[@class='added_to_cart wc-forward']"));


        public void AddRocketToShoppingCart()
        {
            this.Driver.Navigate().GoToUrl(this.GetUrl());
            this.AddFalcon9.Click();
            this.wait.WaitForElementToExists(By.XPath("//a[@class='added_to_cart wc-forward']"));

            this.ViewCartButton.Click();
        }

        protected override string GetUrl()
        {
            return @"http://demos.bellatrix.solutions/";
        }
    }
}
