using System.Collections.Generic;

namespace Adventure.Commom.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int StrRequired { get; set; }
        public int AgiRequired { get; set; }
        public int VitRequired { get; set; }
        public int IntelRequired { get; set; }
        public RpgSkillTypes Type { get; set; }
        public List<CharacterSkill> CharacterSkills { get; set; }
    }
}