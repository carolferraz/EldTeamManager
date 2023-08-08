using TeamManager.Domain.Entities;

namespace TeamManager.Domain.Repositories
{
    public interface ISkillTypeRepository
    {
        public IEnumerable<SkillType> GetAll();
        public SkillType GetById(int id);
        public void Delete(int id);
        public void Insert(SkillType skillType);
        public void Update(SkillType skillType);
    }
}