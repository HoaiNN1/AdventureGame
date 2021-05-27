using System.Text.Json.Serialization;

namespace Adventure.Commom.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClasses
    {
        Hunter = 1,
        Witch = 2,
        Cleric = 3,
        Assassin = 4,
        Lancer = 5
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgRaces
    {
        Human = 1,
        Elf = 2,
        Drawf = 3,
        Necromorph = 4,
        Meta_Human = 5
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgSkillTypes
    {
        Magic = 1,
        Archery = 2,
        Swordsmanship = 3,
        AssassinationArt = 4,
        HealingArt = 5
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgWeaponTypes
    {
        Sword = 1,
        Dagger = 2,
        Book = 3,
        Staff = 4,
        Bow = 5
    }
}