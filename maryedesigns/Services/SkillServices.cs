using AutoMapper;
using maryedesigns.Data.IRepository;
using maryedesigns.Models;
using maryedesigns.Services.IServices;
using maryedesigns.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace maryedesigns.Services
{
    public class SkillServices : ISkillServices
    {
        private readonly ISkillRepository _skill;
        private readonly IMapper _mapper;

        public SkillServices(ISkillRepository skill, IMapper mapper)
        {
            _skill = skill;
            _mapper = mapper;

        }
        public async Task<IEnumerable<Skill>> AllList()
        {
            return await _skill.GetAll();
        }

        public async Task<Skill> GetById(int id)
        {
            return await _skill.GetByIdAsync(id);
        }
        public async Task<bool> Create(ListOfSkillsViewModel skill)
        {
            var addSkill = _mapper.Map<Skill>(skill);
            return await _skill.Add(addSkill);
        }
        public async Task<bool> EditByDetails(ListOfSkillsViewModel skill)
        {
            var editInfo = _mapper.Map<Skill>(skill);
            return await _skill.UpdateDataToDb(editInfo);
        }

        public async Task<bool> RemovedData(Skill skill)
        {
            return await _skill.DeleteFromDb(skill);
        }
    }
}
