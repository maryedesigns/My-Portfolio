using System.Collections.Generic;
using System.Threading.Tasks;
using maryedesigns.Models;

namespace maryedesigns.Data.IRepository
{
    public interface ISkillRepository
    {
        Task<IEnumerable<Skill>> GetAll();
        Task<Skill> GetByIdAsync(int id);
        Task<bool> Add(Skill skill);
        Task<bool> UpdateDataToDb(Skill skill);
        Task<bool> DeleteFromDb(Skill skill);
        Task<bool> Save();

    }
}
