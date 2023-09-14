using AutoMapper;
using RedBadgeFinal.Data.Data;
using RedBadgeFinal.Data.Entities;
using RedBadgeFinal.Models.WeaponModels;
using RedBadgeFinal.Services.BusinessLogic.IServices;
using Microsoft.EntityFrameworkCore;
using RedBadgeFinal.Models.ElementModels;

namespace RedBadgeFinal.Services.BusinessLogic
{
    public class WeaponServices : IWeaponService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public WeaponServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateWeapon(WeaponCreate model)
        {
            var weapon = _mapper.Map<Weapon>(model);
            await _context.Weapons.AddAsync(weapon);
            return await _context.SaveChangesAsync() > 0;
        }

		public async Task<bool> DeleteWeapon(int id)
		{
			var weapon = await _context.Weapons
				.FirstOrDefaultAsync(e => e.Id == id);

			if (weapon == null) return false;

			_context.Weapons.Remove(weapon);
			return await _context.SaveChangesAsync() == 1;
		}

		public async Task<WeaponDetail> GetWeapon(int id)
        {
            var weapon = await _context.Weapons.FindAsync(id);
            if (weapon is null) return new WeaponDetail();

            return _mapper.Map<WeaponDetail>(weapon);
        }

        public async Task<List<WeaponListItem>> GetWeapons()
        {
            var weapons = await _context.Weapons.ToListAsync();
            return _mapper.Map<List<WeaponListItem>>(weapons);
        }

		public async Task<bool> UpdateWeapon(WeaponEdit model)
		{
			var weapon = await _context.Weapons
				.SingleOrDefaultAsync(e => e.Id == model.Id);

			if (weapon is null) return false;

			weapon.Id = model.Id;
			weapon.Type = model.Type;
			await _context.SaveChangesAsync();

			return true;
		}
	}
}
