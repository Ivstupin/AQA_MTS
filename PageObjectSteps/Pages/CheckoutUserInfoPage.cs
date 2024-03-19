using OpenQA.Selenium;

namespace PageObjectSteps.Pages
{
    public class CheckoutUserInfoPage : BasePage
    {
        private static string END_POINT = "/checkout-step-one.html";

        // Описание элементов
        private static readonly By LoginLogoBy = By.CssSelector("[class='login_logo']"); //лого Swag Labs
        private static readonly By ContinueButtonBy = By.Id("continue");
        private static readonly By TitleLabelBy = By.CssSelector("[class='title']");
        private static readonly By FirstNameInputBy = By.Id("first-name");
        private static readonly By LastNameInputBy = By.Id("last-name");
        private static readonly By PostalCodeInputBy = By.Id("postal-code");
        private static readonly By ShoppingCartButtonBy = By.CssSelector("[class='shopping_cart_link']");
        private static readonly By CancelButtonBy = By.Id("cancel");

        //string validFirstName = "Ivan";
        //string validtLastName = "Stupin";
        //string validPostalCode = "630036";

        public ThreeStripesMenuPage ThreeStripesMenuPage;
        public CheckoutUserInfoPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
            ThreeStripesMenuPage = new ThreeStripesMenuPage(Driver); //три точки меню слева вверху
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Checkout: Your Information");
        }

        // Атомарные Методы
        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement FirstNameInput => WaitsHelper.WaitForExists(FirstNameInputBy);
        public IWebElement LastNameInput => WaitsHelper.WaitForExists(LastNameInputBy);
        public IWebElement PostalCodeInput => WaitsHelper.WaitForExists(PostalCodeInputBy);
        public IWebElement ContinueButton => WaitsHelper.WaitForExists(ContinueButtonBy);
        public IWebElement ShoppingCartButton => WaitsHelper.WaitForExists(ShoppingCartButtonBy);
        public IWebElement CancelButton => WaitsHelper.WaitForExists(CancelButtonBy);

        //public CheckoutOverviewPage CorrectInputUsersInfo()
        //{
        //    FirstNameInput.SendKeys(validFirstName);
        //    LastNameInput.SendKeys(validtLastName);
        //    PostalCodeInput.SendKeys(validPostalCode);
        //    ContinueButton.Click();

       
        public ProductsPage BackToProductsButtonCartClick()
        {
            ShoppingCartButton.Click();
            return new ProductsPage(Driver);
        }

        public CartPage _CancelButtonClick()
        {
            CancelButton.Click();
            return new CartPage(Driver);
        }

    }
}
