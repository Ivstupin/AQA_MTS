﻿using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class CheckoutUserInfoPage : BasePage
{
    private static string END_POINT = "/checkout-step-one.html";

    // Описание элементов
    private static readonly By ContinueButtonBy = By.Id("continue");
    private static readonly By TitleLabelBy = By.CssSelector("[class='title']");
    private static readonly By FirstNameInputBy = By.Id("first-name");
    private static readonly By LastNameInputBy = By.Id("last-name");
    private static readonly By PostalCodeInputBy = By.Id("postal-code");

    string validFirstName = "Ivan";
    string validtLastName = "Stupin";
    string validPostalCode = "630036";

    public ThreeStripesMenuPage ThreeStripesMenuPage;
    public CheckoutUserInfoPage(IWebDriver driver, bool openPageByUrl = true) : base(driver, openPageByUrl)
    {
        ThreeStripesMenuPage = new ThreeStripesMenuPage(Driver); //три точки меню слева вверху
    }


    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleLabel.Text.Trim().Equals("Checkout: Your Information");
    }

    // Атомарные Методы
    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
    public IWebElement FirstNameInput => WaitsHelper.WaitForExists(FirstNameInputBy);
    public IWebElement LastNameInput => WaitsHelper.WaitForExists(LastNameInputBy);
    public IWebElement PostalCodeInput => WaitsHelper.WaitForExists(PostalCodeInputBy);
    public IWebElement ContinueButton => WaitsHelper.WaitForExists(ContinueButtonBy);

    public CheckoutOverviewPage CorrectInputUsersInfo()
    {
        FirstNameInput.SendKeys(validFirstName);
        LastNameInput.SendKeys(validtLastName);
        PostalCodeInput.SendKeys(validPostalCode);
        ContinueButton.Click();

        return new CheckoutOverviewPage(Driver);
    }
    //{

    //CheckoutButton.Click();

    // return new CheckoutYourPaimentIdPage(Driver);
    // }
    //public CartPage RemoveButtonByStandard_User()


    // AddToCartButton.Click();

    //return this;
    //}


}
