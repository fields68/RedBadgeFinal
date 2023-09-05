using AutoMapper;
using RedBadgeFinal.Data.Data;
using RedBadgeFinal.Data.Entities;
using RedBadgeFinal.Models.ElementModels;
using RedBadgeFinal.Services.BusinessLogic.IServices;
using System.Data.Entity;

namespace RedBadgeFinal.Services.BusinessLogic
{
    public class ElementServices : IElementService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public ElementServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateElement(ElementCreate model)
        {
            var element = _mapper.Map<Element>(model);
            await _context.Elements.AddAsync(element);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<ElementDetail> GetElement(int id)
        {
            var element = await _context.Elements.FindAsync(id);
            if (element is null) return new ElementDetail();

            return _mapper.Map<ElementDetail>(element);
        }

        public async Task<List<ElementListItem>> GetElements()
        {
            var elements = await _context.Elements.ToListAsync();
            return _mapper.Map<List<ElementListItem>>(elements);
        }
    }
}
