// <copyright file="Waits.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebdriverLevel2.Waits
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using SeleniumExtras.WaitHelpers;

    public class Waits
    {
        public readonly IWebDriver driver;
        public readonly WebDriverWait wait;

        public Waits(IWebDriver webDriver)
        {
            this.driver = webDriver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
            {
                PollingInterval = TimeSpan.FromMilliseconds(100)
            };
        }

        public IWebElement WaitForElementToBeClickable(By locator)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public IWebElement WaitForElementToBeVisible(By locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebElement WaitForElementToExists(By locator)
        {
            return wait.Until(ExpectedConditions.ElementExists(locator));
        }

        public void WaitForDocumentReady()
        {
            wait.Until(drv => ((IJavaScriptExecutor)this.driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
