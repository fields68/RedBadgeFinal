using AutoMapper;
using RedBadgeFinal.Data.Data;
using RedBadgeFinal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using RedBadgeFinal.Models.ElementModels;
using RedBadgeFinal.Services.BusinessLogic.IServices;
using System.Security.Cryptography.Xml;

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

		public async Task<bool> DeleteElement(int id)
		{
			var element = await _context.Elements
                .FirstOrDefaultAsync(e=>e.Id==id);

            if (element == null) return false;

            _context.Elements.Remove(element);
            return await _context.SaveChangesAsync() == 1;
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

		public async Task<bool> UpdateElement(ElementEdit model)
		{
            var element = await _context.Elements
                .SingleOrDefaultAsync(e=>e.Id==model.Id);

            if (element is null) return false;

            element.Id = model.Id;
            element.Type= model.Type;
            await _context.SaveChangesAsync();

            return true;
		}
	}
}
