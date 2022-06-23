using ECommerceWebApi.ViewModels;

namespace EcommerceWebApi.Interfaces
{
    public interface IJWTMangerRepository
    {
        Tokens Authenicate(LoginViewModel users, bool IsRegister);
    }
}