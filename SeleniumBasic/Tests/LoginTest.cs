using SeleniumBasic.Pages;

namespace SeleniumBasic.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTestByStandard_User()
    {
        // Простой вид
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByStandard_User("", "");
        ProductsPage productsPage = new ProductsPage(Driver);

        // Проверка 
        Assert.That(productsPage.IsPageOpened);
        //Thread.Sleep(10000);
    }

    [Test]
    public void LoginByProblem_UserLoginTest()
    {
        // Простой вид
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByProblem_user("", "");
        ProductsPage productsPage = new ProductsPage(Driver);

        // Проверка 
        Assert.That(productsPage.IsPageOpened);
        //Thread.Sleep(10000);
    }

    [Test]
    public void LoginByPerformance_Glitch_User_LoginTest()
    {
        // Простой вид
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByPerformance_Glitch_User("", "");
        ProductsPage productsPage = new ProductsPage(Driver);

        // Проверка 
        Assert.That(productsPage.IsPageOpened);
        
    }

    [Test]
    public void LoginByError_User_LoginTest()
    {
        // Простой вид
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByError_User("", "");
        ProductsPage productsPage = new ProductsPage(Driver);

        // Проверка 
        Assert.That(productsPage.IsPageOpened);

    }

    [Test]
    public void LoginByVisual_UserLoginTest()
    {
        // Простой вид
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByVisual_User("", "");
        ProductsPage productsPage = new ProductsPage(Driver);

        // Проверка 
        Assert.That(productsPage.IsPageOpened);

    }

    [Test]
    public void InvalidUserNameAndPswLoginTest()
    {
        //// Проверка
        Assert.That(
           new LoginPage(Driver)
              .LoginByInvalidUserNameAndPsw("", "")
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }
    
    [Test]
    public void LockedUserLoginTest()
    {
        //// Проверка
        Assert.That(
           new LoginPage(Driver)
              .LoginByLockedUser("", "")
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }

    [Test]
    public void EmptyUserNameLoginTest()
    { 
        Assert.That(
           new LoginPage(Driver)
              .LoginByEmptyUserName("", "")
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Username is required"));
    }

    [Test]
    public void EmptyPswLoginTest()
    {
        Assert.That(
           new LoginPage(Driver)
              .LoginByEmptyPsw("", "")
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Password is required"));
    }

}