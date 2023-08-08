using Entity = TeamManager.Domain.Entities;

namespace TeamManager.Application.Services.SkillType
{
    public interface ISkillTypeService
    {
        public IEnumerable<Entity.SkillType> ListAll();
        public Entity.SkillType GetById(int id);
        public void Delete(int id);
        public void Save(Entity.SkillType skillType);
    }
}