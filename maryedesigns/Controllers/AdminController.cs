using maryedesigns.Data;
using maryedesigns.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace maryedesigns.Controllers
{
    public class AdminController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly PortDbContext _context;
        public AdminController(SignInManager<IdentityUser> signInManager, PortDbContext context)
        {
            _signInManager = signInManager;
            _context = context;

        }
        public IActionResult Dashboard()
        {
            DashboardViewModel dashboard = new DashboardViewModel()
            {

                Experiences = _context.Experience.ToList(),
                Skills = _context.Skill.ToList(),
                Projects = _context.Project.ToList()
            };


            return View(dashboard);
        }
    }
}

