using Account;
using SavingsAccounts;
using CurrentAccounts;
using FixedDepositAccounts;
namespace InheritanceAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount(1234567, "Chinna Saidaiah", "Nekarikallu", 8000);
            sa.Withdraw(250);
            CurrentAccount ca = new CurrentAccount(098907, "Chinna Saidaiah", "Nekarikallu", 8000);
            ca.Withdraw(350);
        }
    }
}
