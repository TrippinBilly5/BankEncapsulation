namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;
        public void Deposit(double dep)
        {
            Console.WriteLine($"Starting balance is ${balance}");
            balance += dep;
            Console.WriteLine($"After depositing ${dep}, new balance is ${balance}");
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
