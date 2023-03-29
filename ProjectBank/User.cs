using Newtonsoft.Json;

namespace ProjectBank;

public class User
{
    //prop
    [JsonProperty]
    private int Id { get; set; }
    [JsonProperty]
    private string Name { get; set; }
    [JsonProperty]
    private string Email { get; set; }
    [JsonProperty]
    private decimal Balance { get; set; }
    [JsonProperty]
    private DateTime RegisterDate { get; set; }

    public User()
    {

    }

    public User(int id, string name, string email, decimal balance)
    {
        this.Id = id;
        this.Name = name;
        this.Email = email;
        this.Balance = balance;
        this.RegisterDate = DateTime.Now;
    }

    public string ShowData()
    {
        return $"Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de registro: {this.RegisterDate}.";
    }

    public string ShowData(string messageInitial)
    {
        return $"{messageInitial}. Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de registro: {this.RegisterDate}";
    }

    public void SetBalance(decimal amount)
    {
        decimal cuantity = 0;
        if (amount < 0)
            cuantity = 0;
        else
            cuantity = amount;
        this.Balance = cuantity;
    }

}
