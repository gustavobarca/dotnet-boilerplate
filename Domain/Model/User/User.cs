namespace Domain.Model;

public class User
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Email Email { get; set; }

    protected User() { }

    public User(string name, string email)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = new Email(email);
    }
}
