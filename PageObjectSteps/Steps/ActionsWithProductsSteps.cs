using OpenQA.Selenium;
using PageObjectSteps.Pages;

namespace PageObjectSteps.Steps;

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
    /// Добавляем товар со страницы ProductsPage
    /// </summary>
    public ProductsPage _AddToCartButtonClick() //добавить в тележку
    {
        productsPage.AddToCartButton.Click();
        return productsPage;
    }
    public ProductsPage _RemoveButtonClick() //удалить из тележки
    {
        productsPage.RemoveButton.Click();
        return productsPage;
    }

    //public CartPage ShoppingCartButtonLinkToCartPage() //кнопка с тележкой и ссылкой на страницу с тележкой
    //{
    //    ShoppingCartButton.Click();
    //    return new CartPage(Driver);
    //}

    //public ProductInfoPage ShoppingCartButtonLinkToProductsInfoPage() //  кнопка с заголовком товара и переходом на страницу с информацией о товаре
    //{
    //    NameProductsTitle.Click();
    //    return new ProductInfoPage(Driver);
    //}

}


    

