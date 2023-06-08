using ECommerce.ViewModels.Common;

namespace ECommerce.ViewModels.Account
{
    public class RegisterViewModel : BaseUserCreds
    {
        public string Firstname { get; set; } = default!;
        public string Lastname { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
    }
}
