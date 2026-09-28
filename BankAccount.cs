class BankAccount
{
    private double balance;

    public double Balance
    {
        get
        {
            return balance;
        }

        set
        {
            if (value >= 0)
            {
                balance = value;
            }
        }
    }
}