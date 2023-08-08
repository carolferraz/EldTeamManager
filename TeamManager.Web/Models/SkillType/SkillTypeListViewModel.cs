using Entity = TeamManager.Domain.Entities;

namespace TeamManager.Web.Models.SkillType
{

    public class SkillTypeListViewModel
    {
        public IEnumerable<Entity.SkillType> SkillTypes { get; set; }

        public SkillTypeListViewModel(IEnumerable<Entity.SkillType> skillTypes)
        {
            SkillTypes = skillTypes;
        }
    }
}
