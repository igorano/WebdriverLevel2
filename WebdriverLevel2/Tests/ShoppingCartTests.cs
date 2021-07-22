// <copyright file="ShoppingCartTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using WebdriverLevel2.Pages;
using WebdriverLevel2.Waits;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace WebdriverLevel2
{
    public class ShoppingCartTests
    {
        private static IWebDriver driver;
        private static MainPage mainPage;
        private static CheckoutPage checkoutPage;
        private static CartPage cartPage;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            mainPage = new MainPage(driver);
            checkoutPage = new CheckoutPage(driver);
            cartPage = new CartPage(driver);
        }

        [Test]
        public void FirstTest()
        {
            mainPage.AddRocketToShoppingCart();
            cartPage.ClickProceedToCheckout();
            checkoutPage.PlaceOrder("Ivan", "Petrov", "ul.Lisica", "Sofia", "1000", "0892521365", "ivan.petrov@abv.bg");
        }

        [Test]
        public void SecondTest()
        {
        }

        [Test]
        public void ThirdTest()
        {
            mainPage.AddRocketToShoppingCart();
            cartPage.InputCouponCode("happybirthday");
            cartPage.ClickApplyCoupon();
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(300));

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//th[contains(text(), 'Coupon: happybirthday')]")));

            Assert.IsNotNull(driver.FindElement(By.XPath("//th[contains(text(), 'Coupon: happybirthday')]")));

            cartPage.ChangeQuantity("3");

            wait.Until(condtion => cartPage.GetAmount().Equals("150.00€"));
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}