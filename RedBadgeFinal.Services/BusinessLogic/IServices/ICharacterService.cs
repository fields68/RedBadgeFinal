﻿using RedBadgeFinal.Models.CharacterModels;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    public interface ICharacterService
    {
        Task<bool> CreateCharacter(CharacterCreate model);
        Task<bool> UpdateCharacter(CharacterEdit model);
        Task<bool> DeleteCharacter(int id);
        Task<CharacterDetail> GetCharacter(int id);
		Task<List<CharacterListItem>> GetCharactersbyRegion(int Regionid);
		Task<List<CharacterListItem>> GetCharactersbyElement(int Elementid);
		Task<List<CharacterListItem>> GetCharactersbyWeapon(int Weaponid);
        Task<List<CharacterListItem>> GetCharacters();
    }
}
