using RedBadgeFinal.Models.WeaponModels;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    internal interface IWeaponService
    {
        Task<bool> CreateWeapon(WeaponCreate model);
        Task<WeaponDetail> GetWeapon(int id);
        Task<List<WeaponListItem>> GetWeapons();
    }
}
