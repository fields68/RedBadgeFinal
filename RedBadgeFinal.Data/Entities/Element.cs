using System.ComponentModel.DataAnnotations;

namespace RedBadgeFinal.Data.Entities
{
    public class Element
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; } = null!;
    }
}
