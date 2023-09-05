using RedBadgeFinal.Models.ElementModels;
using RedBadgeFinal.Models.RegionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeFinal.Services.BusinessLogic.IServices
{
    internal interface IElementService
    {
        Task<bool> CreateElement (ElementCreate model);
        Task<ElementDetail> GetElement(int id);
        Task<List<ElementListItem>> GetElements();
    }
}
