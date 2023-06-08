using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ECommerce.Controllers
{
	[Authorize(Roles = "Admin")]
	public class AdminController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
