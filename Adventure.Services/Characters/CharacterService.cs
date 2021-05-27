using Adventure.Commom.DTOs.Character;
using Adventure.Data.Context;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Services.Characters
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CharacterService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Adventure.Commom.Models.Character>> AddCharacter(Adventure.Commom.Models.Character newCharacter)
        {
            await _context.Characters.AddAsync(newCharacter);
            await _context.SaveChangesAsync();
            return  _context.Characters.Select(c => c).ToList();
        }

        public async Task<List<GetCharacterDTO>> DeleteCharacter(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetCharacterDTO>> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public async Task<GetCharacterDTO> GetCharacterById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<GetCharacterDTO> UpdateCharacter(UpdateChacterDTO updatedCharacter)
        {
            throw new NotImplementedException();
        }
    }
}
