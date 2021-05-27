using System.Collections.Generic;

namespace Adventure.Commom.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoint { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int s_Attack { get; set; } = 10;
        public int Strength { get; set; } = 10;
        public int Agility { get; set; } = 10;
        public int Vitality { get; set; } = 10;
        public int Intelligense { get; set; } = 10;
        public RpgClasses Class { get; set; } = RpgClasses.Hunter;
        public RpgRaces Race { get; set; } = RpgRaces.Human;
        //public User User { get; set; }
        //public int UserId { get; set; }
        //public Weapon Weapon { get; set; }
        //public List<CharacterSkill> CharacterSkills { get; set; }
        //public int Fights { get; set; }
        //public int Victories { get; set; }
        //public int Defeats { get; set; }
    }
}