using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebdriverLevel2.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace WebdriverLevel2
{
    public class Tests
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
            checkoutPage.PlaceOrder("Ivan", "Petrov", "ul.Lisica", "Sofia", "1000", "ivan.petrov@abv.bg");
        }


        [Test]
        public void SecondTest()
        {

        }


        [Test]
        public void ThirdTest()
        {
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}