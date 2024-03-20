using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class ThreeStripesMenuPage : BasePage
{
    private static string END_POINT = "";

    // Описание элементов
    private static readonly By ThreeStripesBy = By.Id("react-burger-menu-btn");
    private static readonly By AllItemsButtonBy = By.XPath("//*[contains(text(),'All Items')]");
    private static readonly By AboutButtonBy = By.XPath("//*[contains(text(),'About')]");
    private static readonly By LogoutButtonBy = By.XPath("//*[contains(text(),'Logout')]");
    private static readonly By ResetAppStateButtonBy = By.XPath("//*[contains(text(),'Reset App State')]");

    public ThreeStripesMenuPage(IWebDriver driver) : base(driver)
    {

    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return ThreeStripes.Displayed;
    }

    // Методы
    public IWebElement ThreeStripes => WaitsHelper.WaitForExists(ThreeStripesBy);
    public IWebElement AllItemsButton => WaitsHelper.WaitForExists(AllItemsButtonBy);
    public IWebElement AboutButton => WaitsHelper.WaitForExists(AboutButtonBy);
    public IWebElement LogoutButton => WaitsHelper.WaitForExists(LogoutButtonBy);
    public IWebElement ResetAppStateButton => WaitsHelper.WaitForExists(ResetAppStateButtonBy);

}