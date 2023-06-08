using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace ECommerce.Models.Identity
{
	public class User : IdentityUser<int>
	{
		public string Firstname { get; set; } = default!;
		public string Lastname { get; set; } = default!;
	}
}
