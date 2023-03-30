
namespace ProjectBank
{
    public class Employee : User, IPerson
    {

        public string Departament;

        public Employee() { }
        public Employee(int id, string name, string email, decimal balance, string Departament) : base(id, name, email, balance)
        {
            this.Departament = Departament;
            SetBalance(Balance);
        }

        public string getName()
        {
            return Name;
        }

        public string getCountry()
        {
            return "Colombia";
        }

        public override void SetBalance(decimal amount)
        {
            base.SetBalance(amount);

            if (!string.IsNullOrEmpty(Departament))
            {
                if (Departament.Equals("TI"))
                    Balance += (amount * 0.05m);
            }
        }

        public override string ShowData()
        {
            return base.ShowData() + $", Departamento {this.Departament}";
        }
    }
}
