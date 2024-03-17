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
        productsPage._AddToCartButtonClick();                    // добавляем товар
        Assert.That(productsPage.RemoveButton.Displayed && productsPage.ShoppingCartBadge.Displayed); // кнопка добавить в тележку превратилась в удалить и в бэйдже тележки появилось количество товара
        CartPage cartPage = new CartPage(Driver);
        Assert.That(cartPage.IsPageOpened);                      // проверка что страница открылась
        Assert.That(!cartPage.СartIsEmpty());                    // проверка, что тележка не пуста
        
    }
    
    [Test]
    public void DeleteProductsFromCart_ActionsWithProductsTest()
    {
        LoginPage loginPage = new(Driver);
        loginPage.LoginByStandard_User("", "");
        ProductsPage productsPage = new(Driver);
        productsPage._AddToCartButtonClick();  // добавляем товар
        CartPage cartPage = new(Driver);
        Assert.That(cartPage
            .IsPageOpened);
        cartPage._RemoveButtonClick();         // удаляем товар
        Assert.That(cartPage
            .СartIsEmpty());        // проверка, что тележка пуста
    }
}

