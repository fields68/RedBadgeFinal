using System.ComponentModel.DataAnnotations;

namespace RedBadgeFinal.Models.ElementModels
{
    public class ElementCreate
    {
        [Required]
        public string Type { get; set; } = null!;
    }
}
