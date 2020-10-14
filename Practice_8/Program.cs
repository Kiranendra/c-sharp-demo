using System;
using System.Collections;

namespace Practice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // console banking application

            int option = 0 ;
            int id = 0;
            int creditAmount = 0;
            int debitAmount = 0;
            string name = "";
            int accountBalance = 0;
            bool removed = false;
            bool updated = false;
            bool insufficientFunds = false;
            Helper helper = null;
            Helper helper2 = null;
            ArrayList objectsList = new ArrayList();

            while (true && (option != 6))
            {
                Console.WriteLine("\nChoose any one option:");
                Console.WriteLine("1. Add a new customer");
                Console.WriteLine("2. Delete a customer");
                Console.WriteLine("3. Add money to a customer account");
                Console.WriteLine("4. Withdraw money from a customer account");
                Console.WriteLine("5. View all customers");
                Console.WriteLine("6. Exit");
                option = Convert.ToInt16(Console.ReadLine());
                if (option == 6)
                {
                    break;
                }
                else
                {
                    helper = new Helper();
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("\n============");
                            Console.WriteLine("Add a new customer");
                            Console.WriteLine("============");
                            Console.Write("Enter new customer id: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            helper.SetId(id);
                            Console.Write("\nEnter customer name: ");
                            name = Console.ReadLine();
                            helper.SetName(name);
                            Console.Write("\nEnter amount to add into the customer account: ");
                            accountBalance = Convert.ToInt32(Console.ReadLine());
                            helper.SetAccountBalance(accountBalance);
                            objectsList.Add(helper);
                            break;
                        case 2:
                            removed = false;
                            Console.WriteLine("\n============");
                            Console.WriteLine("Delete a customer");
                            Console.WriteLine("============");
                            Console.Write("Enter customer id: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            foreach (var listItem in objectsList)
                            {
                                helper2 = (Helper) listItem;
                                if (helper2.GetId() == id)
                                {
                                    objectsList.Remove(listItem);
                                    removed = true;
                                    // If two items have same id's then the first added id is removed.
                                    break;
                                }
                            }
                            if (removed)
                            {
                                Console.WriteLine($"Customer with id '{id}' is removed");
                            }
                            else
                            {
                                Console.WriteLine($"Customer with id '{id}' is not found");
                            }
                            break;
                        case 3:
                            updated = false;
                            Console.WriteLine("\n============");
                            Console.WriteLine("Add money to a customer account");
                            Console.WriteLine("============");
                            Console.Write("Enter customer id: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            foreach (var listItem in objectsList)
                            {
                                helper2 = (Helper) listItem;
                                if (helper2.GetId() == id)
                                {
                                    Console.Write("Enter amount to add: ");
                                    creditAmount = Convert.ToInt32(Console.ReadLine());
                                    int currentAmount = helper2.GetAccountBalance();
                                    helper2.SetAccountBalance(currentAmount + creditAmount);
                                    updated = true;
                                    // If two items have same id's then the first added id is updated.
                                    break;
                                }
                            }
                            if (updated)
                            {
                                Console.WriteLine($"{creditAmount} is credited to the customer account with id '{id}'");
                            }
                            else
                            {
                                Console.WriteLine($"Customer with id '{id}' is not found");
                            }
                            break;
                        case 4:
                            updated = false;
                            insufficientFunds = false;
                            Console.WriteLine("\n============");
                            Console.WriteLine("Withdraw money from a customer account");
                            Console.WriteLine("============");
                            Console.Write("Enter customer id: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            foreach (var listItem in objectsList)
                            {
                                helper2 = (Helper) listItem;
                                if (helper2.GetId() == id)
                                {
                                    Console.Write("Enter amount to debit: ");
                                    debitAmount = Convert.ToInt32(Console.ReadLine());
                                    int currentAmount = helper2.GetAccountBalance();
                                    if (currentAmount >= debitAmount)
                                    {
                                         // If two items have same id's then the first added id is updated.
                                        helper2.SetAccountBalance(currentAmount - debitAmount);
                                        updated = true;
                                    }
                                    else
                                    {
                                        insufficientFunds = true;
                                    }
                                    break;
                                }
                            }
                            if (updated)
                            {
                                Console.WriteLine($"{debitAmount} is debited from the customer account with id '{id}'");
                            }
                            else if (insufficientFunds)
                            {
                                Console.WriteLine("Insufficient funds");
                            }
                            else
                            {
                                Console.WriteLine($"Customer with id '{id}' is not found");
                            }
                            break;
                        case 5:
                            Console.WriteLine("\n============");
                            Console.WriteLine("View all customers");
                            Console.WriteLine("============");
                            foreach (var listItem in objectsList)
                            {
                                helper2 = (Helper) listItem;
                                Console.WriteLine($"{helper2.GetId()} : {helper2.GetName()} : {helper2.GetAccountBalance()}");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
            }
        }
    }
}
