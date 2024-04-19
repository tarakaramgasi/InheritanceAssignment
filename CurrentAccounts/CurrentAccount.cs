using Account;
namespace CurrentAccounts
{
    public class CurrentAccount : BaseAccount
    {
        public CurrentAccount(long accountNo, string name, string address, int balance) : base(accountNo, name, address, balance)
        {

        }

        public override void Withdraw(int amount)
        {
            Console.WriteLine("$2 will be charged for current account");
            AccountBalance = (AccountBalance - amount) - 2;
            Console.WriteLine("The account balance after withdrawl is " + AccountBalance);
        }
    }
}
