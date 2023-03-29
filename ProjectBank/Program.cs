using ProjectBank;

User User1 = new(1, "Carlos Andres", "carlos@gmail.com", 1000);
Console.WriteLine(User1.ShowData());
Console.WriteLine(User1.ShowData("Infomacion"));
Storage.AddUser(User1);