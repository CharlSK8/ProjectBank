using ProjectBank;

Client Carlos = new(1, "Carlos", "carlos@gmail.com", 50000, 'M');
Storage.AddUser(Carlos);
Console.WriteLine(Carlos.ShowData());
/*
if (args.Length == 0)
    EmailService.SendMail();
else
    foreach (var item in args)
    {
        Console.WriteLine(item);
    }*/