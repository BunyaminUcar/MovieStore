using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Data;
using MovieApp.Web.Entity;

namespace MovieApp.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly MovieContext _context;

        public LoginController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult>  Index(string username, string password)
        {

            var datavalue = _context.Users.FirstOrDefault(i => i.Username == username && i.Password == password);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,username)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("list", "Movies");
            }
            else
            {
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre.";
                return View("Index");
            }
        }
    }
}
