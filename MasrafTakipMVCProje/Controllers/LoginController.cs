using Microsoft.AspNetCore.Mvc;

namespace MasrafTakipMVCProje.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(string Email, string Password)
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

            var authSettings = config.GetSection("KullaniciGiris");

            var authEmail = authSettings.GetValue<string>("Email");
            var authPassword = authSettings.GetValue<string>("Sifre");

            if (ModelState.IsValid)
            {
                {
                    if (Email == authEmail && Password == authPassword)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Error = "Girmiş olduğunuz bilgileri kontrol ediniz";
                        return View();
                    }
                }

            }
            return View();
        }
    }
}
