using System.ComponentModel.DataAnnotations;

namespace RedBadgeFinal.Data.Entities
{
    public class Region
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
