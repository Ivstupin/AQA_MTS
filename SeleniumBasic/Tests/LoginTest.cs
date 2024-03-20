using SeleniumBasic.Pages;

namespace SeleniumBasic.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTestByStandard_User()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByStandard_User();
        ProductsPage productsPage = new ProductsPage(Driver);
        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    public void LoginByProblem_UserLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByProblem_user();
        ProductsPage productsPage = new ProductsPage(Driver);
        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    public void LoginByPerformance_Glitch_User_LoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByPerformance_Glitch_User();
        ProductsPage productsPage = new ProductsPage(Driver);
        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    public void LoginByError_User_LoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByError_User();
        ProductsPage productsPage = new ProductsPage(Driver);
        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    public void LoginByVisual_UserLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByVisual_User();
        ProductsPage productsPage = new ProductsPage(Driver);
        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    public void InvalidUserNameAndPswLoginTest()
    {
        Assert.That(
           new LoginPage(Driver)
              .LoginByInvalidUserNameAndPsw()
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }
    
    [Test]
    public void LockedUserLoginTest()
    {
        Assert.That(
           new LoginPage(Driver)
              .LoginByLockedUser()
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }

    [Test]
    public void EmptyUserNameLoginTest()
    { 
        Assert.That(
           new LoginPage(Driver)
              .LoginByEmptyUserName()
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Username is required"));
    }

    [Test]
    public void EmptyPswLoginTest()
    {
        Assert.That(
           new LoginPage(Driver)
              .LoginByEmptyPsw()
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Password is required"));
    }
}