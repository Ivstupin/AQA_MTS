using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class CartPage : BasePage
{
    private static string END_POINT = "/cart.html";

    // Описание элементов
    private static readonly By CheckoutButtonBy = By.Id("checkout");
    private static readonly By InventoryItemsBy = By.CssSelector("[class = 'inventory_item_name']");
    private static readonly By TitleLabelBy = By.CssSelector("[class='title']");

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
    //public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);
    public IWebElement InventoryItems => WaitsHelper.WaitForExists(InventoryItemsBy);

    public CheckoutUserInfoPage _CheckoutButtonClick()
    {

        CheckoutButton.Click();

        return new CheckoutUserInfoPage(Driver);
    }


    public bool СartIsNotEmpty()
    {

       if (InventoryItems.Displayed) 
        {
            return true;
        }
       else 
        {
            throw new NotImplementedException("Корзина покупок пустая");
        }
        
    }



}
