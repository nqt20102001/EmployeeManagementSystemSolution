
namespace BaseLibrary.Reponses
{
    public record LoginResponse(bool Flag, string Message = null!, string Token = null!, string RefreshToken = null!);
}
