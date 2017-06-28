namespace Lab
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();
            var commands = new List<string[]>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var cmdArgs = input.Split();
                commands.Add(cmdArgs);
            }

            foreach (string[] cmdArgs in commands)
            {
                var command = cmdArgs[0];

                switch (command)
                {
                    case "Create":
                        Create(cmdArgs, accounts);
                        break;
                    case "Deposit":
                        Deposit(cmdArgs, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(cmdArgs, accounts);
                        break;
                    case "Print":
                        Print(cmdArgs, accounts);
                        break;
                }
            }

            
        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts[id].ToString());
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            var amount = double.Parse(cmdArgs[2]);
            if (accounts.ContainsKey(id))
            {
                if (accounts[id].Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Withdraw(amount);
                }
                
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            var amout = double.Parse(cmdArgs[2]);
            if (accounts.ContainsKey(id))
            {
                accounts[id].Deposit(amout);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }

        }



        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
                ;
            }
            else
            {
                var acc = new BankAccount();
                acc.ID = id;
                accounts.Add(id, acc);
            }
        }
    }

}


