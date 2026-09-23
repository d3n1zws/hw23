namespace ConsoleApp21;

public interface IUserService
{
    void AddUser(User user);
    User FindUserByEmail(string email);
}