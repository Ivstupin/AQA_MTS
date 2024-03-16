using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class ThreeStripesMenuPage : BasePage
{
    private static string END_POINT = "";

    // Описание элементов
    private static readonly By ThreeStripesBy = By.Id("react-burger-menu-btn");


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
}