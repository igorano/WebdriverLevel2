// <copyright file="CartPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebdriverLevel2.Pages
{
    using OpenQA.Selenium;
    using System;
    using System.Threading;
    using OpenQA.Selenium.Support.UI;

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

        private IWebElement CouponCode => this.Driver.FindElement(By.Id("coupon_code"));

        private IWebElement ApplyCoupon => this.Driver.FindElement(By.XPath("//button[@value='Apply coupon']"));

        private IWebElement InputFieldQuantity => this.Driver.FindElement(By.XPath("//input[@type='number']"));

        private IWebElement UpdateCartButton => this.Driver.FindElement(By.XPath("//button[@name='update_cart']"));

        private IWebElement Amount => this.Driver.FindElement(By.XPath("//td/following-sibling::td[@class='product-subtotal']"));

        public void ClickProceedToCheckout()
        {
            this.ProceedToCheckOut.Click();
        }

        public void ClickApplyCoupon()
        {
            this.ApplyCoupon.Click();
        }

        public void InputCouponCode(string code)
        {
            this.CouponCode.SendKeys(code);
        }

        public void ChangeQuantity(string quantityNumber)
        {
            this.InputFieldQuantity.Clear();
            this.InputFieldQuantity.SendKeys(quantityNumber);
            this.UpdateCartButton.Click();
            IWait<IWebDriver> wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
            wait.Until(driver1 => ((IJavaScriptExecutor)this.Driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public string GetAmount()
        {
            return this.Amount.Text;
        }
    }
}
