using Application.Helpers;
using BlazorApp1.Shared;

namespace Application.Contracts.V1
{
    public interface IAuthenticationService
    {
        Task<SuccessResponse<UserLoginResponse>> Login(UserLoginDTO model);
        Task<SuccessResponse<RefreshTokenResponse>> GetRefreshToken(RefreshTokenDTO model);
        Task<SuccessResponse<GetSetPasswordDto>> SetPassword(SetPasswordDTO model);
        Task<SuccessResponse<object>> ResetPassword(ResetPasswordDTO model);
        Task<SuccessResponse<GetConifrmedTokenUserDto>> ConfirmToken(VerifyTokenDTO model);
    }
}
