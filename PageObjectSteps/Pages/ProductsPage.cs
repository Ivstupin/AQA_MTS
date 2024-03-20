using OpenQA.Selenium;

namespace PageObjectSteps.Pages
{
    public class ProductsPage : BasePage
    {
        private static string END_POINT = "/inventory.html";

        // Описание элементов
        private static readonly By LoginLogoBy = By.CssSelector("[class='login_logo']"); //лого Swag Labs
        private static readonly By TitleLabelBy = By.CssSelector("[class='title']"); // название страницы Products 
        private static readonly By AddToCartButtonBy = By.XPath("//*[contains(text(),'Add to cart')]"); //селектор кнопки добавить в тележку
        private static readonly By RemoveButtonBy = By.XPath("//*[contains(text(),'Remove')]"); //селектор кнопки удалить из тележки
        private static readonly By ShoppingCartButtonBy = By.CssSelector("[class='shopping_cart_link']"); // селектор ссылки на страницу с тележкой 
        private static readonly By ShoppingCartBadgeBy = By.CssSelector("[class='shopping_cart_badge']"); //бэйдж с количеством товаров в тележке
        private static readonly By DropdownNameBy = By.CssSelector("[class='product_sort_container']"); // dropdown Name (A to Z)
        private static readonly By NameProductsTitleBy = By.CssSelector("[class~='inventory_item_name']"); //селектор имени товара со ссылкой на страницу его описания
        
        public ThreeStripesMenuPage ThreeStripesMenuPage;
        public ProductsPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
            ThreeStripesMenuPage = new ThreeStripesMenuPage(Driver); //три точки меню слева вверху
        }
        
        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Products");
        }

        // Атомарные Методы
        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy); // название страницы Products 
        public IWebElement AddToCartButton => WaitsHelper.WaitForExists(AddToCartButtonBy); // кнопка добавить в тележку
        public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);// кнопка удалить из тележки
        public IWebElement ShoppingCartBadge => WaitsHelper.WaitForExists(ShoppingCartBadgeBy);//бэйдж с количеством товаров в тележке
        public IWebElement ShoppingCartButton => WaitsHelper.WaitForExists(ShoppingCartButtonBy); //  кнопка со ссылкой на страницу с тележкой 
        public IWebElement NameProductsTitle => WaitsHelper.WaitForExists(NameProductsTitleBy); // заголовок товара

        public bool WaitForElementInvisibleRemoveButton => WaitsHelper.WaitForElementInvisible(RemoveButtonBy); //вернёт true если не найдёт selector кнопки Remove

        /// <summary>
        /// вернёт TRUE если на странице ProductsPage не добавлен ни один товар в тележку
        /// </summary>
        public bool ProductsNotChoosen()
        {
            try
            {
                return WaitForElementInvisibleRemoveButton;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}