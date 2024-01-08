using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_HW2
{
    internal class CreditCard
    {
        public CreditCard(int billId, int amount)
        {
            this.billId = billId;
            this.amount = amount;
        }
       public int billId;
       public int amount;
      
        public int DepositeToBill(int money) 
        {
           return amount += money; 
        }
        public int DepositeWithdraw(int money)
        {
            return amount -= money;
        }
        public void  InfoCreditCard()
        {
            Console.WriteLine($"Номер счёта: {billId}; Остаток: {amount}");
        }

    }
}
