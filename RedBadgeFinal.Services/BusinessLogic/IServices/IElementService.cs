using RedBadgeFinal.Models.ElementModels;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    internal interface IElementService
    {
        Task<bool> CreateElement (ElementCreate model);
        Task<ElementDetail> GetElement(int id);
        Task<List<ElementListItem>> GetElements();
    }
}
