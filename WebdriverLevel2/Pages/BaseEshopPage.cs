using OpenQA.Selenium;

namespace WebdriverLevel2.Pages
{
    public abstract class BaseEshopPage
    {
        protected readonly IWebDriver Driver;

        protected BaseEshopPage(IWebDriver driver)
        {
            Driver = driver;
            CartPage = new CartPage(driver);
            CheckoutPage = new CheckoutPage(driver);
            MainPage = new MainPage(driver);
        }

        public CartPage CartPage { get; }
        public MainPage MainPage { get; }
        public CheckoutPage CheckoutPage { get; }
        protected abstract string Url { get; }

    }
}
