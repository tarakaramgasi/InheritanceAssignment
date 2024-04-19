using Account;
namespace FixedDepositAccounts
{
    public class FixedDepositAccount : BaseAccount
    {
        public FixedDepositAccount(long accountNo, string name, string address, int balance) : base(accountNo, name, address, balance)
        {

        }

        public override void Withdraw(int amount)
        {
            Console.WriteLine("$1 will be charged for Fixed Deposit Account");
            AccountBalance = (AccountBalance - amount) - 1;
            Console.WriteLine("The account balance after withdrawl is " + AccountBalance);
        }
    }
}

