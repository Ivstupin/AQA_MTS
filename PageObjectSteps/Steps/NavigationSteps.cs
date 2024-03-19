using OpenQA.Selenium;
using PageObjectSteps.Pages;

namespace PageObjectSteps.Steps;

public class NavigationSteps : BaseSteps
{
    public ProductsPage productsPage;
    public ProductInfoPage productInfoPage;
    public CartPage сartPage;
    public CheckoutUserInfoPage checkoutUserInfoPage;
    public CheckoutOverviewPage checkoutOverviewPage;
    public CheckoutCompletePage checkoutCompletePage;

    public NavigationSteps(IWebDriver driver) : base(driver)
    {
        productsPage = new ProductsPage(Driver);
        productInfoPage = new ProductInfoPage(Driver);
        сartPage = new CartPage(Driver);
        checkoutUserInfoPage = new CheckoutUserInfoPage(Driver);
        checkoutOverviewPage = new CheckoutOverviewPage(Driver);
        checkoutCompletePage = new CheckoutCompletePage(Driver);
    }

    /// <summary>
    /// нажмёт кнопку Checkout и перейдёт на след.страницу CheckoutUserInfoPage со страницы CartPage
    /// </summary>
    public CheckoutUserInfoPage NavigateToUserInfoPageByClickCheckoutButton()
    {
        сartPage.CheckoutButton.Click();
        return new CheckoutUserInfoPage(Driver);
    }
    /// <summary>
    /// Попадаем в тележку через клик по кнопке тележки со страниц: ProductsPage ProductInfoPage CheckoutUserInfoPage CheckoutOverviewPage CheckoutCompletePage
    /// </summary>
    public CartPage NavigateToCartByButtonCartClick()
    {
        productsPage.ShoppingCartButton.Click();
        return new CartPage(Driver);
    }
    /// <summary>
    /// Попытка попасть на страницу CheckoutOverviewPage через клик по кнопке Continue без ввода валидных данных 
    /// </summary>
    public CheckoutUserInfoPage NavigateToCheckoutOverviewPageWithOutInputInfo()
    {
        checkoutUserInfoPage.ContinueButton.Click();
        return checkoutUserInfoPage;
    }
    /// <summary>
    /// Попадаем на страницу CheckoutOverviewPage  через клик по кнопке Continue и ввод валидных данных
    /// </summary>
    public CheckoutOverviewPage NavigateToCheckoutOverviewPageWithValidInputInfo()
    {
        checkoutUserInfoPage.FirstNameInput.SendKeys(validFirstName);
        checkoutUserInfoPage.LastNameInput.SendKeys(validtLastName);
        checkoutUserInfoPage.PostalCodeInput.SendKeys(validPostalCode);
        checkoutUserInfoPage.ContinueButton.Click();
        return new CheckoutOverviewPage(Driver);
    }
    readonly string validFirstName = "Ivan";
    readonly string validtLastName = "Stupin";
    readonly string validPostalCode = "630036";

    /// <summary>
    /// Попадаем на страницу CheckoutCompletePage CheckoutOverviewPage через клик по кнопке Finish
    /// </summary>
    public CheckoutCompletePage NavigateToCheckoutCompletePageByFinishButtonClick()
    {
        checkoutCompletePage.FinishButton.Click();
        return new CheckoutCompletePage(Driver);
    }

    /// <summary>
    /// Попадаем на страницу с информацией о выбранном товаре через клик по его названию со страниц: ProductsPage CheckoutOverviewPage CartPage(при наличии товара в тележке)
    /// </summary>
    public ProductInfoPage NavigateToProductInfoPage() //  кнопка с заголовком товара и переходом на страницу с информацией о товаре
    {
        productsPage.NameProductsTitle.Click();
        return new ProductInfoPage(Driver);
    }

    /// <summary>
    /// нажмём кнопку ContinueShopping и вернёмся в ProductsPage с CartPage
    /// </summary>
    public ProductsPage NavigateToProductPageByClickContinueButton()
    {
        сartPage.ContinueShopping.Click();
        return new ProductsPage(Driver);
    }

}


