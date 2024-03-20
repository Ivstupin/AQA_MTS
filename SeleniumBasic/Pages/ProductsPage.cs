using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class ProductsPage : BasePage
{
    private static string END_POINT = "/inventory.html";

    // Описание элементов
    private static readonly By LoginLogoBy = By.CssSelector("[class='login_logo']"); //лого Swag Labs
    private static readonly By TitleLabelBy = By.CssSelector("[class='title']"); // название страницы Products 
    private static readonly By AddToCartButtonBy = By.CssSelector("[data-test='add-to-cart-sauce-labs-backpack']"); //селектор кнопки добавить в тележку
    private static readonly By RemoveButtonBy = By.CssSelector("[data-test='remove-sauce-labs-backpack']"); //селектор кнопки удалить из тележки
    private static readonly By ShoppingCartButtonBy = By.CssSelector("[class='shopping_cart_link']"); // селектор ссылки на страницу с тележкой 
    private static readonly By ShoppingCartBadgeBy = By.CssSelector("[class='shopping_cart_badge']"); //бэйдж с количеством товаров в тележке
    private static readonly By DropdownNameBy = By.CssSelector("[class='product_sort_container']"); // dropdown Name (A to Z)
    private static readonly By NameProductsTitleBy = By.CssSelector("[class='inventory_item_name ']"); //селектор имени товара со ссылкой на страницу его описания

    public ThreeStripesMenuPage ThreeStripesMenuPage;
    public ProductsPage(IWebDriver driver, bool openPageByUrl = true) : base(driver, openPageByUrl)
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

    public ProductsPage _AddToCartButtonClick() //добавить в тележку
    {
        AddToCartButton.Click();
        return this;
    }
    public ProductsPage _RemoveButtonClick() //удалить из тележки
    {
        RemoveButton.Click();
        return this;
    }

    public CartPage ShoppingCartButtonLinkToCartPage() //кнопка с тележкой и ссылкой на страницу с тележкой
    {
        ShoppingCartButton.Click();
        return new CartPage(Driver);
    }

    public ProductInfoPage ShoppingCartButtonLinkToProductsInfoPage() //  кнопка с заголовком товара и переходом на страницу с информацией о товаре
    {
        NameProductsTitle.Click();
        return new ProductInfoPage(Driver);
    }
}
