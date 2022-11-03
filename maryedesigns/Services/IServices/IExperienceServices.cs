using maryedesigns.Models;
using maryedesigns.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace maryedesigns.Services.IServices
{
    public interface IExperienceServices
    {
        Task<IEnumerable<Experience>> AllList();
        Task<Experience> GetById(int id);
        Task<bool> Create(ListOfExperiencesViewModel expView);
        public Task<bool> EditByDetails(ListOfExperiencesViewModel expView);
        Task<bool> RemovedData(Experience experience);

    }
}
