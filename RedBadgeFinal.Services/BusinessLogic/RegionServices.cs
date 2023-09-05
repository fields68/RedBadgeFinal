using AutoMapper;
using RedBadgeFinal.Data.Data;
using RedBadgeFinal.Models.RegionModels;
using RedBadgeFinal.Services.BusinessLogic.IServices;
using System.Data.Entity;

namespace RedBadgeFinal.Services.BusinessLogic
{
    public class RegionServices : IRegionService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public RegionServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateRegion(RegionCreate model)
        {
            var region = _mapper.Map<Region>(model);
            await _context.Regions.AddAsync(region);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<RegionDetail> GetRegion(int id)
        {
            var region = await _context.Regions.FindAsync(id);
            if (region is null) return new RegionDetail();

            return _mapper.Map<RegionDetail>(region);
        }

        public async Task<List<RegionListItem>> GetRegions()
        {
            var regions = await _context.Regions.ToListAsync();
            return _mapper.Map<List<RegionListItem>>(regions);
        }
    }
}
