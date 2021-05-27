using Adventure.Commom.Models;

namespace Adventure.Commom.DTOs.Character
{
    public class GetCharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HitPoint { get; set; } 
        public int Attack { get; set; } 
        public int Defense { get; set; } 
        public int s_Attack { get; set; } 
        public int Strength { get; set; } 
        public int Agility { get; set; }
        public int Vitality { get; set; }
        public int Intelligense { get; set; } 
        public RpgClasses Class { get; set; }
        public RpgRaces Race { get; set; }
    }
}
