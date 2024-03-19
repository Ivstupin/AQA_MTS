using PageObjectSteps.Helpers.Configuration;
using PageObjectSteps.Pages;
using PageObjectSteps.Steps;

namespace PageObjectSteps.Tests;




public class PaymentTest : BaseTest
{
    [Test]
    public void Succesfull_EndToEnd_PaymentTest()
    {
        new UserSteps(Driver).LoginByStandard_User();                      // логин под стандартным пользователем
        new ActionsWithProductsSteps(Driver)._AddToCartButtonClick();      //добавление товара в тележку
        
        NavigationSteps navigationSteps = new(Driver);
        CartPage cartPage = navigationSteps.NavigateToCartByButtonCartClick(); // переход в тележку по клику кнопки с тележкой
        // инициализация страницы корзины и переход на неё
        Assert.That(cartPage.IsPageOpened);                      // проверка что страница открылась
        Assert.That(!cartPage.СartIsEmpty());                    // проверка, что в тележке есть товар
        navigationSteps.NavigateToUserInfoPageByClickCheckoutButton(); //Thread.Sleep(30000);                     // нажатие на кнопку Checkout c переходом на страницу пользовательской информацией

        //CheckoutUserInfoPage checkoutUserInfoPage = new(Driver); // инициализация страницы c пользовательской информацией


        // заполнение страницы корректными данными и нажатие на кнопку Continue c переходом на страницу проверки заказа

        CheckoutOverviewPage checkoutOverviewPage = navigationSteps.NavigateToCheckoutOverviewPageWithValidInputInfo(); // инициализация страницы проверки заказа
        Assert.Multiple(() =>
        {
            Assert.That(checkoutOverviewPage.IsPageOpened());        // проверка что страница открылась
            Assert.That(checkoutOverviewPage.IsTotalSumNotZero());   // проверка что общая сумма заказа не равна нулю
        }); //Thread.Sleep(30000);
        CheckoutCompletePage checkoutCompletePage = navigationSteps.NavigateToCheckoutCompletePageByFinishButtonClick();         // нажатие на кнопку Finish c переходом на страницу c благодарностью за заказ

        
        Assert.That(checkoutCompletePage.IsPageOpened);          // проверка что страница открылась
        Thread.Sleep(30000);
    }
}
 

