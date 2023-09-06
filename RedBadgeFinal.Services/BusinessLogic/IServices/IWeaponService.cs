using RedBadgeFinal.Models.ElementModels;
using RedBadgeFinal.Models.WeaponModels;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    public interface IWeaponService
    {
        Task<bool> CreateWeapon(WeaponCreate model);
		Task<bool> UpdateWeapon(WeaponEdit model);
		Task<bool> DeleteWeapon(int id);
		Task<WeaponDetail> GetWeapon(int id);
        Task<List<WeaponListItem>> GetWeapons();
    }
}
