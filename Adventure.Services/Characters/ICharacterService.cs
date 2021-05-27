using Adventure.Commom.DTOs.Character;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adventure.Services.Characters
{
    public interface ICharacterService
    {
        Task<List<GetCharacterDTO>> GetAllCharacters();
        Task<GetCharacterDTO> GetCharacterById(int id);
        Task<List<Adventure.Commom.Models.Character>> AddCharacter(Adventure.Commom.Models.Character newCharacter);
        Task<GetCharacterDTO> UpdateCharacter(UpdateChacterDTO updatedCharacter);
        Task<List<GetCharacterDTO>> DeleteCharacter(int id);
    }
}
