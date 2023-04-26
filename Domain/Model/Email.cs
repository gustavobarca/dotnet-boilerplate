using System.Net.Mail;

namespace Domain.Model;

public class Email
{
    public string Value { get; }

    protected Email() { }

    public Email(string email)
    {
        var lowerCaseEmail = email.ToLower().Trim();

        if (!MailAddress.TryCreate(lowerCaseEmail, out _))
        {
            throw new FormatException("Email inválido");
        }

        Value = lowerCaseEmail;
    }

    public override string ToString()
    {
        return Value;
    }

    public string GetUsername()
    {
        return Value.Split("@")[0];
    }

    public string GetDomain()
    {
        return Value.Split("@")[1];
    }

    public static bool operator ==(Email? email1, Email? email2)
    {
        if (email1 == null || email2 == null) return false;

        return email1.Equals(email2);
    }

    public static bool operator !=(Email? email1, Email? email2)
    {
        if (email1 == null || email2 == null) return false;

        return !email1.Equals(email2);
    }

    public override bool Equals(object? value)
    {
        if (value == null) return false;

        var email = (Email)value;

        return email.Value == this.Value;
    }

  public override int GetHashCode()
  {
    return base.GetHashCode();
  }
}
