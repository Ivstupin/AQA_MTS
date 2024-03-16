using SeleniumBasic.Pages;

namespace SeleniumBasic.Tests;

public class ActionsWithProductsTest : BaseTest
{
    [Test]
    public void AddProductsToCart_ActionsWithProductsTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByStandard_User("", "");
        ProductsPage productsPage = new ProductsPage(Driver);
        productsPage._AddToCartButtonClick();
        Assert.That(productsPage.RemoveButton.Displayed && productsPage.ShoppingCartBadge.Displayed); // кнопка добавить в тележку превратилась в удалить и в бэйдже тележки появилось количество товара
        CartPage cartPage = new CartPage(Driver);
        Assert.That(cartPage.IsPageOpened);                      // проверка что страница открылась
        Assert.That(cartPage.СartIsNotEmpty);                    // проверка, что в тележке есть товар
         Thread.Sleep(50000);
    }
    
    [Test]
    public void DeleteProductsFromCart_ActionsWithProductsTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.LoginByStandard_User("", "");
        ProductsPage productsPage = new ProductsPage(Driver);
        productsPage._AddToCartButtonClick();
        productsPage._RemoveButtonClick();
        Assert.That(
            productsPage
            .AddToCartButton
            .Displayed);
    }
}

