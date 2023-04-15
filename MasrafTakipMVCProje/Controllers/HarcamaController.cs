using MasrafTakipMVCProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MasrafTakipMVCProje.Controllers
{
    public class HarcamaController : Controller
    {
        private readonly MasrafTakipContext context;
        public HarcamaController(MasrafTakipContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var harcama = context.Harcamalar.Include(p => p.Personeller).ToList();
            return View(harcama);
        }

        public IActionResult Create()
        {
            ViewBag.PersonelId = context.Personeller
        .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Adi + " " + s.Soyadi }).ToList();


            return View(new Harcama());
        }

        [HttpPost]
        public IActionResult Create(Harcama harcama)
        {
            if (ModelState.IsValid)
            {
                context.Add(harcama);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.PersonelId = context.Personeller
       .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Adi + " " + s.Soyadi }).ToList();
            return View(harcama);
        }
    }
}
