using MasrafTakipMVCProje.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasrafTakipMVCProje.Controllers
{
    public class HarcamaTipiController : Controller
    {
        private readonly MasrafTakipContext context;
        public HarcamaTipiController(MasrafTakipContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var harcamaTipis = context.HarcamaTipleri.ToList();

            return View(harcamaTipis);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HarcamaTipi harcamaTipi)
        {
            if (ModelState.IsValid)
            {
                context.Add(harcamaTipi);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(harcamaTipi);
        }
    }
}
