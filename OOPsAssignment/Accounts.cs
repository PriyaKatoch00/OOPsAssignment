using OOPsAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsAssignment
{
    internal class Accounts
    {

        public int account_no;
        public string customer_name;
        public string account_type;
        public string transaction_type;
        public int amount;
        public double balance;

        public Accounts(double balance, string transaction_type)
        {
            this.balance = balance;

            this.transaction_type = transaction_type;

        }

        public void credit(int amount)
        {
            this.amount = amount;
            balance = balance + amount;
        }

        public void debit(int amt)
        {
            this.amount = amount;
            balance = balance - amt;
        }

        public void accept(int account_no, string customer_name, string account_type)
        {
            this.account_no = account_no;
            this.customer_name = customer_name;
            this.account_type = account_type;
        }
        public void show()
        {
            Console.WriteLine($"AccountNo:{account_no} Name:{customer_name} AccountType:{account_type} TransactionType {transaction_type} Amount {amount} Balance{balance}");
        }
    }

    class Account_new
    {

        public static void main()
        {
            Accounts a1 = new Accounts(2000, "d");
            if (a1.transaction_type == "d")
            {
                a1.credit(300);
            }
            if (a1.transaction_type == "w")
            {
                a1.debit(200);
            }
            a1.show();

        }

    }

}
internal class Program
{
    static void Main(string[] args)
    {
        Accounts x = new Accounts(5000, "w");
        if (x.transaction_type == "d")
        {
            x.credit(1000);
        }
        if (x.transaction_type == "w")
        {
            x.debit(100);
        }
        x.accept(123, "XYZ", "SAVINGS");
        x.show();
    }
}
