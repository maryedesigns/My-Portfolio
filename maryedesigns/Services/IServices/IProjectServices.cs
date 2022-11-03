using maryedesigns.Models;
using maryedesigns.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace maryedesigns.Services.IServices
{
    public interface IProjectServices
    {
        Task<IEnumerable<Project>> AllList();
        Task<Project> GetById(int id);
        Task<bool> Create(ListOfProjectViewModel project);
        Task<bool> EditByDetails(ListOfProjectViewModel project);
        Task<bool> RemovedData(Project project);
    }
}
