using System.ComponentModel.Design;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string selection = "";
            int amount = 0;
            BankAccount account = new BankAccount();
            do
            {
                Console.WriteLine("Press 1 to see account balance");
                Console.WriteLine("Press 2 to make a deposit");
                Console.WriteLine("Press 3 to exit");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Account balance is $" + account.GetBalance());
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Enter deposit amount");
                        amount = int.Parse(Console.ReadLine());
                        account.Deposit(amount);
                        Console.WriteLine();
                        break;
                    case "3":
                        break;
                }

            } while (selection != "3");

        }
    }
}
