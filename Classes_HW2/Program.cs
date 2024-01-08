namespace Classes_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card1 = new CreditCard(1, 500);
            CreditCard card2 = new CreditCard(2, 375);
            CreditCard card3 = new CreditCard(3, 125);

            card1.InfoCreditCard();
            card1.DepositeToBill(220);
            card1.InfoCreditCard();

            card2.InfoCreditCard();
            card2.DepositeToBill(25);
            card2.InfoCreditCard();

            card3.InfoCreditCard();
            card3.DepositeWithdraw(25);
            card3.InfoCreditCard();
        }
    }
}