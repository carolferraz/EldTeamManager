using Microsoft.EntityFrameworkCore;
using TeamManager.DataAccess.EF;
using TeamManager.Domain.Entities;
using TeamManager.Domain.Repositories;

namespace TeamManager.DataAccess.Repositories
{
    public class SkillTypeRepository : ISkillTypeRepository
    {
        private readonly TeamManagerDbContext _dbContext;

        public SkillTypeRepository(TeamManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<SkillType> GetAll()
        {
            var skillTypeList = _dbContext.SkillTypes
                 .AsNoTracking()
                 .OrderBy(x => x.Name)
                 .ToList();

            return skillTypeList;
        }

        public SkillType? GetById(int id)
        {
            var skillType = _dbContext.SkillTypes
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);

            return skillType;
        }

        public void Delete(int id)
        {
            var skillType = _dbContext.SkillTypes
                .FirstOrDefault(x => x.Id == id);

            if (skillType != null)
            {
                _dbContext.Remove(skillType);
                _dbContext.SaveChanges();
            }
        }

        public void Insert(SkillType skillType)
        {
            _dbContext.SkillTypes.Add(skillType);
            _dbContext.SaveChanges();
        }

        public void Update(SkillType skillType)
        {
            _dbContext.SkillTypes.Attach(skillType);
            _dbContext.Entry(skillType).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
