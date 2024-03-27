using OpenQA.Selenium;
using Allure.Pages;

namespace Allure.Steps;

public class ActionsWithProductsSteps : BaseSteps
{
    public ProductsPage productsPage;
    public ProductInfoPage productInfoPage;
    public CartPage cartPage;

    public ActionsWithProductsSteps(IWebDriver driver) : base(driver)
    {
        productsPage = new ProductsPage(Driver);
        productInfoPage = new ProductInfoPage(driver);
        cartPage = new CartPage(Driver);
    }
    /// <summary>
    /// Добавляем товар в тележку со страниц ProductsPage, ProductInfoPage
    /// </summary>
    public ProductsPage _AddToCartButtonClick() //добавить в тележку
    {
        productsPage.AddToCartButton.Click();
        return productsPage;
    }

    /// <summary>
    /// Удаляем товар из тележки со страниц ProductsPage, ProductInfoPage, CartPage (только если товар был добавлен ранее на других страницах)
    /// </summary>
    public ProductsPage _RemoveButtonClick() 
    {
        productsPage.RemoveButton.Click();
        return productsPage;
    }
}


    

