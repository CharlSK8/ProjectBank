using Newtonsoft.Json;

namespace ProjectBank;

public class User
{
    //prop
    //Anotacion para realizar la serealizacion
    [JsonProperty]
    protected int Id { get; set; }
    [JsonProperty]
    protected string Name { get; set; }
    [JsonProperty]
    protected string Email { get; set; }
    [JsonProperty]
    protected decimal Balance { get; set; }
    [JsonProperty]
    protected DateTime RegisterDate { get; set; }

    public User() { }

    public User(int id, string name, string email, decimal balance)
    {
        this.Id = id;
        this.Name = name;
        this.Email = email;
        this.RegisterDate = DateTime.Now;
    }

    public DateTime GetRegisterDate()
    {
        return RegisterDate;
    }

    public virtual string ShowData()
    {
        return $"Id: {this.Id}, Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de registro: {this.RegisterDate}.";
    }
    //virtual: el elemento puede ser sobre escrito 
    public string ShowData(string messageInitial)
    {
        return $"{messageInitial}. Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de registro: {this.RegisterDate.ToShortDateString}";
    }

    public virtual void SetBalance(decimal amount)
    {
        decimal cuantity = 0;
        if (amount < 0)
            cuantity = 0;
        else
            cuantity = amount;
        Balance += cuantity;
    }

}
