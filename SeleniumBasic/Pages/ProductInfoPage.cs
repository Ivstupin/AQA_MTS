using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class ProductInfoPage : BasePage
{
    private static string END_POINT = "/inventory-item.html?id=4";

    // Описание элементов
    private static readonly By LoginLogoBy = By.CssSelector("[class='login_logo']"); //лого Swag Labs
    private static readonly By BackToProductsButtonBy = By.Id("back-to-products"); // название страницы Back to products
    private static readonly By AddToCartButtonBy = By.CssSelector("[data-test='add-to-cart-sauce-labs-backpack']");
    private static readonly By RemoveButtonBy = By.CssSelector("[data-test='remove-sauce-labs-backpack']");
    private static readonly By ShoppingCartButtonBy = By.CssSelector("[class='shopping_cart_link']"); // селектор ссылки на страницу с тележкой 
    private static readonly By ShoppingCartBadgeBy = By.CssSelector("[class='shopping_cart_badge']"); //бэйдж с количеством товаров в тележке
    
    public ThreeStripesMenuPage ThreeStripesMenuPage;
    public ProductInfoPage(IWebDriver driver, bool openPageByUrl = true) : base(driver, openPageByUrl)
    {
        ThreeStripesMenuPage = new ThreeStripesMenuPage(Driver); //три точки меню слева вверху
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return BackToProductsButton.Text.Trim().Equals("Back to products");
    }

    // Атомарные Методы
    public IWebElement BackToProductsButton => WaitsHelper.WaitForExists(BackToProductsButtonBy); 
    public IWebElement AddToCartButton => WaitsHelper.WaitForExists(AddToCartButtonBy);
    public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);
    public IWebElement ShoppingCartBadge => WaitsHelper.WaitForExists(ShoppingCartBadgeBy);
    public IWebElement ShoppingCartButton => WaitsHelper.WaitForExists(ShoppingCartButtonBy);

    public ProductInfoPage _AddToCartButtonClick()
    {
        AddToCartButton.Click();
        return this;
    }
    public ProductInfoPage _RemoveButtonClick()
    {
        RemoveButton.Click();
        return this;
    }

    public CartPage ShoppingCartButtonLinkToCartPage()
    {
        ShoppingCartButton.Click();
        return new CartPage(Driver);
    }
    
    public ProductsPage BackToProductsButtonCartClick()
    {
        BackToProductsButton.Click();
        return new ProductsPage(Driver);
    }
}
