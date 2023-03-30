namespace ProjectBank;

public class Client : User
{
    public char TaxRegime { get; set; }

    public Client() { }

    //base: hace referencia a la clase padre
    public Client(int id, string name, string email, decimal balance, char TaxRegime ) : base(id, name, email, balance)
    {
        this.TaxRegime = TaxRegime;
        SetBalance(Balance);
    }

    public override void SetBalance(decimal amount)
    {
        base.SetBalance(amount);

        if (TaxRegime.Equals('M'))
            base.Balance += (amount * 0.02m);
    }

    public override string ShowData()
    {
        return base.ShowData() + $", Regimen fiscal: {this.TaxRegime}";
    }

}

