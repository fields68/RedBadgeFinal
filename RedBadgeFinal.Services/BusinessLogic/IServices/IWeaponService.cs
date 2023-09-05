using RedBadgeFinal.Models.RegionModels;
using RedBadgeFinal.Models.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    internal interface IWeaponService
    {
        Task<bool> CreateWeapon(WeaponCreate model);
        Task<WeaponDetail> GetWeapon(int id);
        Task<List<WeaponListItem>> GetWeapons();
    }
}
