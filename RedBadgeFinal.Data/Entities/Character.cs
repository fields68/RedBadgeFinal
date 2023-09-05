using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedBadgeFinal.Data.Entities
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string OwnerId { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;
        public int ElementId { get; set; }
        
        [ForeignKey(nameof(ElementId))]
        public virtual Element Element { get; set; } = null!;
        public int WeaponId { get; set; }

        [ForeignKey(nameof(WeaponId))]
        public virtual Weapon Weapon { get; set; } = null!;

        //public int CWId { get; set; }

        //[ForeignKey(nameof(CWId))]
        //public virtual CharacterWeapon CharacterWeapon { get; set; } = null!;

        public int RegionId { get; set; }

        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; } = null!;


    }
}
