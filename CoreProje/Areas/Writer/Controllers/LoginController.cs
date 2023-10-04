using CoreProje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreProje.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]

    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _singInManager;   //Bu bir identityden gelen class'tır.

        public LoginController(SignInManager<WriterUser> singInManager)
        {
            _singInManager = singInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _singInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new {area="Writer"});
                }
            }
            else
            {
                ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _singInManager.SignOutAsync();
            return RedirectToAction("Index","Login");
        }

    }
}
