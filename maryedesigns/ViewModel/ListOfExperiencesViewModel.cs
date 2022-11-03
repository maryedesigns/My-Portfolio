using System;

namespace maryedesigns.ViewModel
{
    public class ListOfExperiencesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Role { get; set; }

        public DateTime Year { get; set; } = DateTime.Now;
    }
}
