using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class ProductsPage : BasePage
{
    private static string END_POINT = "/inventory.html";

    // Описание элементов
    private static readonly By TitleLabelBy = By.CssSelector("[class='title']"); // название страницы Products 
    private static readonly By AddToCartButtonBy = By.CssSelector("[data-test='add-to-cart-sauce-labs-backpack']");
    private static readonly By RemoveButtonBy = By.CssSelector("[data-test='remove-sauce-labs-backpack']");
    private static readonly By ShoppingCartButtonBy = By.CssSelector("[class='shopping_cart_link']"); // селектор ссылки на страницу с тележкой 
    private static readonly By ShoppingCartBadgeBy = By.CssSelector("[class='shopping_cart_badge']"); //бэйдж с количеством товаров в тележке
    // dropdown Name (A to Z)

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
    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy); 
    public IWebElement AddToCartButton => WaitsHelper.WaitForExists(AddToCartButtonBy);
    public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);
    public IWebElement ShoppingCartBadge => WaitsHelper.WaitForExists(ShoppingCartBadgeBy);
    public IWebElement ShoppingCartButton => WaitsHelper.WaitForExists(ShoppingCartButtonBy);

    public ProductsPage _AddToCartButtonClick()
    {
        AddToCartButton.Click();
        return this;
    }
    public ProductsPage _RemoveButtonClick()
    {
        RemoveButton.Click();
        return this;
    }

    public CartPage ShoppingCartButtonLinkToCartPage()
    {
        ShoppingCartButton.Click();
        return new CartPage(Driver);
    }


}
