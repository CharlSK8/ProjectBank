using Newtonsoft.Json;



namespace ProjectBank;

public static class Storage
{

    static string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\users.json";

    public static void AddUser(User user)
    {
        string json = "";
        //Convert user to Json
        json = JsonConvert.SerializeObject(user);
        //Crea un archivo si este no existe
        File.WriteAllText(filePath, json);
    }

}

