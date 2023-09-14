using AutoMapper;
using Microsoft.AspNetCore.Http;
using RedBadgeFinal.Data.Data;
using RedBadgeFinal.Data.Entities;
using RedBadgeFinal.Models.CharacterModels;
using RedBadgeFinal.Services.BusinessLogic.IServices;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace RedBadgeFinal.Services.BusinessLogic
{
    public class CharacterServices : ICharacterService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;
        private string _ownerId;

        public CharacterServices(ApplicationDbContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _mapper = mapper;

            var userClaims = httpContextAccessor.HttpContext!.User.Identity as ClaimsIdentity;

            var value = userClaims!.Claims.FirstOrDefault();
            _ownerId = value!.Value;

            if (_ownerId == null)
                throw new Exception("User is not signed in!!!");
        }

        public async Task<bool> CreateCharacter(CharacterCreate model)
        {
            var chara = _mapper.Map<Character>(model);
            chara.OwnerId = _ownerId;
            await _context.Characters.AddAsync(chara);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteCharacter(int id)
        {
            var chara = await _context.Characters
                .Where(c=>c.OwnerId==_ownerId)
                .SingleOrDefaultAsync(x=>x.Id==id);

            if (chara is null) return false;

            if (chara?.OwnerId != _ownerId) return false;

            _context.Characters.Remove(chara);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<CharacterDetail> GetCharacter(int id)
        {
            var chara = await _context.Characters
                .Include(c=>c.Weapon)
                .Include(c=>c.Region)
                .Include(c=>c.Element)
                .Where(c => c.OwnerId == _ownerId)
                .SingleOrDefaultAsync(x => x.Id == id);

            if (chara is null) return new CharacterDetail();

            if (chara?.OwnerId != _ownerId) return null!;

            return _mapper.Map<CharacterDetail>(chara);
        }

        public async Task<List<CharacterListItem>> GetCharacters()
        {
            var chara = await _context.Characters
                .Include(c => c.Weapon)
                .Include(c => c.Region)
                .Include(c => c.Element)
                .Where(c => c.OwnerId == _ownerId)
                .ToListAsync();

            var noOwnerId = chara.Any(c=>c.OwnerId!= _ownerId);
            if (noOwnerId)
                return null;
            else
            return _mapper.Map<List<CharacterListItem>>(chara);
        }

		public async Task<List<CharacterListItem>> GetCharactersbyElement(int Elementid)
		{
			var character = await _context.Characters.Where(x => x.ElementId == Elementid).ToListAsync();
			return _mapper.Map<List<CharacterListItem>>(character);
		}

		public async Task<List<CharacterListItem>> GetCharactersbyRegion(int Regionid)
		{
			var character = await _context.Characters.Where(x => x.RegionId == Regionid).ToListAsync();
			return _mapper.Map<List<CharacterListItem>>(character);
		}

		public async Task<List<CharacterListItem>> GetCharactersbyWeapon(int Weaponid)
		{
			var character = await _context.Characters.Where(x => x.WeaponId == Weaponid).ToListAsync();
			return _mapper.Map<List<CharacterListItem>>(character);
		}

		public async Task<bool> UpdateCharacter(CharacterEdit model)
        {
            var chara = await _context.Characters
                .Where(c => c.OwnerId == _ownerId)
                .SingleOrDefaultAsync(x => x.Id == model.Id);

            if (chara is null) return false;

            if (chara?.OwnerId != _ownerId) return false;

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
