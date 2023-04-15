using MasrafTakipMVCProje.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasrafTakipMVCProje.Controllers
{
    public class PersonelController : Controller
    {
        private readonly MasrafTakipContext context;
        public PersonelController(MasrafTakipContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var personeller = context.Personeller.ToList();
            return View(personeller);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Personel personel)
        {
            if (ModelState.IsValid)
            {
                context.Add(personel);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(personel);
        }
    }
}
