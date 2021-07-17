using OpenQA.Selenium;

namespace WebdriverLevel2.Pages
{
    public class CheckoutPage : BaseEshopPage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {

        }
        protected override string Url => @"http://demos.bellatrix.solutions/checkout/";
        private IWebElement FirstName => Driver.FindElement(By.Id("billing_first_name"));
        private IWebElement LastName => Driver.FindElement(By.Id("billing_last_name"));
        private IWebElement StreetAddress => Driver.FindElement(By.Id("billing_address_1"));
        private IWebElement City => Driver.FindElement(By.Id("billing_city"));
        private IWebElement PostCode => Driver.FindElement(By.Id("billing_postcode"));
        private IWebElement Email => Driver.FindElement(By.Id("billing_email"));
        private IWebElement PlaceOrderElement => Driver.FindElement(By.Id("place_order"));

        public void PlaceOrder(string firstName, string lastName, string streetAddress, string city, string postCode, string email)
        {
            FirstName.SendKeys(firstName);
            LastName.SendKeys(lastName);
            StreetAddress.SendKeys(streetAddress);
            City.SendKeys(city);
            PostCode.SendKeys(postCode);
            Email.SendKeys(email);
            PlaceOrderElement.Click();
        }
    }
}
