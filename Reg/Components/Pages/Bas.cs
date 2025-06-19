public class User
{
    public string Username { get; set; }
    public string Password { get; set; } // В реальном проекте храните только хэш!
    
    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}