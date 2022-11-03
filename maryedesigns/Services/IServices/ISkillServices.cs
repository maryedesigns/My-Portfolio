using maryedesigns.Models;
using maryedesigns.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace maryedesigns.Services.IServices
{
    public interface ISkillServices
    {
        Task<IEnumerable<Skill>> AllList();
        Task<Skill> GetById(int id);
        Task<bool> Create(ListOfSkillsViewModel skill);
        Task<bool> EditByDetails(ListOfSkillsViewModel skill);
        Task<bool> RemovedData(Skill skill);
    }
}
