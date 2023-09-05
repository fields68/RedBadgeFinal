using RedBadgeFinal.Models.CharacterModels;

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
