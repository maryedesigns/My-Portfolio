using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using maryedesigns.Data.IRepository;
using maryedesigns.Models;
using maryedesigns.Data;

namespace maryedesigns.Data.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly PortDbContext _context;

        public ProjectRepository(PortDbContext context)
        {
            _context = context;

        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _context.Project.ToListAsync();
        }

        public async Task<Project> GetByIdAsync(int id)
        {
            return await _context.Project.Include(i => i.Name).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<bool> Add(Project project)
        {
            _context.Add(project);
            return await Save();
        }
        public async Task<bool> UpdateDataToDb(Project project)
        {
            _context.Project.Update(project);
            return await Save();
        }

        public async Task<bool> DeleteFromDb(Project project)
        {
            _context.Project.Remove(project);
            return await Save();
        }
        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }
    }
}
