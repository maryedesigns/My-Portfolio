using maryedesigns.Models;
using System.Collections.Generic;

namespace maryedesigns.ViewModel
{
    public class DashboardViewModel
    {
        public ICollection<Project> Projects { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Experience> Experiences { get; set; }
    }
}
