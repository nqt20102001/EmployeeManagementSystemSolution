
using BaseLibrary.DTOs;
using BaseLibrary.Reponses;

namespace ServerLibrary.Responsitories.Contracts
{
    public interface IUserAccount
    {
        Task<GeneralRespone> CreateAsync(Register user);
        Task<LoginRespone> SignInAsync(Login user);
    }
}
