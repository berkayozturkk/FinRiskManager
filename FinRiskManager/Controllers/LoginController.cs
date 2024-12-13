using FinRiskManager.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinRiskManager.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError(string.Empty, "Username and Password are required.");
                return View();
            }

            var user = await _userService.Authenticate(username, password);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                return View();
            }
            // Kullanıcı doğrulandıysa tenantId'yi session'a veya başka bir yere kaydedebiliriz.
            // Örnek olarak session'a kaydediyoruz
            //HttpContext.Session.SetString("TenantId", user.TenantId.ToString());

            // Başarılı giriş sonrası yönlendirme
            return RedirectToAction("Index", "Home"); // Örneğin, ana sayfaya yönlendiriyoruz
        }
    }
}

