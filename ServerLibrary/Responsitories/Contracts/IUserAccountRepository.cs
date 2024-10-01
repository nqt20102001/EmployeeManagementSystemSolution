
using BaseLibrary.DTOs;
using BaseLibrary.Reponses;

namespace ServerLibrary.Responsitories.Contracts
{
    public interface IUserAccountRepository
    {
        Task<GeneralResponse> CreateAsync(Register user);
        Task<LoginResponse> SignInAsync(Login user);
        Task<LoginResponse> RefreshTokenAsync(RefreshToken token);
    }
}
