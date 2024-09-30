
namespace BaseLibrary.Reponses
{
    public record LoginRespone(bool Flag, string Message = null!, string Token = null!, string RefreshToken = null!);
}
