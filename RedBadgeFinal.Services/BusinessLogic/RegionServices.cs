using AutoMapper;
using RedBadgeFinal.Data.Data;
using RedBadgeFinal.Data.Entities;
using RedBadgeFinal.Models.RegionModels;
using RedBadgeFinal.Services.BusinessLogic.IServices;
using Microsoft.EntityFrameworkCore;

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

		public async Task<bool> DeleteRegion(int id)
		{
			var region = await _context.Regions
				.FirstOrDefaultAsync(e => e.Id == id);

			if (region == null) return false;

			_context.Regions.Remove(region);
			return await _context.SaveChangesAsync() == 1;
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

		public async Task<bool> UpdateRegion(RegionEdit model)
		{
			var region = await _context.Regions
				.SingleOrDefaultAsync(e => e.Id == model.Id);

			if (region is null) return false;

			region.Id = model.Id;
			region.Name = model.Name;
			await _context.SaveChangesAsync();

			return true;
		}
	}
}
