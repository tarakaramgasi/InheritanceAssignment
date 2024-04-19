namespace Account
{
    public class BaseAccount
    {
        long accountNumber;
        string accountName;
        string accountHolderAddress;
        int accountBalance;

        public BaseAccount(long accountNo, string name, string address, int balance)
        {
            accountNumber = accountNo;
            accountName=name;
            accountBalance = balance;
            accountHolderAddress = address;
        }

        public long AccountNumber 
        {
            get 
            {
                return accountNumber;
            } 
            set
            {
                accountNumber=value;
            }
        }
        public string AccountName
        {
            get
            {
                return accountName;
            }
            set
            {
                accountName = value;
            }
        }

        public string AccountHolderAddress
        {
            get
            {
                return accountHolderAddress;
            }
            set
            {
                accountHolderAddress = value;
            }
        }
        public int AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                accountBalance = value;
            }
        }



        public void Deposits(int amount) 
        {
            accountBalance += amount;
        }
        public virtual void Withdraw(int amount) 
        { 
            accountBalance-= amount;
        }
    }
}
