using System.ComponentModel.DataAnnotations;

namespace RedBadgeFinal.Models.WeaponModels
{
    public class WeaponCreate
    {
        [Required]
        public string Type { get; set; } = null!;
    }
}
