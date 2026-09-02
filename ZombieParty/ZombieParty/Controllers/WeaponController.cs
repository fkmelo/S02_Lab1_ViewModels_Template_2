using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;
using ZombieParty.ViewsModels;

namespace ZombieParty.Controllers
{
    public class WeaponController : Controller
    {
        private BaseDonnees _baseDonnees { get; set; }

        public WeaponController(BaseDonnees baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        public IActionResult Index()
        {
            List<Weapon> weaponglist = _baseDonnees.Weapons.ToList();
            return View(weaponglist);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Weapon weapon)
        {
            if (ModelState.IsValid)
            {
                // Ajouter à la BD
                _baseDonnees.Weapons.Add(weapon);
                TempData["Success"] = $"{weapon.Name} zombie type added";
                return RedirectToAction("Index");
            }

            return View(weapon);
        }
    }

}
