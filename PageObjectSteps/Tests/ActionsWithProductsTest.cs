using Allure.Helpers.Configuration;
using Allure.Net.Commons;
using Allure.Pages;
using Allure.Steps;
using NUnit.Allure.Attributes;

namespace Allure.Tests;



public class ActionsWithProductsTest : BaseTest
{
    [Test(Description = "Добавление и удаление продуктов из корзины")]
    [AllureSeverity(SeverityLevel.critical)]
    
    public void Add_Delete_ProductsFromCart_ActionsWithProductsTest()
    {
        new UserSteps(Driver).LoginByStandard_User(); // логин

        ActionsWithProductsSteps actionsWithProductsSteps = new(Driver);
        ProductsPage productsPage = actionsWithProductsSteps._AddToCartButtonClick(); // добавляем товар в тележку со страницы products 
        Assert.That(productsPage.ProductsNotChoosen()); // проверяем со страницы ProductsPage что товары  добавлены в тележку
        actionsWithProductsSteps._RemoveButtonClick(); // удаляем товар из тележки со страницы ProductsPage
        Assert.That(productsPage.ProductsNotChoosen()); // проверяем со страницы ProductsPage что товары не добавлены в тележку

        actionsWithProductsSteps._AddToCartButtonClick(); // добавляем товар в тележку со страницы products 
        NavigationSteps navigationSteps = new(Driver);
        CartPage cartPage = navigationSteps.NavigateToCartByButtonCartClick();     // переход в тележку по клику на иконку тележки
        Assert.That(!cartPage.СartIsEmpty()); // ОР тележка не пуста
        actionsWithProductsSteps._RemoveButtonClick(); // удаляем товар из тележки со страницы CartPage
        Assert.That(cartPage.СartIsEmpty()); // ОР тележка  пуста

        navigationSteps.FromCartPageToProductPageByClickContinueShoppingButton(); // так как в тележке пусто и перейти по клику на именование товара не получится, для проверки ProductInfoPage возвращаемся в ProductsPage 
        navigationSteps.NavigateToProductInfoPage(); // переход в ProductInfoPage
        actionsWithProductsSteps._AddToCartButtonClick(); // добавляем товар в тележку со страницы ProductInfoPage
        Assert.That(!productsPage.ProductsNotChoosen());  // проверяем со страницы ProductInfoPage что товары  добавлены в тележку
        actionsWithProductsSteps._RemoveButtonClick(); // удаляем товар из тележки со страницы ProductInfoPage
        Assert.That(productsPage.ProductsNotChoosen()); // проверяем со страницы ProductInfoPage что товары не добавлены в тележку
    }
}

