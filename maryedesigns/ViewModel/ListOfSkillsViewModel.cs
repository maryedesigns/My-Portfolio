using System;

namespace maryedesigns.ViewModel
{
    public class ListOfSkillsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; } = DateTime.Now;
    }
}
