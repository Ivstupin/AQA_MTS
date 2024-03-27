using OpenQA.Selenium;

namespace Allure.Pages
{
    public class CheckoutOverviewPage : BasePage
    {
        private static string END_POINT = "/checkout-step-two.html";

        // Описание элементов
        private static readonly By FinishButtonBy = By.Id("finish");
        private static readonly By TitleLabelBy = By.CssSelector("[class='title']");
        private static readonly By TotalSumBy = By.CssSelector("[class='summary_info_label summary_total_label']");
        private static readonly By CancelButtonBy = By.Id("cancel");
        private static readonly By ShoppingCartButtonBy = By.CssSelector("[class='shopping_cart_link']");

        public ThreeStripesMenuPage ThreeStripesMenuPage;
        public CheckoutOverviewPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
            ThreeStripesMenuPage = new ThreeStripesMenuPage(Driver); //три точки меню слева вверху
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Checkout: Overview");
        }

        // Атомарные Методы
        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement FinishButton => WaitsHelper.WaitForExists(FinishButtonBy);
        public IWebElement TotalSum => WaitsHelper.WaitForExists(TotalSumBy);
        public IWebElement CancelButton => WaitsHelper.WaitForExists(CancelButtonBy);
        public IWebElement ShoppingCartButton => WaitsHelper.WaitForExists(ShoppingCartButtonBy);

        /// <summary>
        /// вернёт TRUE если на странице CheckoutOverviewPage сумма товаров больше 0
        /// </summary>
        public bool IsTotalSumNotZero()
        {
            Console.WriteLine(TotalSum.Text.Trim());
            return !TotalSum.Text.Trim().Equals("Total: $0.00");
        }
    }
}
