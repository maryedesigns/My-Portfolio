using AutoMapper;
using maryedesigns.Data.IRepository;
using maryedesigns.Models;
using maryedesigns.Services.IServices;
using maryedesigns.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace maryedesigns.Services
{
    public class ProjectServices : IProjectServices
    {
        private readonly IProjectRepository _project;
        private readonly IMapper _mapper;

        public ProjectServices(IProjectRepository project, IMapper mapper)
        {
            _project = project;
            _mapper = mapper;

        }
        public async Task<IEnumerable<Project>> AllList()
        {
            return await _project.GetAll();
        }

        public async Task<Project> GetById(int id)
        {
            return await _project.GetByIdAsync(id);
        }
        public async Task<bool> Create(ListOfProjectViewModel project)
        {
            var addProject = _mapper.Map<Project>(project);
            return await _project.Add(addProject);
        }
        public async Task<bool> EditByDetails(ListOfProjectViewModel project)
        {
            var editInfo = _mapper.Map<Project>(project);
            return await _project.UpdateDataToDb(editInfo);
        }

        public async Task<bool> RemovedData(Project project)
        {
            return await _project.DeleteFromDb(project);
        }
    }
}
