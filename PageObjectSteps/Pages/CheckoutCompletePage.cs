using OpenQA.Selenium;

namespace PageObjectSteps.Pages
{
    public class CheckoutCompletePage : BasePage
    {
        private static string END_POINT = "/checkout-complete.html";

        // Описание элементов
        private static readonly By FinishButtonBy = By.Id("finish");
        private static readonly By TitleLabelBy = By.CssSelector("[class='title']");
        private static readonly By ShoppingCartButtonBy = By.CssSelector("[class='shopping_cart_link']");
        private static readonly By BackHomeButtonBy = By.CssSelector("[class='shopping_cart_link']");

        public ThreeStripesMenuPage ThreeStripesMenuPage;
        public CheckoutCompletePage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
            ThreeStripesMenuPage = new ThreeStripesMenuPage(Driver); //три точки меню слева вверху
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Checkout: Complete!");
        }

        // Атомарные Методы
        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement FinishButton => WaitsHelper.WaitForExists(FinishButtonBy);
        public IWebElement ShoppingCartButton => WaitsHelper.WaitForExists(ShoppingCartButtonBy);
        public IWebElement BackHomeButton => WaitsHelper.WaitForExists(BackHomeButtonBy);
    }
}
