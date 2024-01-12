namespace ConsoleApp1
{
    internal class Bank
    {
        int _balance;
        int _password;
        public int Balance
        {
            get => _balance;
            set => _balance = value;
        }
        public int Password
        {
            get => _password;
            set => _password = value;
        }
        public Bank(int balance, int password)
        {
            Balance = balance;
            Password = password;
        }
        public void AddBalance(int balance)
        {
            Balance += balance;
        }
        public void RemoveBalance(int balance)
        {
            if (balance > Balance)
                throw new Exception("Balansinizda kifayet qeder mebleg movcud deyil.");
            else
                Balance -= balance;
        }

    }
}
