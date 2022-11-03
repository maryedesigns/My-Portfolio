using AutoMapper;
using maryedesigns.Models;
using maryedesigns.Services.IServices;
using maryedesigns.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace maryedesigns.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IExperienceServices _experience;
        private readonly IMapper _mapper;

        public ExperienceController(IExperienceServices experience, IMapper mapper)
        {

            _experience = experience;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id == 0)
                return NotFound();
            var data = _experience.GetById(id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ListOfExperiencesViewModel expView)
        {
            if (!ModelState.IsValid)
            {
                return View(expView);
            }
            else
            {
                await _experience.EditByDetails(expView);
                TempData["Success"] = "The item has been successfully Updated!";

            }

            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(ListOfExperiencesViewModel expView)
        {
            if (ModelState.IsValid)
            {
                await _experience.Create(expView);
                TempData["Success"] = "The item has been successfully Created!";
            }
            return RedirectToAction("Dashboard", "Admin");
        }
        public async Task<IActionResult> Delete(Experience experience)
        {
            if (ModelState.IsValid)
            {
                await _experience.RemovedData(experience);
                TempData["Success"] = "The details has been deleted successfully";
            }

            return RedirectToAction("Dashboard", "Admin");

        }

        /*public IActionResult Details()
        {
            return View();
        }*/
    }
}

