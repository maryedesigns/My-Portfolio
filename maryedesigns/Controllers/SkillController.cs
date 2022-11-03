using maryedesigns.Models;
using maryedesigns.Services.IServices;
using maryedesigns.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace maryedesigns.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillServices _skill;

        public SkillController(ISkillServices skill)
        {
            _skill = skill;

        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id == 0)
                return NotFound();
            var data = _skill.GetById(id);
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ListOfSkillsViewModel skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }
            else
            {
                await _skill.EditByDetails(skill);
                TempData["Success"] = "The item has been successfully Updated!";

            }

            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(ListOfSkillsViewModel skill)
        {
            if (ModelState.IsValid)
            {
                await _skill.Create(skill);
                TempData["Success"] = "The item has been successfully Created!";
            }
            return RedirectToAction("Dashboard", "Admin");
        }
        public async Task<IActionResult> Delete(Skill skill)
        {
            if (ModelState.IsValid)
            {
                await _skill.RemovedData(skill);
                TempData["Success"] = "The details has been deleted successfully";
            }

            return RedirectToAction("Dashboard", "Admin");

        }
        public IActionResult Details()
        {
            return View();
        }
    }
}

