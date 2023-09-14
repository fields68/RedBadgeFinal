using RedBadgeFinal.Models.ElementModels;
using RedBadgeFinal.Models.RegionModels;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    public interface IRegionService
    {
        Task<bool> CreateRegion(RegionCreate model);
		Task<bool> UpdateRegion(RegionEdit model);
		Task<bool> DeleteRegion(int id);
		Task<RegionDetail> GetRegion(int id);
        Task<List<RegionListItem>> GetRegions();
    }
}
