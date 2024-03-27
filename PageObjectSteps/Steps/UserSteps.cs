using OpenQA.Selenium;
using Allure.Pages;

namespace Allure.Steps;

public class UserSteps : BaseSteps
{
    public LoginPage _loginPage;
    public ProductsPage _productsPage;

    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
        _productsPage = new ProductsPage(Driver);
    }
    public ProductsPage LoginByStandard_User()
    {
        _loginPage.UserNameInput.SendKeys(standard_User);
        _loginPage.PswInput.SendKeys(PswForAllUsers);
        _loginPage.LoginInButton.Click();
        return new ProductsPage(Driver);
    }

    public ProductsPage LoginByProblem_user()
    {
        _loginPage.UserNameInput.SendKeys(problem_User);
        _loginPage.PswInput.SendKeys(PswForAllUsers);
        _loginPage.LoginInButton.Click();
        return new ProductsPage(Driver);
    }


    public ProductsPage LoginByPerformance_Glitch_User()
    {
        _loginPage.UserNameInput.SendKeys(performance_Glitch_User);
        _loginPage.PswInput.SendKeys(PswForAllUsers);
        _loginPage.LoginInButton.Click();
        return new ProductsPage(Driver);
    }

    public ProductsPage LoginByError_User()
    {
        _loginPage.UserNameInput.SendKeys(error_User);
        _loginPage.PswInput.SendKeys(PswForAllUsers);
        _loginPage.LoginInButton.Click();
        return new ProductsPage(Driver);
    }
    public ProductsPage LoginByVisual_User()
    {
        _loginPage.UserNameInput.SendKeys(visual_User);
        _loginPage.PswInput.SendKeys(PswForAllUsers);
        _loginPage.LoginInButton.Click();
        return new ProductsPage(Driver);
    }

    public LoginPage LoginByInvalidUserNameAndPsw(string f, string h)
    {
        _loginPage.UserNameInput.SendKeys("gdf");
        _loginPage.PswInput.SendKeys("fghgf");
        _loginPage.LoginInButton.Click();
        return _loginPage;
    }
    public LoginPage LoginByLockedUser()
    {
        _loginPage.UserNameInput.SendKeys(locked_Out_User);
        _loginPage.PswInput.SendKeys(PswForAllUsers);
        _loginPage.LoginInButton.Click();
        return _loginPage;
    }
    public LoginPage LoginByEmptyUserName()
    {
        _loginPage.UserNameInput.SendKeys("");
        _loginPage.PswInput.SendKeys(PswForAllUsers);
        _loginPage.LoginInButton.Click();
        return _loginPage;
    }
    public LoginPage LoginByEmptyPsw()
    {
        _loginPage.UserNameInput.SendKeys("asd");
        _loginPage.PswInput.SendKeys("");
        _loginPage.LoginInButton.Click();
        return _loginPage;
    }

    //Users
    readonly string standard_User = "standard_user";
    readonly string locked_Out_User = "locked_out_user";
    readonly string problem_User = "problem_user";
    readonly string performance_Glitch_User = "performance_glitch_user";
    readonly string error_User = "error_user";
    readonly string visual_User = "visual_user";
    //
    readonly string PswForAllUsers = "secret_sauce"; // пароль
}