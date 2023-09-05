using AutoMapper;
using RedBadgeFinal.Data.Data;
using RedBadgeFinal.Data.Entities;
using RedBadgeFinal.Models.WeaponModels;
using RedBadgeFinal.Services.BusinessLogic.IServices;
using System.Data.Entity;

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
    }
}
