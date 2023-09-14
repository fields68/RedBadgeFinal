using RedBadgeFinal.Models.CharacterModels;
using RedBadgeFinal.Models.ElementModels;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    public interface IElementService
    {
        Task<bool> CreateElement (ElementCreate model);
		Task<bool> UpdateElement(ElementEdit model);
		Task<bool> DeleteElement(int id);
		Task<ElementDetail> GetElement(int id);
        Task<List<ElementListItem>> GetElements();
    }
}
