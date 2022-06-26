using ECommerceAPI.ViewModels;

namespace ECommerceAPI.Interfaces
{
    public interface IJWTMangerRepository
    {
        Tokens Authenicate(LoginViewModel users, bool IsRegister);
    }
}