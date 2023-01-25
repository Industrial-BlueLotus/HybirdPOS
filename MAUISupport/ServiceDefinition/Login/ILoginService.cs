using MAUISupport.ViewModels;
using MAUISupport.Shared;


namespace MAUISupport.ServiceDefinition.Login
{
    public interface ILoginService
    {
        Task<TokenResponse> Login(TokenRequest tok);
        Task<IResult> Logout();
        //Task<CompletedUserAuth> GetUserInformation();
    }
}
