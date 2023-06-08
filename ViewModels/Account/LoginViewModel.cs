using ECommerce.ViewModels.Common;

namespace ECommerce.ViewModels.Account
{
    public class LoginViewModel : BaseUserCreds
    {
        public string? ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}
