using RedBadgeFinal.Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    internal interface ICharacterService
    {
        Task<bool> CreateCharacter(CharacterCreate model);
        Task<bool> UpdateCharacter(CharacterEdit model);
        Task<bool> DeleteCharacter(int id);
        Task<CharacterDetail> GetCharacter(int id);
        Task<List<CharacterListItem>> GetCharacters();
    }
}
