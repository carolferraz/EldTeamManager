using TeamManager.Domain.Repositories;
using Entity = TeamManager.Domain.Entities;

namespace TeamManager.Application.Services.SkillType
{
    public class SkillTypeService : ISkillTypeService
    {
        private readonly ISkillTypeRepository _skillTypeRepository;

        public SkillTypeService(ISkillTypeRepository skillTypeRepository)
        {
            _skillTypeRepository = skillTypeRepository;
        }
        public IEnumerable<Entity.SkillType> ListAll()
        {
            var skillType = _skillTypeRepository.GetAll();
            return skillType;
        }
        public Entity.SkillType GetById(int id)
        {
            return _skillTypeRepository.GetById(id);
        }
        public void Delete(int id)
        {
            _skillTypeRepository.Delete(id);
        }

        public void Save(Entity.SkillType skillType)
        {
            if (skillType.Id == 0)
                _skillTypeRepository.Insert(skillType);
            else
                _skillTypeRepository.Update(skillType);
        }
    }
}
