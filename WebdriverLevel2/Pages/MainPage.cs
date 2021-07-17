using OpenQA.Selenium;

namespace WebdriverLevel2.Pages
{
    public class MainPage : BaseEshopPage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement AddFalcon9 => Driver.FindElement(By.XPath("//a[@data-product_id='28' and contains(text(),'Add to cart')]"));
        private IWebElement ViewCartButton => Driver.FindElement(By.XPath("//a[@class='added_to_cart wc-forward']"));
        protected override string Url => @"http://demos.bellatrix.solutions/";

        public void AddRocketToShoppingCart()
        {
            Driver.Navigate().GoToUrl(Url);
            AddFalcon9.Click();
            ViewCartButton.Click();
        }
    }
}
