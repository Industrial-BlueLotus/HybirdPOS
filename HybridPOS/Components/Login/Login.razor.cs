using Microsoft.AspNetCore.Components;
using MudBlazor;
using MAUISupport.ViewModels;


namespace HybridPOS.Components.Login
{
    public partial class Login : ComponentBase
    {

        private TokenRequest _tokenModel = new();
        private bool IsLoginSuccessFull = false;
        private string Message = "Login with your Credentials.";
        private string className = "";
        protected override async Task OnInitializedAsync()
        {


        }


        private async Task SubmitAsync()
        {
            Message = "Login with your Credentials.";
            className = "";
            StateHasChanged();
            if (string.IsNullOrEmpty(_tokenModel.UserName) || string.IsNullOrEmpty(_tokenModel.Password))
            {

                _snackbar.Add("Username or Password Empty!");

            }
            else
            {
                try
                {
                    var result = await _loginService.Login(_tokenModel);
                }
                catch (Exception ex)
                {
                    _snackbar.Add("Login Request Failed!");
                }
            }
            StateHasChanged();
        }

        private bool _passwordVisibility;
        private InputType _passwordInput = InputType.Password;
        private string _passwordInputIcon = Icons.Material.Filled.VisibilityOff;

        void TogglePasswordVisibility()
        {
            if (_passwordVisibility)
            {
                _passwordVisibility = false;
                _passwordInputIcon = Icons.Material.Filled.VisibilityOff;
                _passwordInput = InputType.Password;
            }
            else
            {
                _passwordVisibility = true;
                _passwordInputIcon = Icons.Material.Filled.Visibility;
                _passwordInput = InputType.Text;

            }
        }


    }
}
