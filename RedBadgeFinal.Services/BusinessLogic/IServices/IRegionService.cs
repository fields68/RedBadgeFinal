using RedBadgeFinal.Models.RegionModels;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    public interface IRegionService
    {
        Task<bool> CreateRegion(RegionCreate model);
        Task<RegionDetail> GetRegion(int id);
        Task<List<RegionListItem>> GetRegions();
    }
}
