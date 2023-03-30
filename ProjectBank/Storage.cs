using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ProjectBank;

public static class Storage
{

    static string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\users.json";
    private static string json;

    public static void AddUser(User user)
    {
        string userInFile = "";

        if(File.Exists(filePath))
            userInFile = File.ReadAllText(filePath);
        var listUsers = JsonConvert.DeserializeObject<List<object>>(userInFile);
        
        if (listUsers == null)
            listUsers = new List<object>();

        listUsers.Add(user);

        JsonSerializerSettings settings = new JsonSerializerSettings { Formatting = Formatting.Indented};

        //Convert user to Json
        json = JsonConvert.SerializeObject(listUsers, settings);
        //Crea un archivo si este no existe
        File.WriteAllText(filePath, json);
    }

    public static List<User> GetNewUsers()
    {
        string userInFile = "";
        var listUsers = new List<User>();

        if (File.Exists(filePath))
            userInFile = File.ReadAllText(filePath);
        var listObjects = JsonConvert.DeserializeObject<List<object>>(userInFile);

        if (listUsers == null)
            return listUsers;

        foreach (object item in listObjects)
        {
            User newUser;
            JObject user = (JObject)item;

            if (user.ContainsKey("TaxRegime"))
                newUser = user.ToObject<Client>();
            else
                newUser = user.ToObject<Employee>();

            listUsers.Add(newUser);

        }

        var newUserList = listUsers.Where(user => user.GetRegisterDate().Date.Equals(DateTime.Today)).ToList();

        return newUserList;
    }

}

