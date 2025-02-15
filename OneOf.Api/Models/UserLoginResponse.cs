namespace OneOf.Api.Models
{
    public record UserLoginResponse(string FullName, string AccessToken, string RefreshToken);
}
