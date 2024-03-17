using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SeleniumBasic.Pages;

public class CartPage : BasePage
{
    private static string END_POINT = "/cart.html";

    // Описание элементов
    private static readonly By LoginLogoBy = By.CssSelector("[class='login_logo']"); //лого Swag Labs
    private static readonly By CheckoutButtonBy = By.Id("checkout");
    private static readonly By ContinueShoppingBy = By.Id("continue-shopping");
    private static readonly By TitleLabelBy = By.CssSelector("[class='title']");
    private static readonly By RemoveButtonBy = By.CssSelector("[class='btn btn_secondary btn_small cart_button']");

    public ThreeStripesMenuPage ThreeStripesMenuPage;
    public CartPage(IWebDriver driver, bool openPageByUrl = true) : base(driver, openPageByUrl)
    {
        ThreeStripesMenuPage = new ThreeStripesMenuPage(Driver); //три точки меню слева вверху
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleLabel.Text.Trim().Equals("Your Cart");
    }

    // Атомарные Методы
    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
    public IWebElement CheckoutButton => WaitsHelper.WaitForExists(CheckoutButtonBy);
    public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);
    public IWebElement ContinueShopping => WaitsHelper.WaitForExists(ContinueShoppingBy);
    
    public bool WaitForElementInvisibleRemoveButton => WaitsHelper.WaitForElementInvisible(RemoveButtonBy); //вернёт true если не найдёт selector кнопки Remove
    /// <summary>
    /// нажмёт кнопку Checkout и перейдёт на след.страницу CheckoutUserInfoPage
    /// </summary>
    public CheckoutUserInfoPage _CheckoutButtonClick()
    {
        CheckoutButton.Click();
        return new CheckoutUserInfoPage(Driver);
    }

    /// <summary>
    /// вернёт TRUE если не найдёт элемент кнопки Remove что означает что тележка пуста, если тележка не пуста то обработает WebDriverTimeoutException и вернёт FALSE
    /// </summary>
    public bool СartIsEmpty()
    {
        try
        {
            return WaitForElementInvisibleRemoveButton;
        }
        catch (WebDriverTimeoutException)
        {
            return false;
            //throw new Exception("dgf");
        }
    }

    public CartPage _RemoveButtonClick()
    {
        RemoveButton.Click();
        return this;
    }
    /// <summary>
    /// нажмём кнопку ContinueShopping и вернёмся в ProductsPage
    /// </summary>
    public ProductsPage _ContinueShoppingClick()
    {
        ContinueShopping.Click();
        return new ProductsPage(Driver);
    }

}
