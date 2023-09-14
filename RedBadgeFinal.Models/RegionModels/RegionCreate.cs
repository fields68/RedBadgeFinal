using System.ComponentModel.DataAnnotations;

namespace RedBadgeFinal.Models.RegionModels
{
    public class RegionCreate
    {
        [Required]
        public string Name { get; set; } = null!;
    }
}
