using System.ComponentModel.DataAnnotations.Schema;

namespace RedBadgeFinal_BlazorServer.Data.Entities
{
    public class CharacterWeapon
    {
        public int Id { get; set; }
        public string CharacterId { get; set; } = null!;

        [ForeignKey(nameof(CharacterId))]
        public virtual Character Character { get; set; } = null!;
        public string WeaponId { get; set; } = null!;

        [ForeignKey(nameof(WeaponId))]
        public virtual Weapon Weapon { get; set; } = null!;
    }
}
