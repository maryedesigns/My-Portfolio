using AutoMapper;
using maryedesigns.Data.IRepository;
using maryedesigns.Models;
using maryedesigns.Services.IServices;
using maryedesigns.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace maryedesigns.Services
{
    public class ExperienceServices : IExperienceServices
    {
        private readonly IExperienceRepository _experience;
        private readonly IMapper _mapper;

        public ExperienceServices(IExperienceRepository experience, IMapper mapper)
        {
            _experience = experience;
            _mapper = mapper;

        }
        public async Task<IEnumerable<Experience>> AllList()
        {
            return await _experience.GetAll();
        }

        public async Task<Experience> GetById(int id)
        {
            return await _experience.GetByIdAsync(id);
        }

        public async Task<bool> Create(ListOfExperiencesViewModel expView)
        {
            var addExp = _mapper.Map<Experience>(expView);
            return await _experience.Add(addExp);
        }
        public async Task<bool> EditByDetails(ListOfExperiencesViewModel expView)
        {
            var editInfo = _mapper.Map<Experience>(expView);
            return await _experience.UpdateDataToDb(editInfo);
        }

        public async Task<bool> RemovedData(Experience experience)
        {
            return await _experience.DeleteFromDb(experience);
        }
    }
}

