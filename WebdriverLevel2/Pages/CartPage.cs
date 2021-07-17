using OpenQA.Selenium;

namespace WebdriverLevel2.Pages
{
    public class CartPage : BaseEshopPage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {

        }
        protected override string Url => @"http://demos.bellatrix.solutions/cart/";
        private IWebElement ProceedToCheckOut => Driver.FindElement(By.LinkText("Proceed to checkout"));

        public void ClickProceedToCheckout()
        {
            ProceedToCheckOut.Click();
        }
    }
}
