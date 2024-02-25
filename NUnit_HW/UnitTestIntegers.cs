namespace NUnit_HW
{
    /*
     Реализовать два метода Div(int a, int b) and Div(double a, double b) в классе Calculator
Написать тесты на валидацию данных методов с использованием всех изученных атрибутов. Обязательно проверить деление на 0.
*/
    [TestFixture, Category("DivideIntegers")]
    public class Tests
    {
        [Test(Description = "Деление Integer на Integer")]
        [Order(1), Category("Positive")]
        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesInt))]
        public void DivideIntegersTest(int a, int b, int result)
        {
            Assert.That(Calculator.Divide(a, b), Is.EqualTo(result));
        }

        [Test, Ignore("Ignoring this test due Issue")]
        [Order(2), Category("IgnoringTest")]
        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesInt))]
        public void IgnoreTest(int a, int b, int result)
        {
            Assert.That(Calculator.Divide(a, b), Is.EqualTo(result));
        }

        [Test(Description = "Деление Integer на Integer без выноса тестовых данных в отдельный класс 1")]
        [Order(3), Category("Positive")]
        [TestCase(18, 2, 9)]
        public void DivideIntegersTest1(int a, int b, int result)
        {
            Assert.That(Calculator.Divide(a, b), Is.EqualTo(result));
        }

        [Test(Description = "Деление Integer на Integer без выноса тестовых данных в отдельный класс 2")]
        [Order(4), Category("Positive")]
        [TestCase(18, 1, ExpectedResult = 18)]
        public int DivideIntegersTest2(int a, int b) =>
            Calculator.Divide(a, b);

        [Test(Description = "Деление 0 на Integer")]
        [Order(5), Category("Positive")]
        public void ZeroDivideIntegersTest()
        {
            Assert.That(Calculator.Divide(0, 18), Is.EqualTo(0));
        }

        [Test(Description = "Деление Integer на 0")]
        [Order(6), Category("Negative")]
        public void DivideByZeroIntegersTest()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(18, 0));
        }
    }

}