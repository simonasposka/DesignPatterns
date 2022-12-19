namespace DesignPatterns.ChainOfResponsibility;

public class Database
{
    private Dictionary<string, string> Users;

    public Database()
    {
        Users = new Dictionary<string, string>();
        
        Users.Add("admin_username", "admin_password");
        Users.Add("user_username", "user_password");
    }

    public bool IsValidUser(string username)
    {
        return Users.ContainsKey(username);
    }

    public bool IsValidPassword(string username, string password)
    {
        return Users[username].Equals(password);
    }
}