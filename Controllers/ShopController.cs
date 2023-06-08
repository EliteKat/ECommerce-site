using ECommerce.Models;
using ECommerce.Models.Identity;
using ECommerce.Models.Shop;
using ECommerce.ViewModels.Shop;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public ShopController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/{id:int}")]
        public async Task<IActionResult> AddOrder(int orderId)
        {
            var user = _userManager.GetUserAsync(HttpContext.User);

            UserOrders newOrder = new()
            {
                UserId = user.Id,
                OrderId = orderId
            };

            await _context.UserOrders.AddAsync(newOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Shop");  
        }

        [HttpPost]
        [Route("/{id:int}")]
        public async Task<IActionResult> RemoveOrder(int orderId)
        {
			var order = await _context.UserOrders.FirstOrDefaultAsync(m => m.Id == orderId);

			_context.UserOrders.Remove(order!);
            await _context.SaveChangesAsync();
            return RedirectToAction("Cart", "Shop");  
        }

        public async Task<IActionResult> Cart()
        {
			var user = await _userManager.GetUserAsync(HttpContext.User);
			var userOrders = _context.UserOrders.Where(uo => uo.UserId == user!.Id).ToListAsync();

			ViewData["UserOrders"] = await userOrders;
			return View();
        }

        public async Task<IActionResult> Checkout()
        {
			var user = await _userManager.GetUserAsync(HttpContext.User);
            var userOrders = _context.UserOrders.Where(uo => uo.UserId == user!.Id).ToListAsync();

            ViewData["UserOrders"] = await userOrders;
			return View();
        }

        [HttpPost]
        public async Task<IActionResult> CheckoutConfirm(CheckoutViewModel viewModel)
        {
			var user = await _userManager.GetUserAsync(HttpContext.User);
			Checkout newCheckout = new()
            {
                UserId = user!.Id,
                Fullname = viewModel.Fullname,
                Address = viewModel.Address,
                ZipCode = viewModel.ZipCode,
                City = viewModel.City,
                Country = viewModel.Country,
                CardNumber = viewModel.CardNumber,
                ExpiryMonth = viewModel.ExpiryMonth, 
                ExpiryYear = viewModel.ExpiryYear,
                CardCode = viewModel.CardCode
	        };

            await _context.Checkouts.AddAsync(newCheckout);
            await _context.SaveChangesAsync();
			return RedirectToAction("Shop", "Confirmation");
        }

		public IActionResult Confirmation()
		{
			return View();
		}
	}
}
