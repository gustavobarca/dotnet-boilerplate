namespace Domain.Model;

public interface IUserRepository
{
    Task<User?> Find(Guid id);
    Task<User> Store(User user);
}