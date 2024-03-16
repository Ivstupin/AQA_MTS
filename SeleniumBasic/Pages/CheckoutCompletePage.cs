using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class CheckoutCompletePage : BasePage
{
    private static string END_POINT = "/checkout-complete.html";

    // Описание элементов
    private static readonly By FinishButtonBy = By.Id("finish");
    private static readonly By TitleLabelBy = By.CssSelector("[class='title']");

    public ThreeStripesMenuPage ThreeStripesMenuPage;
    public CheckoutCompletePage(IWebDriver driver, bool openPageByUrl = true) : base(driver, openPageByUrl)
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
    //public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);
    //public IWebElement ShoppingCartAfterAddingProducts => WaitsHelper.WaitForExists(ShoppingCartAfterAddingProductsBy);

    //public CartPage _CheckoutButtonClick()
    //{

        //CheckoutButton.Click();

       // return new CheckoutYourPaimentIdPage(Driver);
   // }
    //public CartPage RemoveButtonByStandard_User()
    

        // AddToCartButton.Click();

        //return this;
    //}


}
