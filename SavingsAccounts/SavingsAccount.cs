using Account;
namespace SavingsAccounts
{
    public class SavingsAccount:BaseAccount
    {
        public SavingsAccount(long accountNo, string name, string address, int balance):base(accountNo, name, address, balance)
        {
            
        }
        public override void Withdraw(int amount)
        {
            Console.WriteLine("$0 will be charged for Savings account");
            AccountBalance = (AccountBalance - amount) - 2;
            Console.WriteLine("The account balance after withdrawl is " + AccountBalance);
        }

    }
}
