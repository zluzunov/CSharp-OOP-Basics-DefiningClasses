namespace Lab
{
    using System;

    public class BankAccount
    {
        private double balance;
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Tha balance can not be negative!");
                }
                balance = value;
            }
        }

        public void Deposit(Double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(Double amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{this.id}, balance {this.balance:f2}";
        }
    }

}


