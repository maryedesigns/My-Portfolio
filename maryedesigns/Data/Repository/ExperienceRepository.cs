using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using maryedesigns.Data;
using Microsoft.EntityFrameworkCore;
using maryedesigns.Data.IRepository;
using maryedesigns.Models;

namespace maryedesigns.Data.Repository
{
    public class ExperienceRepository:IExperienceRepository
    {
        private readonly PortDbContext _context;

        public ExperienceRepository(PortDbContext context)
        {
            _context = context;
                
        }
        public async Task<IEnumerable<Experience>> GetAll()
        {
            return await _context.Experience.ToListAsync();
        }

        public async Task<Experience> GetByIdAsync(int id)
        {
            return await _context.Experience.Include(i => i.Name).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task <bool> Add(Experience experience)
        {
            _context.Add(experience);
            return await Save();
        }
        public async Task<bool> UpdateDataToDb(Experience experience)
        {
            _context.Experience.Update(experience);
            return await Save();
        }

        public async Task<bool>  DeleteFromDb(Experience experience)
        {
            _context.Experience.Remove(experience);
            return await Save();
        }
        public async Task<bool> Save()
        {
            var saved = await  _context.SaveChangesAsync();
            return saved > 0;
        }
    }
}
