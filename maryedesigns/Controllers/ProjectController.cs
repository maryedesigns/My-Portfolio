using maryedesigns.Models;
using maryedesigns.Services.IServices;
using maryedesigns.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace maryedesigns.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectServices _project;

        public ProjectController(IProjectServices project)
        {
            _project = project;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id == 0)
                return NotFound();
            var data = _project.GetById(id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ListOfProjectViewModel project)
        {
            if (!ModelState.IsValid)
            {
                return View(project);
            }
            else
            {
                await _project.EditByDetails(project);
                TempData["Success"] = "The item has been successfully Updated!";

            }

            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(ListOfProjectViewModel project)
        {
            if (ModelState.IsValid)
            {
                await _project.Create(project);
                TempData["Success"] = "The item has been successfully Created!";
            }
            return RedirectToAction("Dashboard", "Admin");
        }
        public async Task<IActionResult> Delete(Project project)
        {
            if (ModelState.IsValid)
            {
                await _project.RemovedData(project);
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

