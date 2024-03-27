using Allure.Helpers.Configuration;
using Allure.Pages;
using Allure.Steps;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;
namespace Allure.Tests;

public class LoginTest : BaseTest
{
    [Test]
    [NUnit.Allure.Attributes.AllureOwner("Ivan Stupin")]
    public void SuccessfulLoginTestByStandard_User()
    {
        UserSteps userSteps = new UserSteps(Driver);
        ProductsPage productsPage = userSteps.LoginByStandard_User();

        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    [AllureIssue("TMS-234234")]
    public void LoginByProblem_UserLoginTest()
    {
        UserSteps userSteps = new(Driver);
        ProductsPage productsPage = userSteps
            .LoginByProblem_user();
        
        Assert.That(productsPage.IsPageOpened);
    }

    [Test]

    public void LoginByPerformance_Glitch_User_LoginTest()
    {
        UserSteps userSteps = new(Driver);
        ProductsPage productsPage = userSteps
            .LoginByPerformance_Glitch_User();
        
        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    public void LoginByError_User_LoginTest()
    {
        UserSteps userSteps = new(Driver);
        ProductsPage productsPage = userSteps
            .LoginByError_User();
        
        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    public void LoginByVisual_UserLoginTest()
    {
        UserSteps userSteps = new(Driver);
        ProductsPage productsPage = userSteps
            .LoginByVisual_User();
        
        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    [AllureStep("invalid")]
    public void InvalidUserNameAndPswLoginTest()
    {
        Assert.That(
             new UserSteps(Driver)
              .LoginByInvalidUserNameAndPsw("f", "d")
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }

    [Test]
    
    public void LockedUserLoginTest()
    {
        Assert.That(
             new UserSteps(Driver)
              .LoginByLockedUser()
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locke5d out."));
    }

    [Test]
    public void EmptyUserNameLoginTest()
    {
        Assert.That(
             new UserSteps(Driver)
              .LoginByEmptyUserName()
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Username is required"));
    }

    [Test]
    public void EmptyPswLoginTest()
    {
        Assert.That(
             new UserSteps(Driver)
              .LoginByEmptyPsw()
              .ErrorLab.Text.Trim(),
            Is.EqualTo("Epic sadface: Password is required"));
    }
}