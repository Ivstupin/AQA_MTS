using OpenQA.Selenium;
using SeleniumBasic.Core;
using SeleniumBasic.Helpers;
using SeleniumBasic.Helpers.Configuration;
using SeleniumBasic.Pages;

namespace SeleniumBasic.Tests;
public class PaymentTest : BaseTest
{
    [Test]
    public void Succesfull_EndToEnd_PaymentTest()
    {
        LoginPage loginPage = new(Driver);                       // инициализация страницы авторизации
        loginPage.LoginByStandard_User();                  // под стандартным пользователем

        ProductsPage productsPage = new ProductsPage(Driver)._AddToCartButtonClick();  // инициализация страницы с каталогом товаров и добавление товара в тележку
        Assert.That(productsPage.RemoveButton.Displayed && productsPage.ShoppingCartBadge.Displayed); // проверка, что кнопка добавить в тележку превратилась в удалить и в значке тележки справа появился товар

        CartPage cartPage = new(Driver);                         // инициализация страницы корзины и переход на неё
        Assert.That(cartPage.IsPageOpened);                      // проверка что страница открылась
        Assert.That(!cartPage.СartIsEmpty());                    // проверка, что в тележке есть товар
        cartPage._CheckoutButtonClick();                         // нажатие на кнопку Checkout c переходом на страницу пользовательской информацией

        CheckoutUserInfoPage checkoutUserInfoPage = new(Driver); // инициализация страницы c пользовательской информацией
        Assert.That(checkoutUserInfoPage.IsPageOpened);          // проверка что страница открылась
        checkoutUserInfoPage.CorrectInputUsersInfo();            // заполнение страницы корректными данными и нажатие на кнопку Continue c переходом на страницу проверки заказа

        CheckoutOverviewPage checkoutOverviewPage = new(Driver); // инициализация страницы проверки заказа
        Assert.Multiple(() =>
        {
            Assert.That(checkoutOverviewPage.IsPageOpened());        // проверка что страница открылась
            Assert.That(checkoutOverviewPage.IsTotalSumNotZero());   // проверка что общая сумма заказа не равна нулю
        });
        checkoutOverviewPage._FinishButtonClick();               // нажатие на кнопку Finish c переходом на страницу c благодарностью за заказ

        CheckoutCompletePage checkoutCompletePage = new(Driver); // инициализация страницы c благодарностью за заказ
        Assert.That(checkoutCompletePage.IsPageOpened);          // проверка что страница открылась
    }
}
 

