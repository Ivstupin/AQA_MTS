using Allure.Helpers.Configuration;
using Allure.Pages;
using Allure.Steps;

namespace Allure.Tests;




public class PaymentTest : BaseTest
{
    [Test]
    public void Succesfull_EndToEnd_PaymentTest()
    {
        new UserSteps(Driver).LoginByStandard_User();                      // логин под стандартным пользователем
        new ActionsWithProductsSteps(Driver)._AddToCartButtonClick();      //добавление товара в тележку
        
        NavigationSteps navigationSteps = new(Driver);
        CartPage cartPage = navigationSteps.NavigateToCartByButtonCartClick(); // переход в тележку по клику кнопки с тележкой
        Assert.That(cartPage.IsPageOpened);                      // проверка что страница открылась
        Assert.That(!cartPage.СartIsEmpty());                    // проверка, что в тележке есть товар
        navigationSteps.NavigateToUserInfoPageByClickCheckoutButton();     // нажатие на кнопку Checkout c переходом на страницу с пользовательской информацией

        CheckoutOverviewPage checkoutOverviewPage = navigationSteps.NavigateToCheckoutOverviewPageWithValidInputInfo(); // переход на страницу с информацией о заказе с заполнением checkoutOverviewPage валидной информацией
        Assert.Multiple(() =>
        {
            Assert.That(checkoutOverviewPage.IsPageOpened());        // проверка что страница открылась
            Assert.That(checkoutOverviewPage.IsTotalSumNotZero());   // проверка что общая сумма заказа не равна нулю
        }); 
        
        CheckoutCompletePage checkoutCompletePage = navigationSteps.NavigateToCheckoutCompletePageByFinishButtonClick();         // нажатие на кнопку Finish c переходом на страницу c благодарностью за заказ
        Assert.That(checkoutCompletePage.IsPageOpened);          // проверка что страница открылась
        navigationSteps.ClickToThreeStripesMenuPage(); // вызов доп меню с настройками 
        navigationSteps.BackToProductsPageButtonClick(); // возврат в ProductsPage через кнопку Finish
    }
}
 

