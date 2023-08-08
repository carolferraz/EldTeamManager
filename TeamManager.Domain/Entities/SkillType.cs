using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManager.Domain.Entities
{
    [Table("skill_type")]
    public class SkillType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
