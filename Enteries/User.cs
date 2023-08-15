using System.Runtime.Serialization;

[DataContract]
public class User
{
    [DataMember]
    public string Username { get; set; }
    [DataMember]
    public string Password { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password; // Note: In a real-world scenario, you should hash the password before saving it.
    }
}
