using RedBadgeFinal.Models.RegionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    internal interface IRegionService
    {
        Task<bool> CreateRegion(RegionCreate model);
        Task<RegionDetail> GetRegion(int id);
        Task<List<RegionListItem>> GetRegions();
    }
}
