using TweetWebApi.ViewModels;

namespace TweetWebApi.Interfaces
{
    public interface IJWTManagerRepository
    {
        Tokens Authenicate(LoginViewModel users, bool IsRegister);
        object Authenicate(RegisterViewModel register, bool v);
    }
}