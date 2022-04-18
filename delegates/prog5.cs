using System;

namespace BankingDomain2
{
    class HDFCBank
    {
        public int accountNumber { get; set; }
        public string? customerName { get; set; }
        public float balance { get; set; }

        public event EventHandler? UnderBalance;
        public event EventHandler? BalanceZero;

        public void Withdraw(float withdrawAmt)
        {
            if (balance == -1000)
            {
                onBalanceZero(EventArgs.Empty);
            }
            else
            {
                if (balance + 1000 >= withdrawAmt)
                {
                    balance -= withdrawAmt;
                }
                else
                {
                    onUnderBalance(EventArgs.Empty);
                }
            }
        }

        public void Deposit(float depositAmt)
        {
            balance += depositAmt;
        }

        public void Display()
        {
            Console.WriteLine("Customer Name: {0}", customerName);
            Console.WriteLine("Account Number: {0}", accountNumber);
            Console.WriteLine("Balance: {0}", balance);
        }

        protected void onUnderBalance(EventArgs e)
        {
            Console.WriteLine("Transaction cannot be continued as balance is insufficient");
            UnderBalance?.Invoke(this, e);
        }

        protected void onBalanceZero(EventArgs e)
        {
            Console.WriteLine("Transaction cannot be continued below specified limit of Rs.-1000");
            BalanceZero?.Invoke(this, e);
        }

        public static void Main()
        {
            HDFCBank obj = new HDFCBank
            {
                accountNumber = 1234,
                customerName = "Kayden Break",
                balance = 2000.0F
            };

            int ch = 0;

            do
            {
                Console.WriteLine("1. Withdraw\n2. Deposit\n3. Display Balance\n4. Exit");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Amount to be withdrawn");
                        float wAmt = Convert.ToSingle(Console.ReadLine());
                        obj.Withdraw(wAmt);
                        break;

                    case 2:
                        Console.WriteLine("Enter Amount to be deposited");
                        float dAmt = Convert.ToSingle(Console.ReadLine());
                        obj.Deposit(dAmt);
                        break;

                    case 3:
                        obj.Display();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice...");
                        break;
                }
            } while (ch != 4);
        }
    }
}
