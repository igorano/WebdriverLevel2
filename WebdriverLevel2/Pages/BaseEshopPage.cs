// <copyright file="BaseEshopPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebdriverLevel2.Pages
{
    using OpenQA.Selenium;

    public abstract class BaseEshopPage
    {
        protected readonly IWebDriver Driver;

        protected BaseEshopPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public CartPage CartPage { get; }

        public MainPage MainPage { get; }

        public CheckoutPage CheckoutPage { get; }

        protected abstract string GetUrl();
    }
}
