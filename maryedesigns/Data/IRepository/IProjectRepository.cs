using System.Collections.Generic;
using System.Threading.Tasks;
using maryedesigns.Models;

namespace maryedesigns.Data.IRepository
{
    public interface IProjectRepository 
    {
        Task<IEnumerable<Project>> GetAll();
        Task<Project> GetByIdAsync(int id);
        Task<bool> Add(Project project);
        Task<bool> UpdateDataToDb(Project project);
        Task<bool> DeleteFromDb(Project project);
        Task<bool> Save();

    }
}
