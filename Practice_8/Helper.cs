namespace Practice_8
{
    class Helper
    {
        private int id = 0;
        private string name = "";
        private int accountBalance = 0;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAccountBalance(int accountBalance)
        {
            this.accountBalance = accountBalance;
        }

        public int GetAccountBalance()
        {
            return accountBalance;
        }
    }
}