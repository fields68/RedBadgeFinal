using AutoMapper;
using RedBadgeFinal.Data.Data;
using RedBadgeFinal.Data.Entities;
using RedBadgeFinal.Models.CharacterModels;
using RedBadgeFinal.Services.BusinessLogic.IServices;
using System.Data.Entity;

namespace RedBadgeFinal.Services.BusinessLogic
{
    public class CharacterServices : ICharacterService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public CharacterServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateCharacter(CharacterCreate model)
        {
            var chara = _mapper.Map<Character>(model);
            await _context.Characters.AddAsync(chara);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteCharacter(int id)
        {
            var chara = await _context.Characters.FindAsync(id);
            if (chara is null) return false;
            _context.Characters.Remove(chara);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<CharacterDetail> GetCharacter(int id)
        {
            var chara = await _context.Characters.FindAsync(id);
            if (chara is null) return new CharacterDetail();

            return _mapper.Map<CharacterDetail>(chara);
        }

        public async Task<List<CharacterListItem>> GetCharacters()
        {
            var chara = await _context.Characters.ToListAsync();
            return _mapper.Map<List<CharacterListItem>>(chara);
        }

        public async Task<bool> UpdateCharacter(CharacterEdit model)
        {
            var chara = await _context.Characters.FindAsync(model.Id);
            if (chara is null) return false;
            chara.Name = model.Name;
            chara.Description = model.Description;
            chara.RegionId = model.RegionId;
            chara.WeaponId = model.WeaponId;
            chara.ElementId = model.ElementId;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
