namespace NUnit_HW
{
    /*
     Реализовать два метода Div(int a, int b) and Div(double a, double b) в классе Calculator
Написать тесты на валидацию данных методов с использованием всех изученных атрибутов. Обязательно проверить деление на 0.
*/
    [TestFixture, Category("DivideDouble")]
    public class Tests1
    {
        [Test(Description = "Деление Double на Double")]
        [Order(1), Category("Positive")]
        [MaxTime(6)]
        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesDouble))]
        public void DivideDoubleTest(double a, double b, double result)
        {
            Assert.That(Calculator.Divide(a, b), Is.EqualTo(result));
        }

        [Test, Ignore("Ignoring this test due Issue")]
        [Order(2), Category("IgnoringTest")]
        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesDouble))]
        public void IgnoreTest(double a, double b, double result)
        {
            Assert.That(Calculator.Divide(a, b), Is.EqualTo(result));
        }

        [Test(Description = "Деление Double на Double без выноса тестовых данных в отдельный класс 1")]
        [Order(3), Category("Positive")]
        [TestCase(18.0, 2.0, 9.0)]
        public void DivideDoubleTest2Test1(double a, double b, double result)
        {
            Assert.That(Calculator.Divide(a, b), Is.EqualTo(result));
        }

        [Test(Description = "Деление double на double без выноса тестовых данных в отдельный класс 2")]
        [Order(4), Category("Positive")]
        [TestCase(18.0, 1.0, ExpectedResult = 18.0)]
        public double DivideDoubleTest2(double a, double b) =>
            Calculator.Divide(a, b);

        [Test(Description = "Деление 0 на double")]
        [Order(5), Category("Positive")]
        public void ZeroDivideDoubleTest()
        {
            Assert.That(Calculator.Divide(0, 18.0), Is.EqualTo(0));
        }

        [Test(Description = "Деление double на 0")]
        [Order(6), Category("Negative")]
        public void DivideByZeroDoubleTest()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(18.0, 0));
        }
    }

}