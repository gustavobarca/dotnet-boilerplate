using Domain.Model;
using Domain.Services;

namespace Application;

public class UserService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

    public async Task Create(string name, string email)
    {
        var user = new User(name, email);
        await _unitOfWork.Users.Store(user);
        await _unitOfWork.Complete();
    }
}