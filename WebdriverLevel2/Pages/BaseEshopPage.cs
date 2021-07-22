// <copyright file="BaseEshopPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebdriverLevel2.Pages
{
    using OpenQA.Selenium;
    using WebdriverLevel2.Waits;

    public abstract class BaseEshopPage
    {
        protected readonly IWebDriver Driver;
        protected readonly Waits wait;

        protected BaseEshopPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.wait = new Waits(this.Driver);
        }

        public CartPage CartPage { get; }

        public MainPage MainPage { get; }

        public CheckoutPage CheckoutPage { get; }

        public Waits Waits { get; }

        protected abstract string GetUrl();
    }
}
