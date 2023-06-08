using ECommerce.ViewModels.Interfaces;

namespace ECommerce.ViewModels.Common
{
    public class BaseUserCreds : IUserCreds
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
