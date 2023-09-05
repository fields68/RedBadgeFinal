using RedBadgeFinal.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeFinal.Models.CharacterModels
{
    public class CharacterEdit
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public int ElementId { get; set; }

        [Required]
        public int WeaponId { get; set; }

        [Required]
        public int RegionId { get; set; }
    }
}
